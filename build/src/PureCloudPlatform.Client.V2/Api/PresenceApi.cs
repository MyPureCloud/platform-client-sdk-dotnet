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
    public interface IPresenceApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns></returns>
        void DeletePresenceSource (string sourceId);

        /// <summary>
        /// Delete a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePresenceSourceWithHttpInfo (string sourceId);

        /// <summary>
        /// Delete a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns></returns>
        void DeletePresencedefinition (string presenceId);

        /// <summary>
        /// Delete a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePresencedefinitionWithHttpInfo (string presenceId);

        /// <summary>
        /// Get a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Source</returns>
        Source GetPresenceSource (string sourceId);

        /// <summary>
        /// Get a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>ApiResponse of Source</returns>
        ApiResponse<Source> GetPresenceSourceWithHttpInfo (string sourceId);

        /// <summary>
        /// Get a list of Presence Sources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>SourceEntityListing</returns>
        SourceEntityListing GetPresenceSources (string deactivated = null);

        /// <summary>
        /// Get a list of Presence Sources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>ApiResponse of SourceEntityListing</returns>
        ApiResponse<SourceEntityListing> GetPresenceSourcesWithHttpInfo (string deactivated = null);

        /// <summary>
        /// Get a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>UserPrimarySource</returns>
        UserPrimarySource GetPresenceUserPrimarysource (string userId);

        /// <summary>
        /// Get a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>ApiResponse of UserPrimarySource</returns>
        ApiResponse<UserPrimarySource> GetPresenceUserPrimarysourceWithHttpInfo (string userId);

        /// <summary>
        /// Get a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence GetPresencedefinition (string presenceId, string localeCode = null);

        /// <summary>
        /// Get a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> GetPresencedefinitionWithHttpInfo (string presenceId, string localeCode = null);

        /// <summary>
        /// Get an Organization's list of Presence Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null);

        /// <summary>
        /// Get an Organization's list of Presence Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null);

        /// <summary>
        /// Get the list of SystemPresences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SystemPresence&gt;</returns>
        List<SystemPresence> GetSystempresences ();

        /// <summary>
        /// Get the list of SystemPresences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SystemPresence&gt;</returns>
        ApiResponse<List<SystemPresence>> GetSystempresencesWithHttpInfo ();

        /// <summary>
        /// Get a user's Presence
        /// </summary>
        /// <remarks>
        /// Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserPresence (string userId, string sourceId);

        /// <summary>
        /// Get a user's Presence
        /// </summary>
        /// <remarks>
        /// Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserPresenceWithHttpInfo (string userId, string sourceId);

        /// <summary>
        /// Get a user's Genesys Cloud presence.
        /// </summary>
        /// <remarks>
        /// Get the default Genesys Cloud user presence source PURECLOUD
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserPresencesPurecloud (string userId);

        /// <summary>
        /// Get a user's Genesys Cloud presence.
        /// </summary>
        /// <remarks>
        /// Get the default Genesys Cloud user presence source PURECLOUD
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserPresencesPurecloudWithHttpInfo (string userId);

        /// <summary>
        /// Patch a user's Presence
        /// </summary>
        /// <remarks>
        /// Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>UserPresence</returns>
        UserPresence PatchUserPresence (string userId, string sourceId, UserPresence body);

        /// <summary>
        /// Patch a user's Presence
        /// </summary>
        /// <remarks>
        /// Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> PatchUserPresenceWithHttpInfo (string userId, string sourceId, UserPresence body);

        /// <summary>
        /// Patch a Genesys Cloud user's presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>UserPresence</returns>
        UserPresence PatchUserPresencesPurecloud (string userId, UserPresence body);

        /// <summary>
        /// Patch a Genesys Cloud user's presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> PatchUserPresencesPurecloudWithHttpInfo (string userId, UserPresence body);

        /// <summary>
        /// Create a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Source</returns>
        Source PostPresenceSources (Source body);

        /// <summary>
        /// Create a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>ApiResponse of Source</returns>
        ApiResponse<Source> PostPresenceSourcesWithHttpInfo (Source body);

        /// <summary>
        /// Create a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PostPresencedefinitions (OrganizationPresence body);

        /// <summary>
        /// Create a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PostPresencedefinitionsWithHttpInfo (OrganizationPresence body);

        /// <summary>
        /// Update a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Source</returns>
        Source PutPresenceSource (string sourceId, Source body);

        /// <summary>
        /// Update a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>ApiResponse of Source</returns>
        ApiResponse<Source> PutPresenceSourceWithHttpInfo (string sourceId, Source body);

        /// <summary>
        /// Update a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>UserPrimarySource</returns>
        UserPrimarySource PutPresenceUserPrimarysource (string userId, UserPrimarySource body);

        /// <summary>
        /// Update a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>ApiResponse of UserPrimarySource</returns>
        ApiResponse<UserPrimarySource> PutPresenceUserPrimarysourceWithHttpInfo (string userId, UserPrimarySource body);

        /// <summary>
        /// Update a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PutPresencedefinition (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PutPresencedefinitionWithHttpInfo (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update bulk user Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>List&lt;UserPresence&gt;</returns>
        List<UserPresence> PutUsersPresencesBulk (List<UserPresence> body);

        /// <summary>
        /// Update bulk user Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>ApiResponse of List&lt;UserPresence&gt;</returns>
        ApiResponse<List<UserPresence>> PutUsersPresencesBulkWithHttpInfo (List<UserPresence> body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePresenceSourceAsync (string sourceId);

        /// <summary>
        /// Delete a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePresenceSourceAsyncWithHttpInfo (string sourceId);

        /// <summary>
        /// Delete a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePresencedefinitionAsync (string presenceId);

        /// <summary>
        /// Delete a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePresencedefinitionAsyncWithHttpInfo (string presenceId);

        /// <summary>
        /// Get a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of Source</returns>
        System.Threading.Tasks.Task<Source> GetPresenceSourceAsync (string sourceId);

        /// <summary>
        /// Get a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        System.Threading.Tasks.Task<ApiResponse<Source>> GetPresenceSourceAsyncWithHttpInfo (string sourceId);

        /// <summary>
        /// Get a list of Presence Sources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>Task of SourceEntityListing</returns>
        System.Threading.Tasks.Task<SourceEntityListing> GetPresenceSourcesAsync (string deactivated = null);

        /// <summary>
        /// Get a list of Presence Sources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>Task of ApiResponse (SourceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SourceEntityListing>> GetPresenceSourcesAsyncWithHttpInfo (string deactivated = null);

        /// <summary>
        /// Get a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>Task of UserPrimarySource</returns>
        System.Threading.Tasks.Task<UserPrimarySource> GetPresenceUserPrimarysourceAsync (string userId);

        /// <summary>
        /// Get a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>Task of ApiResponse (UserPrimarySource)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPrimarySource>> GetPresenceUserPrimarysourceAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Get a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> GetPresencedefinitionAsync (string presenceId, string localeCode = null);

        /// <summary>
        /// Get a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresencedefinitionAsyncWithHttpInfo (string presenceId, string localeCode = null);

        /// <summary>
        /// Get an Organization's list of Presence Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null);

        /// <summary>
        /// Get an Organization's list of Presence Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null);

        /// <summary>
        /// Get the list of SystemPresences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SystemPresence&gt;</returns>
        System.Threading.Tasks.Task<List<SystemPresence>> GetSystempresencesAsync ();

        /// <summary>
        /// Get the list of SystemPresences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SystemPresence&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SystemPresence>>> GetSystempresencesAsyncWithHttpInfo ();

        /// <summary>
        /// Get a user's Presence
        /// </summary>
        /// <remarks>
        /// Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserPresenceAsync (string userId, string sourceId);

        /// <summary>
        /// Get a user's Presence
        /// </summary>
        /// <remarks>
        /// Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresenceAsyncWithHttpInfo (string userId, string sourceId);

        /// <summary>
        /// Get a user's Genesys Cloud presence.
        /// </summary>
        /// <remarks>
        /// Get the default Genesys Cloud user presence source PURECLOUD
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserPresencesPurecloudAsync (string userId);

        /// <summary>
        /// Get a user's Genesys Cloud presence.
        /// </summary>
        /// <remarks>
        /// Get the default Genesys Cloud user presence source PURECLOUD
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresencesPurecloudAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Patch a user's Presence
        /// </summary>
        /// <remarks>
        /// Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> PatchUserPresenceAsync (string userId, string sourceId, UserPresence body);

        /// <summary>
        /// Patch a user's Presence
        /// </summary>
        /// <remarks>
        /// Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresenceAsyncWithHttpInfo (string userId, string sourceId, UserPresence body);

        /// <summary>
        /// Patch a Genesys Cloud user's presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> PatchUserPresencesPurecloudAsync (string userId, UserPresence body);

        /// <summary>
        /// Patch a Genesys Cloud user's presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresencesPurecloudAsyncWithHttpInfo (string userId, UserPresence body);

        /// <summary>
        /// Create a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Task of Source</returns>
        System.Threading.Tasks.Task<Source> PostPresenceSourcesAsync (Source body);

        /// <summary>
        /// Create a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        System.Threading.Tasks.Task<ApiResponse<Source>> PostPresenceSourcesAsyncWithHttpInfo (Source body);

        /// <summary>
        /// Create a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body);

        /// <summary>
        /// Create a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body);

        /// <summary>
        /// Update a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Task of Source</returns>
        System.Threading.Tasks.Task<Source> PutPresenceSourceAsync (string sourceId, Source body);

        /// <summary>
        /// Update a Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        System.Threading.Tasks.Task<ApiResponse<Source>> PutPresenceSourceAsyncWithHttpInfo (string sourceId, Source body);

        /// <summary>
        /// Update a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>Task of UserPrimarySource</returns>
        System.Threading.Tasks.Task<UserPrimarySource> PutPresenceUserPrimarysourceAsync (string userId, UserPrimarySource body);

        /// <summary>
        /// Update a user's Primary Presence Source
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>Task of ApiResponse (UserPrimarySource)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPrimarySource>> PutPresenceUserPrimarysourceAsyncWithHttpInfo (string userId, UserPrimarySource body);

        /// <summary>
        /// Update a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PutPresencedefinitionAsync (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update a Presence Definition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresencedefinitionAsyncWithHttpInfo (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update bulk user Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>Task of List&lt;UserPresence&gt;</returns>
        System.Threading.Tasks.Task<List<UserPresence>> PutUsersPresencesBulkAsync (List<UserPresence> body);

        /// <summary>
        /// Update bulk user Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>Task of ApiResponse (List&lt;UserPresence&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserPresence>>> PutUsersPresencesBulkAsyncWithHttpInfo (List<UserPresence> body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PresenceApi : IPresenceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PresenceApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PresenceApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns></returns>
        public void DeletePresenceSource (string sourceId)
        {
             DeletePresenceSourceWithHttpInfo(sourceId);
        }

        /// <summary>
        /// Delete a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePresenceSourceWithHttpInfo (string sourceId)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->DeletePresenceSource");

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePresenceSourceAsync (string sourceId)
        {
             await DeletePresenceSourceAsyncWithHttpInfo(sourceId);

        }

        /// <summary>
        /// Delete a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePresenceSourceAsyncWithHttpInfo (string sourceId)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->DeletePresenceSource");
            

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns></returns>
        public void DeletePresencedefinition (string presenceId)
        {
             DeletePresencedefinitionWithHttpInfo(presenceId);
        }

        /// <summary>
        /// Delete a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePresencedefinitionWithHttpInfo (string presenceId)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->DeletePresencedefinition");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePresencedefinitionAsync (string presenceId)
        {
             await DeletePresencedefinitionAsyncWithHttpInfo(presenceId);

        }

        /// <summary>
        /// Delete a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePresencedefinitionAsyncWithHttpInfo (string presenceId)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->DeletePresencedefinition");
            

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Source</returns>
        public Source GetPresenceSource (string sourceId)
        {
             ApiResponse<Source> localVarResponse = GetPresenceSourceWithHttpInfo(sourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>ApiResponse of Source</returns>
        public ApiResponse< Source > GetPresenceSourceWithHttpInfo (string sourceId)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->GetPresenceSource");

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of Source</returns>
        public async System.Threading.Tasks.Task<Source> GetPresenceSourceAsync (string sourceId)
        {
             ApiResponse<Source> localVarResponse = await GetPresenceSourceAsyncWithHttpInfo(sourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Source>> GetPresenceSourceAsyncWithHttpInfo (string sourceId)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->GetPresenceSource");
            

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Presence Sources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>SourceEntityListing</returns>
        public SourceEntityListing GetPresenceSources (string deactivated = null)
        {
             ApiResponse<SourceEntityListing> localVarResponse = GetPresenceSourcesWithHttpInfo(deactivated);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Presence Sources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>ApiResponse of SourceEntityListing</returns>
        public ApiResponse< SourceEntityListing > GetPresenceSourcesWithHttpInfo (string deactivated = null)
        { 

            var localVarPath = "/api/v2/presence/sources";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (deactivated != null) localVarQueryParams.Add(new Tuple<string, string>("deactivated", this.Configuration.ApiClient.ParameterToString(deactivated)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SourceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SourceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SourceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Presence Sources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>Task of SourceEntityListing</returns>
        public async System.Threading.Tasks.Task<SourceEntityListing> GetPresenceSourcesAsync (string deactivated = null)
        {
             ApiResponse<SourceEntityListing> localVarResponse = await GetPresenceSourcesAsyncWithHttpInfo(deactivated);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Presence Sources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deactivated">Deactivated query can be TRUE or FALSE (optional, default to "false")</param>
        /// <returns>Task of ApiResponse (SourceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SourceEntityListing>> GetPresenceSourcesAsyncWithHttpInfo (string deactivated = null)
        { 

            var localVarPath = "/api/v2/presence/sources";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (deactivated != null) localVarQueryParams.Add(new Tuple<string, string>("deactivated", this.Configuration.ApiClient.ParameterToString(deactivated)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceSources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SourceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SourceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SourceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>UserPrimarySource</returns>
        public UserPrimarySource GetPresenceUserPrimarysource (string userId)
        {
             ApiResponse<UserPrimarySource> localVarResponse = GetPresenceUserPrimarysourceWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>ApiResponse of UserPrimarySource</returns>
        public ApiResponse< UserPrimarySource > GetPresenceUserPrimarysourceWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetPresenceUserPrimarysource");

            var localVarPath = "/api/v2/presence/users/{userId}/primarysource";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceUserPrimarysource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceUserPrimarysource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPrimarySource>(localVarStatusCode,
                localVarHeaders,
                (UserPrimarySource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPrimarySource)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>Task of UserPrimarySource</returns>
        public async System.Threading.Tasks.Task<UserPrimarySource> GetPresenceUserPrimarysourceAsync (string userId)
        {
             ApiResponse<UserPrimarySource> localVarResponse = await GetPresenceUserPrimarysourceAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <returns>Task of ApiResponse (UserPrimarySource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPrimarySource>> GetPresenceUserPrimarysourceAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetPresenceUserPrimarysource");
            

            var localVarPath = "/api/v2/presence/users/{userId}/primarysource";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceUserPrimarysource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceUserPrimarysource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPrimarySource>(localVarStatusCode,
                localVarHeaders,
                (UserPrimarySource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPrimarySource)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence GetPresencedefinition (string presenceId, string localeCode = null)
        {
             ApiResponse<OrganizationPresence> localVarResponse = GetPresencedefinitionWithHttpInfo(presenceId, localeCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > GetPresencedefinitionWithHttpInfo (string presenceId, string localeCode = null)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->GetPresencedefinition");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

            // Query params
            if (localeCode != null) localVarQueryParams.Add(new Tuple<string, string>("localeCode", this.Configuration.ApiClient.ParameterToString(localeCode)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> GetPresencedefinitionAsync (string presenceId, string localeCode = null)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await GetPresencedefinitionAsyncWithHttpInfo(presenceId, localeCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="localeCode">The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresencedefinitionAsyncWithHttpInfo (string presenceId, string localeCode = null)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->GetPresencedefinition");
            

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

            // Query params
            if (localeCode != null) localVarQueryParams.Add(new Tuple<string, string>("localeCode", this.Configuration.ApiClient.ParameterToString(localeCode)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an Organization's list of Presence Definitions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = GetPresencedefinitionsWithHttpInfo(pageNumber, pageSize, deleted, localeCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Organization's list of Presence Definitions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)
        { 

            var localVarPath = "/api/v2/presencedefinitions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", this.Configuration.ApiClient.ParameterToString(deleted)));
            if (localeCode != null) localVarQueryParams.Add(new Tuple<string, string>("localeCode", this.Configuration.ApiClient.ParameterToString(localeCode)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresenceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an Organization's list of Presence Definitions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = await GetPresencedefinitionsAsyncWithHttpInfo(pageNumber, pageSize, deleted, localeCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Organization's list of Presence Definitions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Deleted query can be TRUE, FALSE or ALL (optional, default to "false")</param>
        /// <param name="localeCode">The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)
        { 

            var localVarPath = "/api/v2/presencedefinitions";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", this.Configuration.ApiClient.ParameterToString(deleted)));
            if (localeCode != null) localVarQueryParams.Add(new Tuple<string, string>("localeCode", this.Configuration.ApiClient.ParameterToString(localeCode)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresenceEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of SystemPresences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SystemPresence&gt;</returns>
        public List<SystemPresence> GetSystempresences ()
        {
             ApiResponse<List<SystemPresence>> localVarResponse = GetSystempresencesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of SystemPresences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SystemPresence&gt;</returns>
        public ApiResponse< List<SystemPresence> > GetSystempresencesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/systempresences";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempresences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempresences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SystemPresence>>(localVarStatusCode,
                localVarHeaders,
                (List<SystemPresence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SystemPresence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of SystemPresences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SystemPresence&gt;</returns>
        public async System.Threading.Tasks.Task<List<SystemPresence>> GetSystempresencesAsync ()
        {
             ApiResponse<List<SystemPresence>> localVarResponse = await GetSystempresencesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of SystemPresences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SystemPresence&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SystemPresence>>> GetSystempresencesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/systempresences";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempresences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempresences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SystemPresence>>(localVarStatusCode,
                localVarHeaders,
                (List<SystemPresence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SystemPresence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a user's Presence Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>UserPresence</returns>
        public UserPresence GetUserPresence (string userId, string sourceId)
        {
             ApiResponse<UserPresence> localVarResponse = GetUserPresenceWithHttpInfo(userId, sourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user's Presence Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserPresenceWithHttpInfo (string userId, string sourceId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserPresence");
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->GetUserPresence");

            var localVarPath = "/api/v2/users/{userId}/presences/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a user's Presence Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> GetUserPresenceAsync (string userId, string sourceId)
        {
             ApiResponse<UserPresence> localVarResponse = await GetUserPresenceAsyncWithHttpInfo(userId, sourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user's Presence Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresenceAsyncWithHttpInfo (string userId, string sourceId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserPresence");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->GetUserPresence");
            

            var localVarPath = "/api/v2/users/{userId}/presences/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a user's Genesys Cloud presence. Get the default Genesys Cloud user presence source PURECLOUD
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>UserPresence</returns>
        public UserPresence GetUserPresencesPurecloud (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = GetUserPresencesPurecloudWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user's Genesys Cloud presence. Get the default Genesys Cloud user presence source PURECLOUD
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserPresencesPurecloudWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserPresencesPurecloud");

            var localVarPath = "/api/v2/users/{userId}/presences/purecloud";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresencesPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresencesPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a user's Genesys Cloud presence. Get the default Genesys Cloud user presence source PURECLOUD
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> GetUserPresencesPurecloudAsync (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = await GetUserPresencesPurecloudAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user's Genesys Cloud presence. Get the default Genesys Cloud user presence source PURECLOUD
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresencesPurecloudAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserPresencesPurecloud");
            

            var localVarPath = "/api/v2/users/{userId}/presences/purecloud";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresencesPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserPresencesPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch a user's Presence Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>UserPresence</returns>
        public UserPresence PatchUserPresence (string userId, string sourceId, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = PatchUserPresenceWithHttpInfo(userId, sourceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user's Presence Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > PatchUserPresenceWithHttpInfo (string userId, string sourceId, UserPresence body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserPresence");
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->PatchUserPresence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PatchUserPresence");

            var localVarPath = "/api/v2/users/{userId}/presences/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch a user's Presence Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> PatchUserPresenceAsync (string userId, string sourceId, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await PatchUserPresenceAsyncWithHttpInfo(userId, sourceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user's Presence Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="sourceId">Presence source ID</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresenceAsyncWithHttpInfo (string userId, string sourceId, UserPresence body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserPresence");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->PatchUserPresence");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PatchUserPresence");
            

            var localVarPath = "/api/v2/users/{userId}/presences/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch a Genesys Cloud user's presence The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>UserPresence</returns>
        public UserPresence PatchUserPresencesPurecloud (string userId, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = PatchUserPresencesPurecloudWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a Genesys Cloud user's presence The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > PatchUserPresencesPurecloudWithHttpInfo (string userId, UserPresence body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserPresencesPurecloud");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PatchUserPresencesPurecloud");

            var localVarPath = "/api/v2/users/{userId}/presences/purecloud";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresencesPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresencesPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch a Genesys Cloud user's presence The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> PatchUserPresencesPurecloudAsync (string userId, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await PatchUserPresencesPurecloudAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a Genesys Cloud user's presence The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="body">User presence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresencesPurecloudAsyncWithHttpInfo (string userId, UserPresence body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserPresencesPurecloud");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PatchUserPresencesPurecloud");
            

            var localVarPath = "/api/v2/users/{userId}/presences/purecloud";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresencesPurecloud: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserPresencesPurecloud: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarHeaders,
                (UserPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Source</returns>
        public Source PostPresenceSources (Source body)
        {
             ApiResponse<Source> localVarResponse = PostPresenceSourcesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>ApiResponse of Source</returns>
        public ApiResponse< Source > PostPresenceSourcesWithHttpInfo (Source body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresenceSources");

            var localVarPath = "/api/v2/presence/sources";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresenceSources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresenceSources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Task of Source</returns>
        public async System.Threading.Tasks.Task<Source> PostPresenceSourcesAsync (Source body)
        {
             ApiResponse<Source> localVarResponse = await PostPresenceSourcesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Source to create</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Source>> PostPresenceSourcesAsyncWithHttpInfo (Source body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresenceSources");
            

            var localVarPath = "/api/v2/presence/sources";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresenceSources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresenceSources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PostPresencedefinitions (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PostPresencedefinitionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PostPresencedefinitionsWithHttpInfo (OrganizationPresence body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresencedefinitions");

            var localVarPath = "/api/v2/presencedefinitions";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PostPresencedefinitionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Presence Definition to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresencedefinitions");
            

            var localVarPath = "/api/v2/presencedefinitions";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Source</returns>
        public Source PutPresenceSource (string sourceId, Source body)
        {
             ApiResponse<Source> localVarResponse = PutPresenceSourceWithHttpInfo(sourceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>ApiResponse of Source</returns>
        public ApiResponse< Source > PutPresenceSourceWithHttpInfo (string sourceId, Source body)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->PutPresenceSource");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceSource");

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Task of Source</returns>
        public async System.Threading.Tasks.Task<Source> PutPresenceSourceAsync (string sourceId, Source body)
        {
             ApiResponse<Source> localVarResponse = await PutPresenceSourceAsyncWithHttpInfo(sourceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceId">Presence Source ID</param>
        /// <param name="body">The updated Presence Source</param>
        /// <returns>Task of ApiResponse (Source)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Source>> PutPresenceSourceAsyncWithHttpInfo (string sourceId, Source body)
        { 
            // verify the required parameter 'sourceId' is set
            if (sourceId == null)
                throw new ApiException(400, "Missing required parameter 'sourceId' when calling PresenceApi->PutPresenceSource");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceSource");
            

            var localVarPath = "/api/v2/presence/sources/{sourceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sourceId != null) localVarPathParams.Add("sourceId", this.Configuration.ApiClient.ParameterToString(sourceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceSource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Source>(localVarStatusCode,
                localVarHeaders,
                (Source) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Source)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>UserPrimarySource</returns>
        public UserPrimarySource PutPresenceUserPrimarysource (string userId, UserPrimarySource body)
        {
             ApiResponse<UserPrimarySource> localVarResponse = PutPresenceUserPrimarysourceWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>ApiResponse of UserPrimarySource</returns>
        public ApiResponse< UserPrimarySource > PutPresenceUserPrimarysourceWithHttpInfo (string userId, UserPrimarySource body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PutPresenceUserPrimarysource");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceUserPrimarysource");

            var localVarPath = "/api/v2/presence/users/{userId}/primarysource";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceUserPrimarysource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceUserPrimarysource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPrimarySource>(localVarStatusCode,
                localVarHeaders,
                (UserPrimarySource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPrimarySource)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>Task of UserPrimarySource</returns>
        public async System.Threading.Tasks.Task<UserPrimarySource> PutPresenceUserPrimarysourceAsync (string userId, UserPrimarySource body)
        {
             ApiResponse<UserPrimarySource> localVarResponse = await PutPresenceUserPrimarysourceAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user's Primary Presence Source 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user ID</param>
        /// <param name="body">Primary Source</param>
        /// <returns>Task of ApiResponse (UserPrimarySource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPrimarySource>> PutPresenceUserPrimarysourceAsyncWithHttpInfo (string userId, UserPrimarySource body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PutPresenceUserPrimarysource");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceUserPrimarysource");
            

            var localVarPath = "/api/v2/presence/users/{userId}/primarysource";
            var localVarPathParams = new Dictionary<String, String>();
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceUserPrimarysource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceUserPrimarysource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPrimarySource>(localVarStatusCode,
                localVarHeaders,
                (UserPrimarySource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPrimarySource)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PutPresencedefinition (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PutPresencedefinitionWithHttpInfo(presenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PutPresencedefinitionWithHttpInfo (string presenceId, OrganizationPresence body)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PutPresencedefinition");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresencedefinition");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutPresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PutPresencedefinitionAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PutPresencedefinitionAsyncWithHttpInfo(presenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Presence Definition 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresencedefinitionAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        { 
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PutPresencedefinition");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresencedefinition");
            

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (presenceId != null) localVarPathParams.Add("presenceId", this.Configuration.ApiClient.ParameterToString(presenceId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutPresencedefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresencedefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarHeaders,
                (OrganizationPresence) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update bulk user Presences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>List&lt;UserPresence&gt;</returns>
        public List<UserPresence> PutUsersPresencesBulk (List<UserPresence> body)
        {
             ApiResponse<List<UserPresence>> localVarResponse = PutUsersPresencesBulkWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update bulk user Presences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>ApiResponse of List&lt;UserPresence&gt;</returns>
        public ApiResponse< List<UserPresence> > PutUsersPresencesBulkWithHttpInfo (List<UserPresence> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutUsersPresencesBulk");

            var localVarPath = "/api/v2/users/presences/bulk";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PutUsersPresencesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersPresencesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserPresence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserPresence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserPresence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update bulk user Presences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>Task of List&lt;UserPresence&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserPresence>> PutUsersPresencesBulkAsync (List<UserPresence> body)
        {
             ApiResponse<List<UserPresence>> localVarResponse = await PutUsersPresencesBulkAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update bulk user Presences 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of User presences</param>
        /// <returns>Task of ApiResponse (List&lt;UserPresence&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserPresence>>> PutUsersPresencesBulkAsyncWithHttpInfo (List<UserPresence> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutUsersPresencesBulk");
            

            var localVarPath = "/api/v2/users/presences/bulk";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PutUsersPresencesBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUsersPresencesBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserPresence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserPresence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserPresence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
