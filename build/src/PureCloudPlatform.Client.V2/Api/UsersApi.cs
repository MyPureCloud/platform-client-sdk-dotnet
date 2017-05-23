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
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Empty</returns>
        Empty DeleteUser (string userId);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> DeleteUserWithHttpInfo (string userId);
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
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns></returns>
        void DeleteUserRoutingskill (string userId, string skillId);

        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserRoutingskillWithHttpInfo (string userId, string skillId);
        /// <summary>
        /// Clear associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void DeleteUserStationAssociatedstation (string userId);

        /// <summary>
        /// Clear associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserStationAssociatedstationWithHttpInfo (string userId);
        /// <summary>
        /// Clear default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void DeleteUserStationDefaultstation (string userId);

        /// <summary>
        /// Clear default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserStationDefaultstationWithHttpInfo (string userId);
        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>FieldConfig</returns>
        FieldConfig GetFieldconfig (string type);

        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>ApiResponse of FieldConfig</returns>
        ApiResponse<FieldConfig> GetFieldconfigWithHttpInfo (string type);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        User GetUser (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Adjacents</returns>
        Adjacents GetUserAdjacents (string userId, List<string> expand = null);

        /// <summary>
        /// Get adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Adjacents</returns>
        ApiResponse<Adjacents> GetUserAdjacentsWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>CallForwarding</returns>
        CallForwarding GetUserCallforwarding (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> GetUserCallforwardingWithHttpInfo (string userId);
        /// <summary>
        /// Get direct reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> GetUserDirectreports (string userId, List<string> expand = null);

        /// <summary>
        /// Get direct reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of List&lt;User&gt;</returns>
        ApiResponse<List<User>> GetUserDirectreportsWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UserEntityListing</returns>
        UserEntityListing GetUserFavorites (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Get favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UserEntityListing</returns>
        ApiResponse<UserEntityListing> GetUserFavoritesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        Geolocation GetUserGeolocation (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> GetUserGeolocationWithHttpInfo (string userId, string clientId);
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice GetUserOutofoffice (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> GetUserOutofofficeWithHttpInfo (string userId);
        /// <summary>
        /// List profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetUserProfileskills (string userId);

        /// <summary>
        /// List profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetUserProfileskillsWithHttpInfo (string userId);
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>UserQueueEntityListing</returns>
        UserQueueEntityListing GetUserQueues (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        ApiResponse<UserQueueEntityListing> GetUserQueuesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null);
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
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>UserSkillEntityListing</returns>
        UserSkillEntityListing GetUserRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        ApiResponse<UserSkillEntityListing> GetUserRoutingskillsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus GetUserRoutingstatus (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> GetUserRoutingstatusWithHttpInfo (string userId);
        /// <summary>
        /// Get station information for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserStations</returns>
        UserStations GetUserStation (string userId);

        /// <summary>
        /// Get station information for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserStations</returns>
        ApiResponse<UserStations> GetUserStationWithHttpInfo (string userId);
        /// <summary>
        /// Get superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> GetUserSuperiors (string userId, List<string> expand = null);

        /// <summary>
        /// Get superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of List&lt;User&gt;</returns>
        ApiResponse<List<User>> GetUserSuperiorsWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>UserEntityListing</returns>
        UserEntityListing GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>ApiResponse of UserEntityListing</returns>
        ApiResponse<UserEntityListing> GetUsersWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null);
        /// <summary>
        /// Get current user details.
        /// </summary>
        /// <remarks>
        /// This request is not valid when using the Client Credentials OAuth grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>UserMe</returns>
        UserMe GetUsersMe (List<string> expand = null);

        /// <summary>
        /// Get current user details.
        /// </summary>
        /// <remarks>
        /// This request is not valid when using the Client Credentials OAuth grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of UserMe</returns>
        ApiResponse<UserMe> GetUsersMeWithHttpInfo (List<string> expand = null);
        /// <summary>
        /// Search users using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>UsersSearchResponse</returns>
        UsersSearchResponse GetUsersSearch (string q64, List<string> expand = null);

        /// <summary>
        /// Search users using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of UsersSearchResponse</returns>
        ApiResponse<UsersSearchResponse> GetUsersSearchWithHttpInfo (string q64, List<string> expand = null);
        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>User</returns>
        User PatchUser (string userId, UpdateUser body);

        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> PatchUserWithHttpInfo (string userId, UpdateUser body);
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>CallForwarding</returns>
        CallForwarding PatchUserCallforwarding (string userId, CallForwarding body);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> PatchUserCallforwardingWithHttpInfo (string userId, CallForwarding body);
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Geolocation</returns>
        Geolocation PatchUserGeolocation (string userId, string clientId, Geolocation body);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> PatchUserGeolocationWithHttpInfo (string userId, string clientId, Geolocation body);
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>UserQueue</returns>
        UserQueue PatchUserQueue (string queueId, string userId, UserQueue body);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>ApiResponse of UserQueue</returns>
        ApiResponse<UserQueue> PatchUserQueueWithHttpInfo (string queueId, string userId, UserQueue body);
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>UserQueueEntityListing</returns>
        UserQueueEntityListing PatchUserQueues (string userId, List<UserQueue> body);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        ApiResponse<UserQueueEntityListing> PatchUserQueuesWithHttpInfo (string userId, List<UserQueue> body);
        /// <summary>
        /// Query for user aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>PresenceQueryResponse</returns>
        PresenceQueryResponse PostAnalyticsUsersAggregatesQuery (AggregationQuery body);

        /// <summary>
        /// Query for user aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of PresenceQueryResponse</returns>
        ApiResponse<PresenceQueryResponse> PostAnalyticsUsersAggregatesQueryWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Query for user details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsUserDetailsQueryResponse</returns>
        AnalyticsUserDetailsQueryResponse PostAnalyticsUsersDetailsQuery (UserDetailsQuery body);

        /// <summary>
        /// Query for user details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsUserDetailsQueryResponse</returns>
        ApiResponse<AnalyticsUserDetailsQueryResponse> PostAnalyticsUsersDetailsQueryWithHttpInfo (UserDetailsQuery body);
        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ObservationQueryResponse</returns>
        ObservationQueryResponse PostAnalyticsUsersObservationsQuery (ObservationQuery body);

        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        ApiResponse<ObservationQueryResponse> PostAnalyticsUsersObservationsQueryWithHttpInfo (ObservationQuery body);
        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>UserRoutingSkill</returns>
        UserRoutingSkill PostUserRoutingskills (string userId, UserRoutingSkillPost body);

        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        ApiResponse<UserRoutingSkill> PostUserRoutingskillsWithHttpInfo (string userId, UserRoutingSkillPost body);
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>User</returns>
        User PostUsers (CreateUser body);

        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> PostUsersWithHttpInfo (CreateUser body);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>UsersSearchResponse</returns>
        UsersSearchResponse PostUsersSearch (UserSearchRequest body);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of UsersSearchResponse</returns>
        ApiResponse<UsersSearchResponse> PostUsersSearchWithHttpInfo (UserSearchRequest body);
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>CallForwarding</returns>
        CallForwarding PutUserCallforwarding (string userId, CallForwarding body);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> PutUserCallforwardingWithHttpInfo (string userId, CallForwarding body);
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice PutUserOutofoffice (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> PutUserOutofofficeWithHttpInfo (string userId, OutOfOffice body);
        /// <summary>
        /// Update profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> PutUserProfileskills (string userId, List<string> body = null);

        /// <summary>
        /// Update profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> PutUserProfileskillsWithHttpInfo (string userId, List<string> body = null);
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
        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>UserRoutingSkill</returns>
        UserRoutingSkill PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body);

        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        ApiResponse<UserRoutingSkill> PutUserRoutingskillWithHttpInfo (string userId, string skillId, UserRoutingSkill body);
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus PutUserRoutingstatus (string userId, RoutingStatus body);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> PutUserRoutingstatusWithHttpInfo (string userId, RoutingStatus body);
        /// <summary>
        /// Set associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns></returns>
        void PutUserStationAssociatedstationStationId (string userId, string stationId);

        /// <summary>
        /// Set associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserStationAssociatedstationStationIdWithHttpInfo (string userId, string stationId);
        /// <summary>
        /// Set default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns></returns>
        void PutUserStationDefaultstationStationId (string userId, string stationId);

        /// <summary>
        /// Set default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserStationDefaultstationStationIdWithHttpInfo (string userId, string stationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> DeleteUserAsync (string userId);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteUserAsyncWithHttpInfo (string userId);
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
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserRoutingskillAsync (string userId, string skillId);

        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRoutingskillAsyncWithHttpInfo (string userId, string skillId);
        /// <summary>
        /// Clear associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserStationAssociatedstationAsync (string userId);

        /// <summary>
        /// Clear associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserStationAssociatedstationAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Clear default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserStationDefaultstationAsync (string userId);

        /// <summary>
        /// Clear default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserStationDefaultstationAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of FieldConfig</returns>
        System.Threading.Tasks.Task<FieldConfig> GetFieldconfigAsync (string type);

        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of ApiResponse (FieldConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldConfig>> GetFieldconfigAsyncWithHttpInfo (string type);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of Adjacents</returns>
        System.Threading.Tasks.Task<Adjacents> GetUserAdjacentsAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Adjacents)</returns>
        System.Threading.Tasks.Task<ApiResponse<Adjacents>> GetUserAdjacentsAsyncWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> GetUserCallforwardingAsync (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> GetUserCallforwardingAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get direct reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of List&lt;User&gt;</returns>
        System.Threading.Tasks.Task<List<User>> GetUserDirectreportsAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get direct reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<User>>> GetUserDirectreportsAsyncWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UserEntityListing</returns>
        System.Threading.Tasks.Task<UserEntityListing> GetUserFavoritesAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Get favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UserEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserEntityListing>> GetUserFavoritesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> GetUserGeolocationAsync (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserGeolocationAsyncWithHttpInfo (string userId, string clientId);
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> GetUserOutofofficeAsync (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> GetUserOutofofficeAsyncWithHttpInfo (string userId);
        /// <summary>
        /// List profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetUserProfileskillsAsync (string userId);

        /// <summary>
        /// List profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetUserProfileskillsAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        System.Threading.Tasks.Task<UserQueueEntityListing> GetUserQueuesAsync (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> GetUserQueuesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null);
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
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        System.Threading.Tasks.Task<UserSkillEntityListing> GetUserRoutingskillsAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserRoutingskillsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> GetUserRoutingstatusAsync (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> GetUserRoutingstatusAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get station information for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserStations</returns>
        System.Threading.Tasks.Task<UserStations> GetUserStationAsync (string userId);

        /// <summary>
        /// Get station information for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserStations)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserStations>> GetUserStationAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of List&lt;User&gt;</returns>
        System.Threading.Tasks.Task<List<User>> GetUserSuperiorsAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<User>>> GetUserSuperiorsAsyncWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>Task of UserEntityListing</returns>
        System.Threading.Tasks.Task<UserEntityListing> GetUsersAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>Task of ApiResponse (UserEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserEntityListing>> GetUsersAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null);
        /// <summary>
        /// Get current user details.
        /// </summary>
        /// <remarks>
        /// This request is not valid when using the Client Credentials OAuth grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of UserMe</returns>
        System.Threading.Tasks.Task<UserMe> GetUsersMeAsync (List<string> expand = null);

        /// <summary>
        /// Get current user details.
        /// </summary>
        /// <remarks>
        /// This request is not valid when using the Client Credentials OAuth grant.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (UserMe)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserMe>> GetUsersMeAsyncWithHttpInfo (List<string> expand = null);
        /// <summary>
        /// Search users using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of UsersSearchResponse</returns>
        System.Threading.Tasks.Task<UsersSearchResponse> GetUsersSearchAsync (string q64, List<string> expand = null);

        /// <summary>
        /// Search users using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsersSearchResponse>> GetUsersSearchAsyncWithHttpInfo (string q64, List<string> expand = null);
        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> PatchUserAsync (string userId, UpdateUser body);

        /// <summary>
        /// Update user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> PatchUserAsyncWithHttpInfo (string userId, UpdateUser body);
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> PatchUserCallforwardingAsync (string userId, CallForwarding body);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PatchUserCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body);
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> PatchUserGeolocationAsync (string userId, string clientId, Geolocation body);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserGeolocationAsyncWithHttpInfo (string userId, string clientId, Geolocation body);
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of UserQueue</returns>
        System.Threading.Tasks.Task<UserQueue> PatchUserQueueAsync (string queueId, string userId, UserQueue body);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserQueueAsyncWithHttpInfo (string queueId, string userId, UserQueue body);
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        System.Threading.Tasks.Task<UserQueueEntityListing> PatchUserQueuesAsync (string userId, List<UserQueue> body);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> PatchUserQueuesAsyncWithHttpInfo (string userId, List<UserQueue> body);
        /// <summary>
        /// Query for user aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of PresenceQueryResponse</returns>
        System.Threading.Tasks.Task<PresenceQueryResponse> PostAnalyticsUsersAggregatesQueryAsync (AggregationQuery body);

        /// <summary>
        /// Query for user aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (PresenceQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PresenceQueryResponse>> PostAnalyticsUsersAggregatesQueryAsyncWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Query for user details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsUserDetailsQueryResponse</returns>
        System.Threading.Tasks.Task<AnalyticsUserDetailsQueryResponse> PostAnalyticsUsersDetailsQueryAsync (UserDetailsQuery body);

        /// <summary>
        /// Query for user details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsUserDetailsQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsUserDetailsQueryResponse>> PostAnalyticsUsersDetailsQueryAsyncWithHttpInfo (UserDetailsQuery body);
        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        System.Threading.Tasks.Task<ObservationQueryResponse> PostAnalyticsUsersObservationsQueryAsync (ObservationQuery body);

        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostAnalyticsUsersObservationsQueryAsyncWithHttpInfo (ObservationQuery body);
        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of UserRoutingSkill</returns>
        System.Threading.Tasks.Task<UserRoutingSkill> PostUserRoutingskillsAsync (string userId, UserRoutingSkillPost body);

        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PostUserRoutingskillsAsyncWithHttpInfo (string userId, UserRoutingSkillPost body);
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> PostUsersAsync (CreateUser body);

        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> PostUsersAsyncWithHttpInfo (CreateUser body);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of UsersSearchResponse</returns>
        System.Threading.Tasks.Task<UsersSearchResponse> PostUsersSearchAsync (UserSearchRequest body);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsersSearchResponse>> PostUsersSearchAsyncWithHttpInfo (UserSearchRequest body);
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> PutUserCallforwardingAsync (string userId, CallForwarding body);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PutUserCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body);
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> PutUserOutofofficeAsync (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> PutUserOutofofficeAsyncWithHttpInfo (string userId, OutOfOffice body);
        /// <summary>
        /// Update profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> PutUserProfileskillsAsync (string userId, List<string> body = null);

        /// <summary>
        /// Update profile skills for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> PutUserProfileskillsAsyncWithHttpInfo (string userId, List<string> body = null);
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
        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of UserRoutingSkill</returns>
        System.Threading.Tasks.Task<UserRoutingSkill> PutUserRoutingskillAsync (string userId, string skillId, UserRoutingSkill body);

        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PutUserRoutingskillAsyncWithHttpInfo (string userId, string skillId, UserRoutingSkill body);
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> PutUserRoutingstatusAsync (string userId, RoutingStatus body);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> PutUserRoutingstatusAsyncWithHttpInfo (string userId, RoutingStatus body);
        /// <summary>
        /// Set associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserStationAssociatedstationStationIdAsync (string userId, string stationId);

        /// <summary>
        /// Set associated station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserStationAssociatedstationStationIdAsyncWithHttpInfo (string userId, string stationId);
        /// <summary>
        /// Set default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserStationDefaultstationStationIdAsync (string userId, string stationId);

        /// <summary>
        /// Set default station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserStationDefaultstationStationIdAsyncWithHttpInfo (string userId, string stationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Delete user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Empty</returns>
        public Empty DeleteUser (string userId)
        {
             ApiResponse<Empty> localVarResponse = DeleteUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > DeleteUserWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUser");

            var localVarPath = "/api/v2/users/{userId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Delete user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> DeleteUserAsync (string userId)
        {
             ApiResponse<Empty> localVarResponse = await DeleteUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteUserAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUser");

            var localVarPath = "/api/v2/users/{userId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserRoles");

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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserRoles");

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
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns></returns>
        public void DeleteUserRoutingskill (string userId, string skillId)
        {
             DeleteUserRoutingskillWithHttpInfo(userId, skillId);
        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserRoutingskillWithHttpInfo (string userId, string skillId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserRoutingskill");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling UsersApi->DeleteUserRoutingskill");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoutingskill: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoutingskill: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserRoutingskillAsync (string userId, string skillId)
        {
             await DeleteUserRoutingskillAsyncWithHttpInfo(userId, skillId);

        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRoutingskillAsyncWithHttpInfo (string userId, string skillId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserRoutingskill");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling UsersApi->DeleteUserRoutingskill");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoutingskill: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoutingskill: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Clear associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public void DeleteUserStationAssociatedstation (string userId)
        {
             DeleteUserStationAssociatedstationWithHttpInfo(userId);
        }

        /// <summary>
        /// Clear associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserStationAssociatedstationWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserStationAssociatedstation");

            var localVarPath = "/api/v2/users/{userId}/station/associatedstation";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationAssociatedstation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationAssociatedstation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Clear associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserStationAssociatedstationAsync (string userId)
        {
             await DeleteUserStationAssociatedstationAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Clear associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserStationAssociatedstationAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserStationAssociatedstation");

            var localVarPath = "/api/v2/users/{userId}/station/associatedstation";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationAssociatedstation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationAssociatedstation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Clear default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public void DeleteUserStationDefaultstation (string userId)
        {
             DeleteUserStationDefaultstationWithHttpInfo(userId);
        }

        /// <summary>
        /// Clear default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserStationDefaultstationWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserStationDefaultstation");

            var localVarPath = "/api/v2/users/{userId}/station/defaultstation";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationDefaultstation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationDefaultstation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Clear default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserStationDefaultstationAsync (string userId)
        {
             await DeleteUserStationDefaultstationAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Clear default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserStationDefaultstationAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserStationDefaultstation");

            var localVarPath = "/api/v2/users/{userId}/station/defaultstation";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationDefaultstation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserStationDefaultstation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>FieldConfig</returns>
        public FieldConfig GetFieldconfig (string type)
        {
             ApiResponse<FieldConfig> localVarResponse = GetFieldconfigWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>ApiResponse of FieldConfig</returns>
        public ApiResponse< FieldConfig > GetFieldconfigWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling UsersApi->GetFieldconfig");

            var localVarPath = "/api/v2/fieldconfig";
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
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FieldConfig>(localVarStatusCode,
                localVarHeaders,
                (FieldConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)));
            
        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of FieldConfig</returns>
        public async System.Threading.Tasks.Task<FieldConfig> GetFieldconfigAsync (string type)
        {
             ApiResponse<FieldConfig> localVarResponse = await GetFieldconfigAsyncWithHttpInfo(type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of ApiResponse (FieldConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldConfig>> GetFieldconfigAsyncWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling UsersApi->GetFieldconfig");

            var localVarPath = "/api/v2/fieldconfig";
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
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FieldConfig>(localVarStatusCode,
                localVarHeaders,
                (FieldConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        public User GetUser (string userId, List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = GetUserWithHttpInfo(userId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetUserWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUser");

            var localVarPath = "/api/v2/users/{userId}";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync (string userId, List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = await GetUserAsyncWithHttpInfo(userId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUser");

            var localVarPath = "/api/v2/users/{userId}";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get adjacents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Adjacents</returns>
        public Adjacents GetUserAdjacents (string userId, List<string> expand = null)
        {
             ApiResponse<Adjacents> localVarResponse = GetUserAdjacentsWithHttpInfo(userId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get adjacents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Adjacents</returns>
        public ApiResponse< Adjacents > GetUserAdjacentsWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserAdjacents");

            var localVarPath = "/api/v2/users/{userId}/adjacents";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserAdjacents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserAdjacents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Adjacents>(localVarStatusCode,
                localVarHeaders,
                (Adjacents) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Adjacents)));
            
        }

        /// <summary>
        /// Get adjacents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of Adjacents</returns>
        public async System.Threading.Tasks.Task<Adjacents> GetUserAdjacentsAsync (string userId, List<string> expand = null)
        {
             ApiResponse<Adjacents> localVarResponse = await GetUserAdjacentsAsyncWithHttpInfo(userId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get adjacents 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Adjacents)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Adjacents>> GetUserAdjacentsAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserAdjacents");

            var localVarPath = "/api/v2/users/{userId}/adjacents";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserAdjacents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserAdjacents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Adjacents>(localVarStatusCode,
                localVarHeaders,
                (Adjacents) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Adjacents)));
            
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding GetUserCallforwarding (string userId)
        {
             ApiResponse<CallForwarding> localVarResponse = GetUserCallforwardingWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > GetUserCallforwardingWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> GetUserCallforwardingAsync (string userId)
        {
             ApiResponse<CallForwarding> localVarResponse = await GetUserCallforwardingAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> GetUserCallforwardingAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Get direct reports 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> GetUserDirectreports (string userId, List<string> expand = null)
        {
             ApiResponse<List<User>> localVarResponse = GetUserDirectreportsWithHttpInfo(userId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get direct reports 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of List&lt;User&gt;</returns>
        public ApiResponse< List<User> > GetUserDirectreportsWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserDirectreports");

            var localVarPath = "/api/v2/users/{userId}/directreports";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDirectreports: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDirectreports: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarHeaders,
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
            
        }

        /// <summary>
        /// Get direct reports 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of List&lt;User&gt;</returns>
        public async System.Threading.Tasks.Task<List<User>> GetUserDirectreportsAsync (string userId, List<string> expand = null)
        {
             ApiResponse<List<User>> localVarResponse = await GetUserDirectreportsAsyncWithHttpInfo(userId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get direct reports 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<User>>> GetUserDirectreportsAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserDirectreports");

            var localVarPath = "/api/v2/users/{userId}/directreports";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDirectreports: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDirectreports: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarHeaders,
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
            
        }

        /// <summary>
        /// Get favorites 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UserEntityListing</returns>
        public UserEntityListing GetUserFavorites (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<UserEntityListing> localVarResponse = GetUserFavoritesWithHttpInfo(userId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get favorites 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UserEntityListing</returns>
        public ApiResponse< UserEntityListing > GetUserFavoritesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserFavorites");

            var localVarPath = "/api/v2/users/{userId}/favorites";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserFavorites: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserFavorites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEntityListing)));
            
        }

        /// <summary>
        /// Get favorites 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UserEntityListing</returns>
        public async System.Threading.Tasks.Task<UserEntityListing> GetUserFavoritesAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<UserEntityListing> localVarResponse = await GetUserFavoritesAsyncWithHttpInfo(userId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get favorites 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UserEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserEntityListing>> GetUserFavoritesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserFavorites");

            var localVarPath = "/api/v2/users/{userId}/favorites";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserFavorites: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserFavorites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEntityListing)));
            
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        public Geolocation GetUserGeolocation (string userId, string clientId)
        {
             ApiResponse<Geolocation> localVarResponse = GetUserGeolocationWithHttpInfo(userId, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > GetUserGeolocationWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserGeolocation");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->GetUserGeolocation");

            var localVarPath = "/api/v2/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarHeaders,
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> GetUserGeolocationAsync (string userId, string clientId)
        {
             ApiResponse<Geolocation> localVarResponse = await GetUserGeolocationAsyncWithHttpInfo(userId, clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserGeolocationAsyncWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserGeolocation");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->GetUserGeolocation");

            var localVarPath = "/api/v2/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarHeaders,
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>OutOfOffice</returns>
        public OutOfOffice GetUserOutofoffice (string userId)
        {
             ApiResponse<OutOfOffice> localVarResponse = GetUserOutofofficeWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > GetUserOutofofficeWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserOutofoffice");

            var localVarPath = "/api/v2/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserOutofoffice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserOutofoffice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarHeaders,
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> GetUserOutofofficeAsync (string userId)
        {
             ApiResponse<OutOfOffice> localVarResponse = await GetUserOutofofficeAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> GetUserOutofofficeAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserOutofoffice");

            var localVarPath = "/api/v2/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserOutofoffice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserOutofoffice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarHeaders,
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// List profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetUserProfileskills (string userId)
        {
             ApiResponse<List<string>> localVarResponse = GetUserProfileskillsWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetUserProfileskillsWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserProfileskills");

            var localVarPath = "/api/v2/users/{userId}/profileskills";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfileskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfileskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// List profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetUserProfileskillsAsync (string userId)
        {
             ApiResponse<List<string>> localVarResponse = await GetUserProfileskillsAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetUserProfileskillsAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserProfileskills");

            var localVarPath = "/api/v2/users/{userId}/profileskills";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfileskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfileskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>UserQueueEntityListing</returns>
        public UserQueueEntityListing GetUserQueues (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = GetUserQueuesWithHttpInfo(userId, pageSize, pageNumber, joined);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        public ApiResponse< UserQueueEntityListing > GetUserQueuesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserQueues");

            var localVarPath = "/api/v2/users/{userId}/queues";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        public async System.Threading.Tasks.Task<UserQueueEntityListing> GetUserQueuesAsync (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = await GetUserQueuesAsyncWithHttpInfo(userId, pageSize, pageNumber, joined);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="joined">Is joined to the queue (optional, default to true)</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> GetUserQueuesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserQueues");

            var localVarPath = "/api/v2/users/{userId}/queues";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoles");

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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoles");

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
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>UserSkillEntityListing</returns>
        public UserSkillEntityListing GetUserRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = GetUserRoutingskillsWithHttpInfo(userId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        public ApiResponse< UserSkillEntityListing > GetUserRoutingskillsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        public async System.Threading.Tasks.Task<UserSkillEntityListing> GetUserRoutingskillsAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = await GetUserRoutingskillsAsyncWithHttpInfo(userId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserRoutingskillsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>RoutingStatus</returns>
        public RoutingStatus GetUserRoutingstatus (string userId)
        {
             ApiResponse<RoutingStatus> localVarResponse = GetUserRoutingstatusWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > GetUserRoutingstatusWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoutingstatus");

            var localVarPath = "/api/v2/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarHeaders,
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> GetUserRoutingstatusAsync (string userId)
        {
             ApiResponse<RoutingStatus> localVarResponse = await GetUserRoutingstatusAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> GetUserRoutingstatusAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRoutingstatus");

            var localVarPath = "/api/v2/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarHeaders,
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Get station information for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserStations</returns>
        public UserStations GetUserStation (string userId)
        {
             ApiResponse<UserStations> localVarResponse = GetUserStationWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get station information for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserStations</returns>
        public ApiResponse< UserStations > GetUserStationWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserStation");

            var localVarPath = "/api/v2/users/{userId}/station";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserStations>(localVarStatusCode,
                localVarHeaders,
                (UserStations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserStations)));
            
        }

        /// <summary>
        /// Get station information for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserStations</returns>
        public async System.Threading.Tasks.Task<UserStations> GetUserStationAsync (string userId)
        {
             ApiResponse<UserStations> localVarResponse = await GetUserStationAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get station information for user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserStations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserStations>> GetUserStationAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserStation");

            var localVarPath = "/api/v2/users/{userId}/station";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserStations>(localVarStatusCode,
                localVarHeaders,
                (UserStations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserStations)));
            
        }

        /// <summary>
        /// Get superiors 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> GetUserSuperiors (string userId, List<string> expand = null)
        {
             ApiResponse<List<User>> localVarResponse = GetUserSuperiorsWithHttpInfo(userId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get superiors 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of List&lt;User&gt;</returns>
        public ApiResponse< List<User> > GetUserSuperiorsWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserSuperiors");

            var localVarPath = "/api/v2/users/{userId}/superiors";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserSuperiors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserSuperiors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarHeaders,
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
            
        }

        /// <summary>
        /// Get superiors 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of List&lt;User&gt;</returns>
        public async System.Threading.Tasks.Task<List<User>> GetUserSuperiorsAsync (string userId, List<string> expand = null)
        {
             ApiResponse<List<User>> localVarResponse = await GetUserSuperiorsAsyncWithHttpInfo(userId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get superiors 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<User>>> GetUserSuperiorsAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserSuperiors");

            var localVarPath = "/api/v2/users/{userId}/superiors";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserSuperiors: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserSuperiors: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarHeaders,
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
            
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>UserEntityListing</returns>
        public UserEntityListing GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null)
        {
             ApiResponse<UserEntityListing> localVarResponse = GetUsersWithHttpInfo(pageSize, pageNumber, id, sortOrder, expand, state);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>ApiResponse of UserEntityListing</returns>
        public ApiResponse< UserEntityListing > GetUsersWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null)
        {

            var localVarPath = "/api/v2/users";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEntityListing)));
            
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>Task of UserEntityListing</returns>
        public async System.Threading.Tasks.Task<UserEntityListing> GetUsersAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null)
        {
             ApiResponse<UserEntityListing> localVarResponse = await GetUsersAsyncWithHttpInfo(pageSize, pageNumber, id, sortOrder, expand, state);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="state">Only list users of this state (optional, default to active)</param>
        /// <returns>Task of ApiResponse (UserEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserEntityListing>> GetUsersAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null, string state = null)
        {

            var localVarPath = "/api/v2/users";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEntityListing)));
            
        }

        /// <summary>
        /// Get current user details. This request is not valid when using the Client Credentials OAuth grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>UserMe</returns>
        public UserMe GetUsersMe (List<string> expand = null)
        {
             ApiResponse<UserMe> localVarResponse = GetUsersMeWithHttpInfo(expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user details. This request is not valid when using the Client Credentials OAuth grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of UserMe</returns>
        public ApiResponse< UserMe > GetUsersMeWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v2/users/me";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserMe>(localVarStatusCode,
                localVarHeaders,
                (UserMe) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserMe)));
            
        }

        /// <summary>
        /// Get current user details. This request is not valid when using the Client Credentials OAuth grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of UserMe</returns>
        public async System.Threading.Tasks.Task<UserMe> GetUsersMeAsync (List<string> expand = null)
        {
             ApiResponse<UserMe> localVarResponse = await GetUsersMeAsyncWithHttpInfo(expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current user details. This request is not valid when using the Client Credentials OAuth grant.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (UserMe)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserMe>> GetUsersMeAsyncWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v2/users/me";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserMe>(localVarStatusCode,
                localVarHeaders,
                (UserMe) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserMe)));
            
        }

        /// <summary>
        /// Search users using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>UsersSearchResponse</returns>
        public UsersSearchResponse GetUsersSearch (string q64, List<string> expand = null)
        {
             ApiResponse<UsersSearchResponse> localVarResponse = GetUsersSearchWithHttpInfo(q64, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search users using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of UsersSearchResponse</returns>
        public ApiResponse< UsersSearchResponse > GetUsersSearchWithHttpInfo (string q64, List<string> expand = null)
        {
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling UsersApi->GetUsersSearch");

            var localVarPath = "/api/v2/users/search";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)));
            
        }

        /// <summary>
        /// Search users using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of UsersSearchResponse</returns>
        public async System.Threading.Tasks.Task<UsersSearchResponse> GetUsersSearchAsync (string q64, List<string> expand = null)
        {
             ApiResponse<UsersSearchResponse> localVarResponse = await GetUsersSearchAsyncWithHttpInfo(q64, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search users using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsersSearchResponse>> GetUsersSearchAsyncWithHttpInfo (string q64, List<string> expand = null)
        {
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling UsersApi->GetUsersSearch");

            var localVarPath = "/api/v2/users/search";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)));
            
        }

        /// <summary>
        /// Update user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>User</returns>
        public User PatchUser (string userId, UpdateUser body)
        {
             ApiResponse<User> localVarResponse = PatchUserWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > PatchUserWithHttpInfo (string userId, UpdateUser body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUser");

            var localVarPath = "/api/v2/users/{userId}";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Update user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> PatchUserAsync (string userId, UpdateUser body)
        {
             ApiResponse<User> localVarResponse = await PatchUserAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> PatchUserAsyncWithHttpInfo (string userId, UpdateUser body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUser");

            var localVarPath = "/api/v2/users/{userId}";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding PatchUserCallforwarding (string userId, CallForwarding body)
        {
             ApiResponse<CallForwarding> localVarResponse = PatchUserCallforwardingWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > PatchUserCallforwardingWithHttpInfo (string userId, CallForwarding body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserCallforwarding");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> PatchUserCallforwardingAsync (string userId, CallForwarding body)
        {
             ApiResponse<CallForwarding> localVarResponse = await PatchUserCallforwardingAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PatchUserCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserCallforwarding");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Geolocation</returns>
        public Geolocation PatchUserGeolocation (string userId, string clientId, Geolocation body)
        {
             ApiResponse<Geolocation> localVarResponse = PatchUserGeolocationWithHttpInfo(userId, clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > PatchUserGeolocationWithHttpInfo (string userId, string clientId, Geolocation body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserGeolocation");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->PatchUserGeolocation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserGeolocation");

            var localVarPath = "/api/v2/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarHeaders,
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> PatchUserGeolocationAsync (string userId, string clientId, Geolocation body)
        {
             ApiResponse<Geolocation> localVarResponse = await PatchUserGeolocationAsyncWithHttpInfo(userId, clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body">Geolocation</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserGeolocationAsyncWithHttpInfo (string userId, string clientId, Geolocation body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserGeolocation");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->PatchUserGeolocation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserGeolocation");

            var localVarPath = "/api/v2/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarHeaders,
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>UserQueue</returns>
        public UserQueue PatchUserQueue (string queueId, string userId, UserQueue body)
        {
             ApiResponse<UserQueue> localVarResponse = PatchUserQueueWithHttpInfo(queueId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>ApiResponse of UserQueue</returns>
        public ApiResponse< UserQueue > PatchUserQueueWithHttpInfo (string queueId, string userId, UserQueue body)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling UsersApi->PatchUserQueue");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserQueue");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserQueue");

            var localVarPath = "/api/v2/users/{userId}/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarHeaders,
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of UserQueue</returns>
        public async System.Threading.Tasks.Task<UserQueue> PatchUserQueueAsync (string queueId, string userId, UserQueue body)
        {
             ApiResponse<UserQueue> localVarResponse = await PatchUserQueueAsyncWithHttpInfo(queueId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserQueueAsyncWithHttpInfo (string queueId, string userId, UserQueue body)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling UsersApi->PatchUserQueue");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserQueue");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserQueue");

            var localVarPath = "/api/v2/users/{userId}/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarHeaders,
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>UserQueueEntityListing</returns>
        public UserQueueEntityListing PatchUserQueues (string userId, List<UserQueue> body)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = PatchUserQueuesWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        public ApiResponse< UserQueueEntityListing > PatchUserQueuesWithHttpInfo (string userId, List<UserQueue> body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserQueues");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserQueues");

            var localVarPath = "/api/v2/users/{userId}/queues";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        public async System.Threading.Tasks.Task<UserQueueEntityListing> PatchUserQueuesAsync (string userId, List<UserQueue> body)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = await PatchUserQueuesAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> PatchUserQueuesAsyncWithHttpInfo (string userId, List<UserQueue> body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserQueues");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PatchUserQueues");

            var localVarPath = "/api/v2/users/{userId}/queues";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
        }

        /// <summary>
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>PresenceQueryResponse</returns>
        public PresenceQueryResponse PostAnalyticsUsersAggregatesQuery (AggregationQuery body)
        {
             ApiResponse<PresenceQueryResponse> localVarResponse = PostAnalyticsUsersAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of PresenceQueryResponse</returns>
        public ApiResponse< PresenceQueryResponse > PostAnalyticsUsersAggregatesQueryWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersAggregatesQuery");

            var localVarPath = "/api/v2/analytics/users/aggregates/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (PresenceQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceQueryResponse)));
            
        }

        /// <summary>
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of PresenceQueryResponse</returns>
        public async System.Threading.Tasks.Task<PresenceQueryResponse> PostAnalyticsUsersAggregatesQueryAsync (AggregationQuery body)
        {
             ApiResponse<PresenceQueryResponse> localVarResponse = await PostAnalyticsUsersAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (PresenceQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PresenceQueryResponse>> PostAnalyticsUsersAggregatesQueryAsyncWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersAggregatesQuery");

            var localVarPath = "/api/v2/analytics/users/aggregates/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (PresenceQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceQueryResponse)));
            
        }

        /// <summary>
        /// Query for user details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsUserDetailsQueryResponse</returns>
        public AnalyticsUserDetailsQueryResponse PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)
        {
             ApiResponse<AnalyticsUserDetailsQueryResponse> localVarResponse = PostAnalyticsUsersDetailsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for user details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsUserDetailsQueryResponse</returns>
        public ApiResponse< AnalyticsUserDetailsQueryResponse > PostAnalyticsUsersDetailsQueryWithHttpInfo (UserDetailsQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersDetailsQuery");

            var localVarPath = "/api/v2/analytics/users/details/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsUserDetailsQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsUserDetailsQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsUserDetailsQueryResponse)));
            
        }

        /// <summary>
        /// Query for user details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsUserDetailsQueryResponse</returns>
        public async System.Threading.Tasks.Task<AnalyticsUserDetailsQueryResponse> PostAnalyticsUsersDetailsQueryAsync (UserDetailsQuery body)
        {
             ApiResponse<AnalyticsUserDetailsQueryResponse> localVarResponse = await PostAnalyticsUsersDetailsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for user details 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsUserDetailsQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsUserDetailsQueryResponse>> PostAnalyticsUsersDetailsQueryAsyncWithHttpInfo (UserDetailsQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersDetailsQuery");

            var localVarPath = "/api/v2/analytics/users/details/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsUserDetailsQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsUserDetailsQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsUserDetailsQueryResponse)));
            
        }

        /// <summary>
        /// Query for user observations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ObservationQueryResponse</returns>
        public ObservationQueryResponse PostAnalyticsUsersObservationsQuery (ObservationQuery body)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = PostAnalyticsUsersObservationsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for user observations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        public ApiResponse< ObservationQueryResponse > PostAnalyticsUsersObservationsQueryWithHttpInfo (ObservationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersObservationsQuery");

            var localVarPath = "/api/v2/analytics/users/observations/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersObservationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
            
        }

        /// <summary>
        /// Query for user observations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ObservationQueryResponse> PostAnalyticsUsersObservationsQueryAsync (ObservationQuery body)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = await PostAnalyticsUsersObservationsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for user observations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostAnalyticsUsersObservationsQueryAsyncWithHttpInfo (ObservationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostAnalyticsUsersObservationsQuery");

            var localVarPath = "/api/v2/analytics/users/observations/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersObservationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsUsersObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
            
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>UserRoutingSkill</returns>
        public UserRoutingSkill PostUserRoutingskills (string userId, UserRoutingSkillPost body)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = PostUserRoutingskillsWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        public ApiResponse< UserRoutingSkill > PostUserRoutingskillsWithHttpInfo (string userId, UserRoutingSkillPost body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PostUserRoutingskills");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUserRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostUserRoutingskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarHeaders,
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of UserRoutingSkill</returns>
        public async System.Threading.Tasks.Task<UserRoutingSkill> PostUserRoutingskillsAsync (string userId, UserRoutingSkillPost body)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = await PostUserRoutingskillsAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PostUserRoutingskillsAsyncWithHttpInfo (string userId, UserRoutingSkillPost body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PostUserRoutingskills");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUserRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostUserRoutingskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarHeaders,
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Create user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>User</returns>
        public User PostUsers (CreateUser body)
        {
             ApiResponse<User> localVarResponse = PostUsersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > PostUsersWithHttpInfo (CreateUser body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUsers");

            var localVarPath = "/api/v2/users";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Create user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> PostUsersAsync (CreateUser body)
        {
             ApiResponse<User> localVarResponse = await PostUsersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> PostUsersAsyncWithHttpInfo (CreateUser body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUsers");

            var localVarPath = "/api/v2/users";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarHeaders,
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>UsersSearchResponse</returns>
        public UsersSearchResponse PostUsersSearch (UserSearchRequest body)
        {
             ApiResponse<UsersSearchResponse> localVarResponse = PostUsersSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of UsersSearchResponse</returns>
        public ApiResponse< UsersSearchResponse > PostUsersSearchWithHttpInfo (UserSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUsersSearch");

            var localVarPath = "/api/v2/users/search";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)));
            
        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of UsersSearchResponse</returns>
        public async System.Threading.Tasks.Task<UsersSearchResponse> PostUsersSearchAsync (UserSearchRequest body)
        {
             ApiResponse<UsersSearchResponse> localVarResponse = await PostUsersSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (UsersSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsersSearchResponse>> PostUsersSearchAsyncWithHttpInfo (UserSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PostUsersSearch");

            var localVarPath = "/api/v2/users/search";
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
                throw new ApiException (localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (UsersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersSearchResponse)));
            
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding PutUserCallforwarding (string userId, CallForwarding body)
        {
             ApiResponse<CallForwarding> localVarResponse = PutUserCallforwardingWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > PutUserCallforwardingWithHttpInfo (string userId, CallForwarding body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserCallforwarding");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> PutUserCallforwardingAsync (string userId, CallForwarding body)
        {
             ApiResponse<CallForwarding> localVarResponse = await PutUserCallforwardingAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Call forwarding</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PutUserCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserCallforwarding");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserCallforwarding");

            var localVarPath = "/api/v2/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserCallforwarding: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserCallforwarding: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarHeaders,
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>OutOfOffice</returns>
        public OutOfOffice PutUserOutofoffice (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> localVarResponse = PutUserOutofofficeWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > PutUserOutofofficeWithHttpInfo (string userId, OutOfOffice body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserOutofoffice");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserOutofoffice");

            var localVarPath = "/api/v2/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserOutofoffice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserOutofoffice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarHeaders,
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> PutUserOutofofficeAsync (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> localVarResponse = await PutUserOutofofficeAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> PutUserOutofofficeAsyncWithHttpInfo (string userId, OutOfOffice body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserOutofoffice");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserOutofoffice");

            var localVarPath = "/api/v2/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserOutofoffice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserOutofoffice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarHeaders,
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Update profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> PutUserProfileskills (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = PutUserProfileskillsWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > PutUserProfileskillsWithHttpInfo (string userId, List<string> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserProfileskills");

            var localVarPath = "/api/v2/users/{userId}/profileskills";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserProfileskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserProfileskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Update profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> PutUserProfileskillsAsync (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = await PutUserProfileskillsAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update profile skills for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skills (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> PutUserProfileskillsAsyncWithHttpInfo (string userId, List<string> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserProfileskills");

            var localVarPath = "/api/v2/users/{userId}/profileskills";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserProfileskills: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserProfileskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarHeaders,
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoles");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoles");

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
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoles");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoles");

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

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>UserRoutingSkill</returns>
        public UserRoutingSkill PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = PutUserRoutingskillWithHttpInfo(userId, skillId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        public ApiResponse< UserRoutingSkill > PutUserRoutingskillWithHttpInfo (string userId, string skillId, UserRoutingSkill body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoutingskill");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling UsersApi->PutUserRoutingskill");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoutingskill");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingskill: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingskill: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarHeaders,
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of UserRoutingSkill</returns>
        public async System.Threading.Tasks.Task<UserRoutingSkill> PutUserRoutingskillAsync (string userId, string skillId, UserRoutingSkill body)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = await PutUserRoutingskillAsyncWithHttpInfo(userId, skillId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId">skillId</param>
        /// <param name="body">Skill</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PutUserRoutingskillAsyncWithHttpInfo (string userId, string skillId, UserRoutingSkill body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoutingskill");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling UsersApi->PutUserRoutingskill");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoutingskill");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingskill: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingskill: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarHeaders,
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>RoutingStatus</returns>
        public RoutingStatus PutUserRoutingstatus (string userId, RoutingStatus body)
        {
             ApiResponse<RoutingStatus> localVarResponse = PutUserRoutingstatusWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > PutUserRoutingstatusWithHttpInfo (string userId, RoutingStatus body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoutingstatus");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoutingstatus");

            var localVarPath = "/api/v2/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarHeaders,
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> PutUserRoutingstatusAsync (string userId, RoutingStatus body)
        {
             ApiResponse<RoutingStatus> localVarResponse = await PutUserRoutingstatusAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> PutUserRoutingstatusAsyncWithHttpInfo (string userId, RoutingStatus body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserRoutingstatus");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserRoutingstatus");

            var localVarPath = "/api/v2/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarHeaders,
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Set associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns></returns>
        public void PutUserStationAssociatedstationStationId (string userId, string stationId)
        {
             PutUserStationAssociatedstationStationIdWithHttpInfo(userId, stationId);
        }

        /// <summary>
        /// Set associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutUserStationAssociatedstationStationIdWithHttpInfo (string userId, string stationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserStationAssociatedstationStationId");
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling UsersApi->PutUserStationAssociatedstationStationId");

            var localVarPath = "/api/v2/users/{userId}/station/associatedstation/{stationId}";
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
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationAssociatedstationStationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationAssociatedstationStationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Set associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutUserStationAssociatedstationStationIdAsync (string userId, string stationId)
        {
             await PutUserStationAssociatedstationStationIdAsyncWithHttpInfo(userId, stationId);

        }

        /// <summary>
        /// Set associated station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutUserStationAssociatedstationStationIdAsyncWithHttpInfo (string userId, string stationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserStationAssociatedstationStationId");
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling UsersApi->PutUserStationAssociatedstationStationId");

            var localVarPath = "/api/v2/users/{userId}/station/associatedstation/{stationId}";
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
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationAssociatedstationStationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationAssociatedstationStationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Set default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns></returns>
        public void PutUserStationDefaultstationStationId (string userId, string stationId)
        {
             PutUserStationDefaultstationStationIdWithHttpInfo(userId, stationId);
        }

        /// <summary>
        /// Set default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutUserStationDefaultstationStationIdWithHttpInfo (string userId, string stationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserStationDefaultstationStationId");
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling UsersApi->PutUserStationDefaultstationStationId");

            var localVarPath = "/api/v2/users/{userId}/station/defaultstation/{stationId}";
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
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationDefaultstationStationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationDefaultstationStationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Set default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutUserStationDefaultstationStationIdAsync (string userId, string stationId)
        {
             await PutUserStationDefaultstationStationIdAsyncWithHttpInfo(userId, stationId);

        }

        /// <summary>
        /// Set default station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="stationId">stationId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutUserStationDefaultstationStationIdAsyncWithHttpInfo (string userId, string stationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserStationDefaultstationStationId");
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling UsersApi->PutUserStationDefaultstationStationId");

            var localVarPath = "/api/v2/users/{userId}/station/defaultstation/{stationId}";
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
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationDefaultstationStationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserStationDefaultstationStationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

    }
}
