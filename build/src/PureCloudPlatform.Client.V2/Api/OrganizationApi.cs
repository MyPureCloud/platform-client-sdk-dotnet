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
    public interface IOrganizationApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>FieldConfig</returns>
        [Obsolete]
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
        [Obsolete]
        ApiResponse<FieldConfig> GetFieldconfigWithHttpInfo (string type);

        /// <summary>
        /// Gets the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgAuthSettings</returns>
        
        OrgAuthSettings GetOrganizationsAuthenticationSettings ();

        /// <summary>
        /// Gets the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgAuthSettings</returns>
        
        ApiResponse<OrgAuthSettings> GetOrganizationsAuthenticationSettingsWithHttpInfo ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmbeddedIntegration</returns>
        [Obsolete]
        EmbeddedIntegration GetOrganizationsEmbeddedintegration ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        [Obsolete]
        ApiResponse<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationWithHttpInfo ();

        /// <summary>
        /// Get organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IpAddressAuthentication</returns>
        [Obsolete]
        IpAddressAuthentication GetOrganizationsIpaddressauthentication ();

        /// <summary>
        /// Get organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IpAddressAuthentication</returns>
        [Obsolete]
        ApiResponse<IpAddressAuthentication> GetOrganizationsIpaddressauthenticationWithHttpInfo ();

        /// <summary>
        /// Get a limit change request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>LimitChangeRequestDetails</returns>
        
        LimitChangeRequestDetails GetOrganizationsLimitsChangerequest (string requestId);

        /// <summary>
        /// Get a limit change request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>ApiResponse of LimitChangeRequestDetails</returns>
        
        ApiResponse<LimitChangeRequestDetails> GetOrganizationsLimitsChangerequestWithHttpInfo (string requestId);

        /// <summary>
        /// Get the available limit change requests
        /// </summary>
        /// <remarks>
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>LimitChangeRequestsEntityListing</returns>
        
        LimitChangeRequestsEntityListing GetOrganizationsLimitsChangerequests (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get the available limit change requests
        /// </summary>
        /// <remarks>
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of LimitChangeRequestsEntityListing</returns>
        
        ApiResponse<LimitChangeRequestsEntityListing> GetOrganizationsLimitsChangerequestsWithHttpInfo (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LimitDocumentation</returns>
        
        LimitDocumentation GetOrganizationsLimitsDocs ();

        /// <summary>
        /// Get limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LimitDocumentation</returns>
        
        ApiResponse<LimitDocumentation> GetOrganizationsLimitsDocsWithHttpInfo ();

        /// <summary>
        /// Get free trial limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FreeTrialLimitDocs</returns>
        
        FreeTrialLimitDocs GetOrganizationsLimitsDocsFreetrial ();

        /// <summary>
        /// Get free trial limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FreeTrialLimitDocs</returns>
        
        ApiResponse<FreeTrialLimitDocs> GetOrganizationsLimitsDocsFreetrialWithHttpInfo ();

        /// <summary>
        /// Get the effective limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>LimitsEntityListing</returns>
        
        LimitsEntityListing GetOrganizationsLimitsNamespace (string namespaceName);

        /// <summary>
        /// Get the effective limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>ApiResponse of LimitsEntityListing</returns>
        
        ApiResponse<LimitsEntityListing> GetOrganizationsLimitsNamespaceWithHttpInfo (string namespaceName);

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>LimitCountListing</returns>
        
        LimitCountListing GetOrganizationsLimitsNamespaceCounts (string namespaceName, string cursor = null, string entityId = null, string userId = null);

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>ApiResponse of LimitCountListing</returns>
        
        ApiResponse<LimitCountListing> GetOrganizationsLimitsNamespaceCountsWithHttpInfo (string namespaceName, string cursor = null, string entityId = null, string userId = null);

        /// <summary>
        /// Get the default limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>LimitsEntityListing</returns>
        
        LimitsEntityListing GetOrganizationsLimitsNamespaceDefaults (string namespaceName);

        /// <summary>
        /// Get the default limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>ApiResponse of LimitsEntityListing</returns>
        
        ApiResponse<LimitsEntityListing> GetOrganizationsLimitsNamespaceDefaultsWithHttpInfo (string namespaceName);

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>LimitCountListing</returns>
        
        LimitCountListing GetOrganizationsLimitsNamespaceLimitCounts (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null);

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>ApiResponse of LimitCountListing</returns>
        
        ApiResponse<LimitCountListing> GetOrganizationsLimitsNamespaceLimitCountsWithHttpInfo (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null);

        /// <summary>
        /// Get the available limit namespaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Object</returns>
        
        Object GetOrganizationsLimitsNamespaces (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the available limit namespaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> GetOrganizationsLimitsNamespacesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        
        Organization GetOrganizationsMe ();

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        
        ApiResponse<Organization> GetOrganizationsMeWithHttpInfo ();

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgWhitelistSettings</returns>
        [Obsolete]
        OrgWhitelistSettings GetOrganizationsWhitelist ();

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
        [Obsolete]
        ApiResponse<OrgWhitelistSettings> GetOrganizationsWhitelistWithHttpInfo ();

        /// <summary>
        /// Update the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>OrgAuthSettings</returns>
        
        OrgAuthSettings PatchOrganizationsAuthenticationSettings (OrgAuthSettings body);

        /// <summary>
        /// Update the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>ApiResponse of OrgAuthSettings</returns>
        
        ApiResponse<OrgAuthSettings> PatchOrganizationsAuthenticationSettingsWithHttpInfo (OrgAuthSettings body);

        /// <summary>
        /// Update organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>OrganizationFeatures</returns>
        
        OrganizationFeatures PatchOrganizationsFeature (string featureName, FeatureState enabled);

        /// <summary>
        /// Update organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>ApiResponse of OrganizationFeatures</returns>
        
        ApiResponse<OrganizationFeatures> PatchOrganizationsFeatureWithHttpInfo (string featureName, FeatureState enabled);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>EmbeddedIntegration</returns>
        [Obsolete]
        EmbeddedIntegration PutOrganizationsEmbeddedintegration (EmbeddedIntegration body);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        [Obsolete]
        ApiResponse<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationWithHttpInfo (EmbeddedIntegration body);

        /// <summary>
        /// Update organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>IpAddressAuthentication</returns>
        [Obsolete]
        IpAddressAuthentication PutOrganizationsIpaddressauthentication (IpAddressAuthentication body);

        /// <summary>
        /// Update organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>ApiResponse of IpAddressAuthentication</returns>
        [Obsolete]
        ApiResponse<IpAddressAuthentication> PutOrganizationsIpaddressauthenticationWithHttpInfo (IpAddressAuthentication body);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        
        Organization PutOrganizationsMe (Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        
        ApiResponse<Organization> PutOrganizationsMeWithHttpInfo (Organization body = null);

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>OrgWhitelistSettings</returns>
        [Obsolete]
        OrgWhitelistSettings PutOrganizationsWhitelist (OrgWhitelistSettings body);

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
        [Obsolete]
        ApiResponse<OrgWhitelistSettings> PutOrganizationsWhitelistWithHttpInfo (OrgWhitelistSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Fetch field config for an entity type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of FieldConfig</returns>
        [Obsolete]
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
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<FieldConfig>> GetFieldconfigAsyncWithHttpInfo (string type);

        /// <summary>
        /// Gets the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgAuthSettings</returns>
        
        System.Threading.Tasks.Task<OrgAuthSettings> GetOrganizationsAuthenticationSettingsAsync ();

        /// <summary>
        /// Gets the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgAuthSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrgAuthSettings>> GetOrganizationsAuthenticationSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmbeddedIntegration</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationAsync ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> GetOrganizationsEmbeddedintegrationAsyncWithHttpInfo ();

        /// <summary>
        /// Get organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IpAddressAuthentication</returns>
        [Obsolete]
        System.Threading.Tasks.Task<IpAddressAuthentication> GetOrganizationsIpaddressauthenticationAsync ();

        /// <summary>
        /// Get organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IpAddressAuthentication)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<IpAddressAuthentication>> GetOrganizationsIpaddressauthenticationAsyncWithHttpInfo ();

        /// <summary>
        /// Get a limit change request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>Task of LimitChangeRequestDetails</returns>
        
        System.Threading.Tasks.Task<LimitChangeRequestDetails> GetOrganizationsLimitsChangerequestAsync (string requestId);

        /// <summary>
        /// Get a limit change request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>Task of ApiResponse (LimitChangeRequestDetails)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitChangeRequestDetails>> GetOrganizationsLimitsChangerequestAsyncWithHttpInfo (string requestId);

        /// <summary>
        /// Get the available limit change requests
        /// </summary>
        /// <remarks>
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of LimitChangeRequestsEntityListing</returns>
        
        System.Threading.Tasks.Task<LimitChangeRequestsEntityListing> GetOrganizationsLimitsChangerequestsAsync (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get the available limit change requests
        /// </summary>
        /// <remarks>
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (LimitChangeRequestsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitChangeRequestsEntityListing>> GetOrganizationsLimitsChangerequestsAsyncWithHttpInfo (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LimitDocumentation</returns>
        
        System.Threading.Tasks.Task<LimitDocumentation> GetOrganizationsLimitsDocsAsync ();

        /// <summary>
        /// Get limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LimitDocumentation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitDocumentation>> GetOrganizationsLimitsDocsAsyncWithHttpInfo ();

        /// <summary>
        /// Get free trial limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FreeTrialLimitDocs</returns>
        
        System.Threading.Tasks.Task<FreeTrialLimitDocs> GetOrganizationsLimitsDocsFreetrialAsync ();

        /// <summary>
        /// Get free trial limit documentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FreeTrialLimitDocs)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<FreeTrialLimitDocs>> GetOrganizationsLimitsDocsFreetrialAsyncWithHttpInfo ();

        /// <summary>
        /// Get the effective limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>Task of LimitsEntityListing</returns>
        
        System.Threading.Tasks.Task<LimitsEntityListing> GetOrganizationsLimitsNamespaceAsync (string namespaceName);

        /// <summary>
        /// Get the effective limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>Task of ApiResponse (LimitsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitsEntityListing>> GetOrganizationsLimitsNamespaceAsyncWithHttpInfo (string namespaceName);

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>Task of LimitCountListing</returns>
        
        System.Threading.Tasks.Task<LimitCountListing> GetOrganizationsLimitsNamespaceCountsAsync (string namespaceName, string cursor = null, string entityId = null, string userId = null);

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>Task of ApiResponse (LimitCountListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitCountListing>> GetOrganizationsLimitsNamespaceCountsAsyncWithHttpInfo (string namespaceName, string cursor = null, string entityId = null, string userId = null);

        /// <summary>
        /// Get the default limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>Task of LimitsEntityListing</returns>
        
        System.Threading.Tasks.Task<LimitsEntityListing> GetOrganizationsLimitsNamespaceDefaultsAsync (string namespaceName);

        /// <summary>
        /// Get the default limits in a namespace for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>Task of ApiResponse (LimitsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitsEntityListing>> GetOrganizationsLimitsNamespaceDefaultsAsyncWithHttpInfo (string namespaceName);

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>Task of LimitCountListing</returns>
        
        System.Threading.Tasks.Task<LimitCountListing> GetOrganizationsLimitsNamespaceLimitCountsAsync (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null);

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking.
        /// </summary>
        /// <remarks>
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>Task of ApiResponse (LimitCountListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<LimitCountListing>> GetOrganizationsLimitsNamespaceLimitCountsAsyncWithHttpInfo (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null);

        /// <summary>
        /// Get the available limit namespaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> GetOrganizationsLimitsNamespacesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the available limit namespaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> GetOrganizationsLimitsNamespacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        
        System.Threading.Tasks.Task<Organization> GetOrganizationsMeAsync ();

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsMeAsyncWithHttpInfo ();

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgWhitelistSettings</returns>
        [Obsolete]
        System.Threading.Tasks.Task<OrgWhitelistSettings> GetOrganizationsWhitelistAsync ();

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<OrgWhitelistSettings>> GetOrganizationsWhitelistAsyncWithHttpInfo ();

        /// <summary>
        /// Update the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>Task of OrgAuthSettings</returns>
        
        System.Threading.Tasks.Task<OrgAuthSettings> PatchOrganizationsAuthenticationSettingsAsync (OrgAuthSettings body);

        /// <summary>
        /// Update the organization's settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>Task of ApiResponse (OrgAuthSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrgAuthSettings>> PatchOrganizationsAuthenticationSettingsAsyncWithHttpInfo (OrgAuthSettings body);

        /// <summary>
        /// Update organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>Task of OrganizationFeatures</returns>
        
        System.Threading.Tasks.Task<OrganizationFeatures> PatchOrganizationsFeatureAsync (string featureName, FeatureState enabled);

        /// <summary>
        /// Update organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>Task of ApiResponse (OrganizationFeatures)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<OrganizationFeatures>> PatchOrganizationsFeatureAsyncWithHttpInfo (string featureName, FeatureState enabled);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of EmbeddedIntegration</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationAsync (EmbeddedIntegration body);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> PutOrganizationsEmbeddedintegrationAsyncWithHttpInfo (EmbeddedIntegration body);

        /// <summary>
        /// Update organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>Task of IpAddressAuthentication</returns>
        [Obsolete]
        System.Threading.Tasks.Task<IpAddressAuthentication> PutOrganizationsIpaddressauthenticationAsync (IpAddressAuthentication body);

        /// <summary>
        /// Update organization IP address whitelist settings
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>Task of ApiResponse (IpAddressAuthentication)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<IpAddressAuthentication>> PutOrganizationsIpaddressauthenticationAsyncWithHttpInfo (IpAddressAuthentication body);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        
        System.Threading.Tasks.Task<Organization> PutOrganizationsMeAsync (Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsMeAsyncWithHttpInfo (Organization body = null);

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of OrgWhitelistSettings</returns>
        [Obsolete]
        System.Threading.Tasks.Task<OrgWhitelistSettings> PutOrganizationsWhitelistAsync (OrgWhitelistSettings body);

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<OrgWhitelistSettings>> PutOrganizationsWhitelistAsyncWithHttpInfo (OrgWhitelistSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganizationApi : IOrganizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrganizationApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Fetch field config for an entity type 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>FieldConfig</returns>
        [Obsolete]
        public FieldConfig GetFieldconfig (string type)
        {
             ApiResponse<FieldConfig> localVarResponse = GetFieldconfigWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>ApiResponse of FieldConfig</returns>
        [Obsolete]
        public ApiResponse< FieldConfig > GetFieldconfigWithHttpInfo (string type)
        { 
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling OrganizationApi->GetFieldconfig");

            var localVarPath = "/api/v2/fieldconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FieldConfig>(localVarStatusCode,
                localVarHeaders,
                (FieldConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch field config for an entity type 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of FieldConfig</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<FieldConfig> GetFieldconfigAsync (string type)
        {
             ApiResponse<FieldConfig> localVarResponse = await GetFieldconfigAsyncWithHttpInfo(type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch field config for an entity type 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Field type</param>
        /// <returns>Task of ApiResponse (FieldConfig)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<FieldConfig>> GetFieldconfigAsyncWithHttpInfo (string type)
        { 
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling OrganizationApi->GetFieldconfig");
            

            var localVarPath = "/api/v2/fieldconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FieldConfig>(localVarStatusCode,
                localVarHeaders,
                (FieldConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgAuthSettings</returns>
        
        public OrgAuthSettings GetOrganizationsAuthenticationSettings ()
        {
             ApiResponse<OrgAuthSettings> localVarResponse = GetOrganizationsAuthenticationSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgAuthSettings</returns>
        
        public ApiResponse< OrgAuthSettings > GetOrganizationsAuthenticationSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/authentication/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsAuthenticationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsAuthenticationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgAuthSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgAuthSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgAuthSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgAuthSettings</returns>
        
        public async System.Threading.Tasks.Task<OrgAuthSettings> GetOrganizationsAuthenticationSettingsAsync ()
        {
             ApiResponse<OrgAuthSettings> localVarResponse = await GetOrganizationsAuthenticationSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgAuthSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrgAuthSettings>> GetOrganizationsAuthenticationSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/authentication/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsAuthenticationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsAuthenticationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgAuthSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgAuthSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgAuthSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmbeddedIntegration</returns>
        [Obsolete]
        public EmbeddedIntegration GetOrganizationsEmbeddedintegration ()
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = GetOrganizationsEmbeddedintegrationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        [Obsolete]
        public ApiResponse< EmbeddedIntegration > GetOrganizationsEmbeddedintegrationWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/embeddedintegration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsEmbeddedintegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsEmbeddedintegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmbeddedIntegration>(localVarStatusCode,
                localVarHeaders,
                (EmbeddedIntegration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbeddedIntegration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmbeddedIntegration</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationAsync ()
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = await GetOrganizationsEmbeddedintegrationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> GetOrganizationsEmbeddedintegrationAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/embeddedintegration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsEmbeddedintegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsEmbeddedintegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmbeddedIntegration>(localVarStatusCode,
                localVarHeaders,
                (EmbeddedIntegration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbeddedIntegration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IpAddressAuthentication</returns>
        [Obsolete]
        public IpAddressAuthentication GetOrganizationsIpaddressauthentication ()
        {
             ApiResponse<IpAddressAuthentication> localVarResponse = GetOrganizationsIpaddressauthenticationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IpAddressAuthentication</returns>
        [Obsolete]
        public ApiResponse< IpAddressAuthentication > GetOrganizationsIpaddressauthenticationWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/ipaddressauthentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsIpaddressauthentication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsIpaddressauthentication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IpAddressAuthentication>(localVarStatusCode,
                localVarHeaders,
                (IpAddressAuthentication) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressAuthentication)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IpAddressAuthentication</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<IpAddressAuthentication> GetOrganizationsIpaddressauthenticationAsync ()
        {
             ApiResponse<IpAddressAuthentication> localVarResponse = await GetOrganizationsIpaddressauthenticationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IpAddressAuthentication)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<IpAddressAuthentication>> GetOrganizationsIpaddressauthenticationAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/ipaddressauthentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsIpaddressauthentication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsIpaddressauthentication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IpAddressAuthentication>(localVarStatusCode,
                localVarHeaders,
                (IpAddressAuthentication) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressAuthentication)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a limit change request 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>LimitChangeRequestDetails</returns>
        
        public LimitChangeRequestDetails GetOrganizationsLimitsChangerequest (string requestId)
        {
             ApiResponse<LimitChangeRequestDetails> localVarResponse = GetOrganizationsLimitsChangerequestWithHttpInfo(requestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a limit change request 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>ApiResponse of LimitChangeRequestDetails</returns>
        
        public ApiResponse< LimitChangeRequestDetails > GetOrganizationsLimitsChangerequestWithHttpInfo (string requestId)
        { 
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling OrganizationApi->GetOrganizationsLimitsChangerequest");

            var localVarPath = "/api/v2/organizations/limits/changerequests/{requestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (requestId != null) localVarPathParams.Add("requestId", this.Configuration.ApiClient.ParameterToString(requestId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitChangeRequestDetails>(localVarStatusCode,
                localVarHeaders,
                (LimitChangeRequestDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitChangeRequestDetails)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a limit change request 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>Task of LimitChangeRequestDetails</returns>
        
        public async System.Threading.Tasks.Task<LimitChangeRequestDetails> GetOrganizationsLimitsChangerequestAsync (string requestId)
        {
             ApiResponse<LimitChangeRequestDetails> localVarResponse = await GetOrganizationsLimitsChangerequestAsyncWithHttpInfo(requestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a limit change request 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Unique id for the limit change request</param>
        /// <returns>Task of ApiResponse (LimitChangeRequestDetails)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitChangeRequestDetails>> GetOrganizationsLimitsChangerequestAsyncWithHttpInfo (string requestId)
        { 
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling OrganizationApi->GetOrganizationsLimitsChangerequest");
            

            var localVarPath = "/api/v2/organizations/limits/changerequests/{requestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (requestId != null) localVarPathParams.Add("requestId", this.Configuration.ApiClient.ParameterToString(requestId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitChangeRequestDetails>(localVarStatusCode,
                localVarHeaders,
                (LimitChangeRequestDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitChangeRequestDetails)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the available limit change requests 
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>LimitChangeRequestsEntityListing</returns>
        
        public LimitChangeRequestsEntityListing GetOrganizationsLimitsChangerequests (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<LimitChangeRequestsEntityListing> localVarResponse = GetOrganizationsLimitsChangerequestsWithHttpInfo(after, before, status, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the available limit change requests 
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of LimitChangeRequestsEntityListing</returns>
        
        public ApiResponse< LimitChangeRequestsEntityListing > GetOrganizationsLimitsChangerequestsWithHttpInfo (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/organizations/limits/changerequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitChangeRequestsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitChangeRequestsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitChangeRequestsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the available limit change requests 
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of LimitChangeRequestsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<LimitChangeRequestsEntityListing> GetOrganizationsLimitsChangerequestsAsync (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<LimitChangeRequestsEntityListing> localVarResponse = await GetOrganizationsLimitsChangerequestsAsyncWithHttpInfo(after, before, status, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the available limit change requests 
        /// Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Timestamp indicating the date to begin after when searching for requests. (optional)</param>
        /// <param name="before">Timestamp indicating the date to end before when searching for requests. (optional)</param>
        /// <param name="status">Status of the request to be filtered by (optional)</param>
        /// <param name="pageSize">Page Size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (LimitChangeRequestsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitChangeRequestsEntityListing>> GetOrganizationsLimitsChangerequestsAsyncWithHttpInfo (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/organizations/limits/changerequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsChangerequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitChangeRequestsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitChangeRequestsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitChangeRequestsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LimitDocumentation</returns>
        
        public LimitDocumentation GetOrganizationsLimitsDocs ()
        {
             ApiResponse<LimitDocumentation> localVarResponse = GetOrganizationsLimitsDocsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LimitDocumentation</returns>
        
        public ApiResponse< LimitDocumentation > GetOrganizationsLimitsDocsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/limits/docs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitDocumentation>(localVarStatusCode,
                localVarHeaders,
                (LimitDocumentation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitDocumentation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LimitDocumentation</returns>
        
        public async System.Threading.Tasks.Task<LimitDocumentation> GetOrganizationsLimitsDocsAsync ()
        {
             ApiResponse<LimitDocumentation> localVarResponse = await GetOrganizationsLimitsDocsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LimitDocumentation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitDocumentation>> GetOrganizationsLimitsDocsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/limits/docs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitDocumentation>(localVarStatusCode,
                localVarHeaders,
                (LimitDocumentation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitDocumentation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get free trial limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FreeTrialLimitDocs</returns>
        
        public FreeTrialLimitDocs GetOrganizationsLimitsDocsFreetrial ()
        {
             ApiResponse<FreeTrialLimitDocs> localVarResponse = GetOrganizationsLimitsDocsFreetrialWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get free trial limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FreeTrialLimitDocs</returns>
        
        public ApiResponse< FreeTrialLimitDocs > GetOrganizationsLimitsDocsFreetrialWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/limits/docs/freetrial";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocsFreetrial: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocsFreetrial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FreeTrialLimitDocs>(localVarStatusCode,
                localVarHeaders,
                (FreeTrialLimitDocs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FreeTrialLimitDocs)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get free trial limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FreeTrialLimitDocs</returns>
        
        public async System.Threading.Tasks.Task<FreeTrialLimitDocs> GetOrganizationsLimitsDocsFreetrialAsync ()
        {
             ApiResponse<FreeTrialLimitDocs> localVarResponse = await GetOrganizationsLimitsDocsFreetrialAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get free trial limit documentation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FreeTrialLimitDocs)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<FreeTrialLimitDocs>> GetOrganizationsLimitsDocsFreetrialAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/limits/docs/freetrial";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocsFreetrial: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsDocsFreetrial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FreeTrialLimitDocs>(localVarStatusCode,
                localVarHeaders,
                (FreeTrialLimitDocs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FreeTrialLimitDocs)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the effective limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>LimitsEntityListing</returns>
        
        public LimitsEntityListing GetOrganizationsLimitsNamespace (string namespaceName)
        {
             ApiResponse<LimitsEntityListing> localVarResponse = GetOrganizationsLimitsNamespaceWithHttpInfo(namespaceName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the effective limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>ApiResponse of LimitsEntityListing</returns>
        
        public ApiResponse< LimitsEntityListing > GetOrganizationsLimitsNamespaceWithHttpInfo (string namespaceName)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespace");

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the effective limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>Task of LimitsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<LimitsEntityListing> GetOrganizationsLimitsNamespaceAsync (string namespaceName)
        {
             ApiResponse<LimitsEntityListing> localVarResponse = await GetOrganizationsLimitsNamespaceAsyncWithHttpInfo(namespaceName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the effective limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch limits for</param>
        /// <returns>Task of ApiResponse (LimitsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitsEntityListing>> GetOrganizationsLimitsNamespaceAsyncWithHttpInfo (string namespaceName)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespace");
            

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>LimitCountListing</returns>
        
        public LimitCountListing GetOrganizationsLimitsNamespaceCounts (string namespaceName, string cursor = null, string entityId = null, string userId = null)
        {
             ApiResponse<LimitCountListing> localVarResponse = GetOrganizationsLimitsNamespaceCountsWithHttpInfo(namespaceName, cursor, entityId, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>ApiResponse of LimitCountListing</returns>
        
        public ApiResponse< LimitCountListing > GetOrganizationsLimitsNamespaceCountsWithHttpInfo (string namespaceName, string cursor = null, string entityId = null, string userId = null)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceCounts");

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/counts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (entityId != null) localVarQueryParams.Add(new Tuple<string, string>("entityId", this.Configuration.ApiClient.ParameterToString(entityId)));
            if (userId != null) localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(userId)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceCounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceCounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitCountListing>(localVarStatusCode,
                localVarHeaders,
                (LimitCountListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitCountListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>Task of LimitCountListing</returns>
        
        public async System.Threading.Tasks.Task<LimitCountListing> GetOrganizationsLimitsNamespaceCountsAsync (string namespaceName, string cursor = null, string entityId = null, string userId = null)
        {
             ApiResponse<LimitCountListing> localVarResponse = await GetOrganizationsLimitsNamespaceCountsAsyncWithHttpInfo(namespaceName, cursor, entityId, userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get estimated limit counts for a namespace. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <returns>Task of ApiResponse (LimitCountListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitCountListing>> GetOrganizationsLimitsNamespaceCountsAsyncWithHttpInfo (string namespaceName, string cursor = null, string entityId = null, string userId = null)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceCounts");
            

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/counts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (entityId != null) localVarQueryParams.Add(new Tuple<string, string>("entityId", this.Configuration.ApiClient.ParameterToString(entityId)));
            if (userId != null) localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(userId)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceCounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceCounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitCountListing>(localVarStatusCode,
                localVarHeaders,
                (LimitCountListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitCountListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the default limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>LimitsEntityListing</returns>
        
        public LimitsEntityListing GetOrganizationsLimitsNamespaceDefaults (string namespaceName)
        {
             ApiResponse<LimitsEntityListing> localVarResponse = GetOrganizationsLimitsNamespaceDefaultsWithHttpInfo(namespaceName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the default limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>ApiResponse of LimitsEntityListing</returns>
        
        public ApiResponse< LimitsEntityListing > GetOrganizationsLimitsNamespaceDefaultsWithHttpInfo (string namespaceName)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceDefaults");

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/defaults";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceDefaults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the default limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>Task of LimitsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<LimitsEntityListing> GetOrganizationsLimitsNamespaceDefaultsAsync (string namespaceName)
        {
             ApiResponse<LimitsEntityListing> localVarResponse = await GetOrganizationsLimitsNamespaceDefaultsAsyncWithHttpInfo(namespaceName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the default limits in a namespace for an organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
        /// <returns>Task of ApiResponse (LimitsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitsEntityListing>> GetOrganizationsLimitsNamespaceDefaultsAsyncWithHttpInfo (string namespaceName)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceDefaults");
            

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/defaults";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceDefaults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LimitsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>LimitCountListing</returns>
        
        public LimitCountListing GetOrganizationsLimitsNamespaceLimitCounts (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null)
        {
             ApiResponse<LimitCountListing> localVarResponse = GetOrganizationsLimitsNamespaceLimitCountsWithHttpInfo(namespaceName, limitName, entityId, userId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>ApiResponse of LimitCountListing</returns>
        
        public ApiResponse< LimitCountListing > GetOrganizationsLimitsNamespaceLimitCountsWithHttpInfo (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceLimitCounts");
            // verify the required parameter 'limitName' is set
            if (limitName == null)
                throw new ApiException(400, "Missing required parameter 'limitName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceLimitCounts");

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/limits/{limitName}/counts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));
            if (limitName != null) localVarPathParams.Add("limitName", this.Configuration.ApiClient.ParameterToString(limitName));

            // Query params
            if (entityId != null) localVarQueryParams.Add(new Tuple<string, string>("entityId", this.Configuration.ApiClient.ParameterToString(entityId)));
            if (userId != null) localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(userId)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceLimitCounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceLimitCounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitCountListing>(localVarStatusCode,
                localVarHeaders,
                (LimitCountListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitCountListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>Task of LimitCountListing</returns>
        
        public async System.Threading.Tasks.Task<LimitCountListing> GetOrganizationsLimitsNamespaceLimitCountsAsync (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null)
        {
             ApiResponse<LimitCountListing> localVarResponse = await GetOrganizationsLimitsNamespaceLimitCountsAsyncWithHttpInfo(namespaceName, limitName, entityId, userId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get estimated limit counts for a namespace and limit name. This is not a source of truth for limit values but a record of estimates to facilitate limit threshold tracking. 
        /// See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceName">The namespace to get</param>
        /// <param name="limitName">The limit to get</param>
        /// <param name="entityId">entity id of the count (optional)</param>
        /// <param name="userId">userid of the count (optional)</param>
        /// <param name="cursor">Cursor provided when retrieving the last page (optional)</param>
        /// <returns>Task of ApiResponse (LimitCountListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<LimitCountListing>> GetOrganizationsLimitsNamespaceLimitCountsAsyncWithHttpInfo (string namespaceName, string limitName, string entityId = null, string userId = null, string cursor = null)
        { 
            // verify the required parameter 'namespaceName' is set
            if (namespaceName == null)
                throw new ApiException(400, "Missing required parameter 'namespaceName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceLimitCounts");
            
            // verify the required parameter 'limitName' is set
            if (limitName == null)
                throw new ApiException(400, "Missing required parameter 'limitName' when calling OrganizationApi->GetOrganizationsLimitsNamespaceLimitCounts");
            

            var localVarPath = "/api/v2/organizations/limits/namespaces/{namespaceName}/limits/{limitName}/counts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (namespaceName != null) localVarPathParams.Add("namespaceName", this.Configuration.ApiClient.ParameterToString(namespaceName));
            if (limitName != null) localVarPathParams.Add("limitName", this.Configuration.ApiClient.ParameterToString(limitName));

            // Query params
            if (entityId != null) localVarQueryParams.Add(new Tuple<string, string>("entityId", this.Configuration.ApiClient.ParameterToString(entityId)));
            if (userId != null) localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(userId)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceLimitCounts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaceLimitCounts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitCountListing>(localVarStatusCode,
                localVarHeaders,
                (LimitCountListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitCountListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the available limit namespaces 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Object</returns>
        
        public Object GetOrganizationsLimitsNamespaces (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<Object> localVarResponse = GetOrganizationsLimitsNamespacesWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the available limit namespaces 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > GetOrganizationsLimitsNamespacesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/organizations/limits/namespaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the available limit namespaces 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> GetOrganizationsLimitsNamespacesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<Object> localVarResponse = await GetOrganizationsLimitsNamespacesAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the available limit namespaces 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 100)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetOrganizationsLimitsNamespacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/organizations/limits/namespaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            // Header params

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsLimitsNamespaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        
        public Organization GetOrganizationsMe ()
        {
             ApiResponse<Organization> localVarResponse = GetOrganizationsMeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        
        public ApiResponse< Organization > GetOrganizationsMeWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarHeaders,
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        
        public async System.Threading.Tasks.Task<Organization> GetOrganizationsMeAsync ()
        {
             ApiResponse<Organization> localVarResponse = await GetOrganizationsMeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsMeAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarHeaders,
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgWhitelistSettings</returns>
        [Obsolete]
        public OrgWhitelistSettings GetOrganizationsWhitelist ()
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = GetOrganizationsWhitelistWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
        [Obsolete]
        public ApiResponse< OrgWhitelistSettings > GetOrganizationsWhitelistWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/whitelist";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsWhitelist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsWhitelist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgWhitelistSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgWhitelistSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgWhitelistSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgWhitelistSettings</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<OrgWhitelistSettings> GetOrganizationsWhitelistAsync ()
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = await GetOrganizationsWhitelistAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<OrgWhitelistSettings>> GetOrganizationsWhitelistAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/organizations/whitelist";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsWhitelist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsWhitelist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgWhitelistSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgWhitelistSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgWhitelistSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>OrgAuthSettings</returns>
        
        public OrgAuthSettings PatchOrganizationsAuthenticationSettings (OrgAuthSettings body)
        {
             ApiResponse<OrgAuthSettings> localVarResponse = PatchOrganizationsAuthenticationSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>ApiResponse of OrgAuthSettings</returns>
        
        public ApiResponse< OrgAuthSettings > PatchOrganizationsAuthenticationSettingsWithHttpInfo (OrgAuthSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PatchOrganizationsAuthenticationSettings");

            var localVarPath = "/api/v2/organizations/authentication/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsAuthenticationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsAuthenticationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgAuthSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgAuthSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgAuthSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>Task of OrgAuthSettings</returns>
        
        public async System.Threading.Tasks.Task<OrgAuthSettings> PatchOrganizationsAuthenticationSettingsAsync (OrgAuthSettings body)
        {
             ApiResponse<OrgAuthSettings> localVarResponse = await PatchOrganizationsAuthenticationSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the organization's settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Org settings</param>
        /// <returns>Task of ApiResponse (OrgAuthSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrgAuthSettings>> PatchOrganizationsAuthenticationSettingsAsyncWithHttpInfo (OrgAuthSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PatchOrganizationsAuthenticationSettings");
            

            var localVarPath = "/api/v2/organizations/authentication/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsAuthenticationSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsAuthenticationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgAuthSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgAuthSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgAuthSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>OrganizationFeatures</returns>
        
        public OrganizationFeatures PatchOrganizationsFeature (string featureName, FeatureState enabled)
        {
             ApiResponse<OrganizationFeatures> localVarResponse = PatchOrganizationsFeatureWithHttpInfo(featureName, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>ApiResponse of OrganizationFeatures</returns>
        
        public ApiResponse< OrganizationFeatures > PatchOrganizationsFeatureWithHttpInfo (string featureName, FeatureState enabled)
        { 
            // verify the required parameter 'featureName' is set
            if (featureName == null)
                throw new ApiException(400, "Missing required parameter 'featureName' when calling OrganizationApi->PatchOrganizationsFeature");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling OrganizationApi->PatchOrganizationsFeature");

            var localVarPath = "/api/v2/organizations/features/{featureName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (featureName != null) localVarPathParams.Add("featureName", this.Configuration.ApiClient.ParameterToString(featureName));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (enabled != null && enabled.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(enabled); // http body (model) parameter
            else
                localVarPostBody = enabled; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsFeature: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsFeature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationFeatures>(localVarStatusCode,
                localVarHeaders,
                (OrganizationFeatures) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationFeatures)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>Task of OrganizationFeatures</returns>
        
        public async System.Threading.Tasks.Task<OrganizationFeatures> PatchOrganizationsFeatureAsync (string featureName, FeatureState enabled)
        {
             ApiResponse<OrganizationFeatures> localVarResponse = await PatchOrganizationsFeatureAsyncWithHttpInfo(featureName, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureName">Organization feature</param>
        /// <param name="enabled">New state of feature</param>
        /// <returns>Task of ApiResponse (OrganizationFeatures)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationFeatures>> PatchOrganizationsFeatureAsyncWithHttpInfo (string featureName, FeatureState enabled)
        { 
            // verify the required parameter 'featureName' is set
            if (featureName == null)
                throw new ApiException(400, "Missing required parameter 'featureName' when calling OrganizationApi->PatchOrganizationsFeature");
            
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling OrganizationApi->PatchOrganizationsFeature");
            

            var localVarPath = "/api/v2/organizations/features/{featureName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (featureName != null) localVarPathParams.Add("featureName", this.Configuration.ApiClient.ParameterToString(featureName));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (enabled != null && enabled.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(enabled); // http body (model) parameter
            else
                localVarPostBody = enabled; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsFeature: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchOrganizationsFeature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationFeatures>(localVarStatusCode,
                localVarHeaders,
                (OrganizationFeatures) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationFeatures)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>EmbeddedIntegration</returns>
        [Obsolete]
        public EmbeddedIntegration PutOrganizationsEmbeddedintegration (EmbeddedIntegration body)
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = PutOrganizationsEmbeddedintegrationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        [Obsolete]
        public ApiResponse< EmbeddedIntegration > PutOrganizationsEmbeddedintegrationWithHttpInfo (EmbeddedIntegration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsEmbeddedintegration");

            var localVarPath = "/api/v2/organizations/embeddedintegration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsEmbeddedintegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsEmbeddedintegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmbeddedIntegration>(localVarStatusCode,
                localVarHeaders,
                (EmbeddedIntegration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbeddedIntegration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of EmbeddedIntegration</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationAsync (EmbeddedIntegration body)
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = await PutOrganizationsEmbeddedintegrationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> PutOrganizationsEmbeddedintegrationAsyncWithHttpInfo (EmbeddedIntegration body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsEmbeddedintegration");
            

            var localVarPath = "/api/v2/organizations/embeddedintegration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsEmbeddedintegration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsEmbeddedintegration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmbeddedIntegration>(localVarStatusCode,
                localVarHeaders,
                (EmbeddedIntegration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbeddedIntegration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>IpAddressAuthentication</returns>
        [Obsolete]
        public IpAddressAuthentication PutOrganizationsIpaddressauthentication (IpAddressAuthentication body)
        {
             ApiResponse<IpAddressAuthentication> localVarResponse = PutOrganizationsIpaddressauthenticationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>ApiResponse of IpAddressAuthentication</returns>
        [Obsolete]
        public ApiResponse< IpAddressAuthentication > PutOrganizationsIpaddressauthenticationWithHttpInfo (IpAddressAuthentication body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsIpaddressauthentication");

            var localVarPath = "/api/v2/organizations/ipaddressauthentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsIpaddressauthentication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsIpaddressauthentication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IpAddressAuthentication>(localVarStatusCode,
                localVarHeaders,
                (IpAddressAuthentication) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressAuthentication)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>Task of IpAddressAuthentication</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<IpAddressAuthentication> PutOrganizationsIpaddressauthenticationAsync (IpAddressAuthentication body)
        {
             ApiResponse<IpAddressAuthentication> localVarResponse = await PutOrganizationsIpaddressauthenticationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update organization IP address whitelist settings 
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">IP address Whitelist settings</param>
        /// <returns>Task of ApiResponse (IpAddressAuthentication)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<IpAddressAuthentication>> PutOrganizationsIpaddressauthenticationAsyncWithHttpInfo (IpAddressAuthentication body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsIpaddressauthentication");
            

            var localVarPath = "/api/v2/organizations/ipaddressauthentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsIpaddressauthentication: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsIpaddressauthentication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IpAddressAuthentication>(localVarStatusCode,
                localVarHeaders,
                (IpAddressAuthentication) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressAuthentication)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        
        public Organization PutOrganizationsMe (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = PutOrganizationsMeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        
        public ApiResponse< Organization > PutOrganizationsMeWithHttpInfo (Organization body = null)
        { 

            var localVarPath = "/api/v2/organizations/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarHeaders,
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        
        public async System.Threading.Tasks.Task<Organization> PutOrganizationsMeAsync (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = await PutOrganizationsMeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsMeAsyncWithHttpInfo (Organization body = null)
        { 

            var localVarPath = "/api/v2/organizations/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarHeaders,
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>OrgWhitelistSettings</returns>
        [Obsolete]
        public OrgWhitelistSettings PutOrganizationsWhitelist (OrgWhitelistSettings body)
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = PutOrganizationsWhitelistWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
        [Obsolete]
        public ApiResponse< OrgWhitelistSettings > PutOrganizationsWhitelistWithHttpInfo (OrgWhitelistSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsWhitelist");

            var localVarPath = "/api/v2/organizations/whitelist";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsWhitelist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsWhitelist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgWhitelistSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgWhitelistSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgWhitelistSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of OrgWhitelistSettings</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<OrgWhitelistSettings> PutOrganizationsWhitelistAsync (OrgWhitelistSettings body)
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = await PutOrganizationsWhitelistAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This route is deprecated, please use /api/v2/organizations/authentication/settings instead 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<OrgWhitelistSettings>> PutOrganizationsWhitelistAsyncWithHttpInfo (OrgWhitelistSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrganizationApi->PutOrganizationsWhitelist");
            

            var localVarPath = "/api/v2/organizations/whitelist";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsWhitelist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsWhitelist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgWhitelistSettings>(localVarStatusCode,
                localVarHeaders,
                (OrgWhitelistSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgWhitelistSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
