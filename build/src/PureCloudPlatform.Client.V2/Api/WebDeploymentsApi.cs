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
    public interface IWebDeploymentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete all versions of a configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns></returns>
        
        void DeleteWebdeploymentsConfiguration (string configurationId);

        /// <summary>
        /// Delete all versions of a configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteWebdeploymentsConfigurationWithHttpInfo (string configurationId);

        /// <summary>
        /// Delete a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns></returns>
        
        void DeleteWebdeploymentsDeployment (string deploymentId);

        /// <summary>
        /// Delete a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteWebdeploymentsDeploymentWithHttpInfo (string deploymentId);

        /// <summary>
        /// Deletes a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Object</returns>
        
        Object DeleteWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId);

        /// <summary>
        /// Deletes a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo (string deploymentId, string sessionId);

        /// <summary>
        /// Invalidate JWT
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns></returns>
        
        void DeleteWebdeploymentsTokenRevoke (string xJourneySessionId = null, string xJourneySessionType = null);

        /// <summary>
        /// Invalidate JWT
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteWebdeploymentsTokenRevokeWithHttpInfo (string xJourneySessionId = null, string xJourneySessionType = null);

        /// <summary>
        /// Get a configuration version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        WebDeploymentConfigurationVersion GetWebdeploymentsConfigurationVersion (string configurationId, string versionId);

        /// <summary>
        /// Get a configuration version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        ApiResponse<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionWithHttpInfo (string configurationId, string versionId);

        /// <summary>
        /// Get the versions of a configuration
        /// </summary>
        /// <remarks>
        /// This returns the 50 most recent versions for this configuration
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        
        WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurationVersions (string configurationId);

        /// <summary>
        /// Get the versions of a configuration
        /// </summary>
        /// <remarks>
        /// This returns the 50 most recent versions for this configuration
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersionEntityListing</returns>
        
        ApiResponse<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsWithHttpInfo (string configurationId);

        /// <summary>
        /// Get the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        WebDeploymentConfigurationVersion GetWebdeploymentsConfigurationVersionsDraft (string configurationId);

        /// <summary>
        /// Get the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        ApiResponse<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftWithHttpInfo (string configurationId);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        
        WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurations (bool? showOnlyPublished = null);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersionEntityListing</returns>
        
        ApiResponse<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsWithHttpInfo (bool? showOnlyPublished = null);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>WebDeployment</returns>
        
        WebDeployment GetWebdeploymentsDeployment (string deploymentId, List<string> expand = null);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        ApiResponse<WebDeployment> GetWebdeploymentsDeploymentWithHttpInfo (string deploymentId, List<string> expand = null);

        /// <summary>
        /// Retrieves a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>CobrowseWebMessagingSession</returns>
        
        CobrowseWebMessagingSession GetWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId);

        /// <summary>
        /// Retrieves a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>ApiResponse of CobrowseWebMessagingSession</returns>
        
        ApiResponse<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo (string deploymentId, string sessionId);

        /// <summary>
        /// Get active configuration for a given deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>WebDeploymentActiveConfigurationOnDeployment</returns>
        
        WebDeploymentActiveConfigurationOnDeployment GetWebdeploymentsDeploymentConfigurations (string deploymentId, string type = null, List<string> expand = null);

        /// <summary>
        /// Get active configuration for a given deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>ApiResponse of WebDeploymentActiveConfigurationOnDeployment</returns>
        
        ApiResponse<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsWithHttpInfo (string deploymentId, string type = null, List<string> expand = null);

        /// <summary>
        /// Get a deployment identity resolution setting.
        /// </summary>
        /// <remarks>
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>IdentityResolutionConfig</returns>
        
        IdentityResolutionConfig GetWebdeploymentsDeploymentIdentityresolution (string deploymentId);

        /// <summary>
        /// Get a deployment identity resolution setting.
        /// </summary>
        /// <remarks>
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of IdentityResolutionConfig</returns>
        
        ApiResponse<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionWithHttpInfo (string deploymentId);

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ExpandableWebDeploymentEntityListing</returns>
        
        ExpandableWebDeploymentEntityListing GetWebdeploymentsDeployments (List<string> expand = null);

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ApiResponse of ExpandableWebDeploymentEntityListing</returns>
        
        ApiResponse<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Publish the configuration draft and create a new version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        WebDeploymentConfigurationVersion PostWebdeploymentsConfigurationVersionsDraftPublish (string configurationId);

        /// <summary>
        /// Publish the configuration draft and create a new version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        ApiResponse<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationVersionsDraftPublishWithHttpInfo (string configurationId);

        /// <summary>
        /// Create a configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        WebDeploymentConfigurationVersion PostWebdeploymentsConfigurations (WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Create a configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        ApiResponse<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationsWithHttpInfo (WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>WebDeployment</returns>
        
        WebDeployment PostWebdeploymentsDeployments (WebDeployment deployment);

        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        ApiResponse<WebDeployment> PostWebdeploymentsDeploymentsWithHttpInfo (WebDeployment deployment);

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>WebDeploymentsAuthorizationResponse</returns>
        
        WebDeploymentsAuthorizationResponse PostWebdeploymentsTokenOauthcodegrantjwtexchange (WebDeploymentsOAuthExchangeRequest body);

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>ApiResponse of WebDeploymentsAuthorizationResponse</returns>
        
        ApiResponse<WebDeploymentsAuthorizationResponse> PostWebdeploymentsTokenOauthcodegrantjwtexchangeWithHttpInfo (WebDeploymentsOAuthExchangeRequest body);

        /// <summary>
        /// Refresh a JWT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SignedData</returns>
        
        SignedData PostWebdeploymentsTokenRefresh (WebDeploymentsRefreshJWTRequest body = null);

        /// <summary>
        /// Refresh a JWT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SignedData</returns>
        
        ApiResponse<SignedData> PostWebdeploymentsTokenRefreshWithHttpInfo (WebDeploymentsRefreshJWTRequest body = null);

        /// <summary>
        /// Update the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        WebDeploymentConfigurationVersion PutWebdeploymentsConfigurationVersionsDraft (string configurationId, WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Update the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        ApiResponse<WebDeploymentConfigurationVersion> PutWebdeploymentsConfigurationVersionsDraftWithHttpInfo (string configurationId, WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Update a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>WebDeployment</returns>
        
        WebDeployment PutWebdeploymentsDeployment (string deploymentId, WebDeployment deployment);

        /// <summary>
        /// Update a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        ApiResponse<WebDeployment> PutWebdeploymentsDeploymentWithHttpInfo (string deploymentId, WebDeployment deployment);

        /// <summary>
        /// Update identity resolution settings for a deployment.
        /// </summary>
        /// <remarks>
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>IdentityResolutionConfig</returns>
        
        IdentityResolutionConfig PutWebdeploymentsDeploymentIdentityresolution (string deploymentId, IdentityResolutionConfig body);

        /// <summary>
        /// Update identity resolution settings for a deployment.
        /// </summary>
        /// <remarks>
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IdentityResolutionConfig</returns>
        
        ApiResponse<IdentityResolutionConfig> PutWebdeploymentsDeploymentIdentityresolutionWithHttpInfo (string deploymentId, IdentityResolutionConfig body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete all versions of a configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteWebdeploymentsConfigurationAsync (string configurationId);

        /// <summary>
        /// Delete all versions of a configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsConfigurationAsyncWithHttpInfo (string configurationId);

        /// <summary>
        /// Delete a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteWebdeploymentsDeploymentAsync (string deploymentId);

        /// <summary>
        /// Delete a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// Deletes a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsync (string deploymentId, string sessionId);

        /// <summary>
        /// Deletes a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo (string deploymentId, string sessionId);

        /// <summary>
        /// Invalidate JWT
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteWebdeploymentsTokenRevokeAsync (string xJourneySessionId = null, string xJourneySessionType = null);

        /// <summary>
        /// Invalidate JWT
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsTokenRevokeAsyncWithHttpInfo (string xJourneySessionId = null, string xJourneySessionType = null);

        /// <summary>
        /// Get a configuration version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionAsync (string configurationId, string versionId);

        /// <summary>
        /// Get a configuration version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> GetWebdeploymentsConfigurationVersionAsyncWithHttpInfo (string configurationId, string versionId);

        /// <summary>
        /// Get the versions of a configuration
        /// </summary>
        /// <remarks>
        /// This returns the 50 most recent versions for this configuration
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsAsync (string configurationId);

        /// <summary>
        /// Get the versions of a configuration
        /// </summary>
        /// <remarks>
        /// This returns the 50 most recent versions for this configuration
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersionEntityListing>> GetWebdeploymentsConfigurationVersionsAsyncWithHttpInfo (string configurationId);

        /// <summary>
        /// Get the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftAsync (string configurationId);

        /// <summary>
        /// Get the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> GetWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo (string configurationId);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync (bool? showOnlyPublished = null);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersionEntityListing>> GetWebdeploymentsConfigurationsAsyncWithHttpInfo (bool? showOnlyPublished = null);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of WebDeployment</returns>
        
        System.Threading.Tasks.Task<WebDeployment> GetWebdeploymentsDeploymentAsync (string deploymentId, List<string> expand = null);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeployment>> GetWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId, List<string> expand = null);

        /// <summary>
        /// Retrieves a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of CobrowseWebMessagingSession</returns>
        
        System.Threading.Tasks.Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdAsync (string deploymentId, string sessionId);

        /// <summary>
        /// Retrieves a cobrowse session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of ApiResponse (CobrowseWebMessagingSession)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CobrowseWebMessagingSession>> GetWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo (string deploymentId, string sessionId);

        /// <summary>
        /// Get active configuration for a given deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>Task of WebDeploymentActiveConfigurationOnDeployment</returns>
        
        System.Threading.Tasks.Task<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsAsync (string deploymentId, string type = null, List<string> expand = null);

        /// <summary>
        /// Get active configuration for a given deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>Task of ApiResponse (WebDeploymentActiveConfigurationOnDeployment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentActiveConfigurationOnDeployment>> GetWebdeploymentsDeploymentConfigurationsAsyncWithHttpInfo (string deploymentId, string type = null, List<string> expand = null);

        /// <summary>
        /// Get a deployment identity resolution setting.
        /// </summary>
        /// <remarks>
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of IdentityResolutionConfig</returns>
        
        System.Threading.Tasks.Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync (string deploymentId);

        /// <summary>
        /// Get a deployment identity resolution setting.
        /// </summary>
        /// <remarks>
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse (IdentityResolutionConfig)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IdentityResolutionConfig>> GetWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ExpandableWebDeploymentEntityListing</returns>
        
        System.Threading.Tasks.Task<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync (List<string> expand = null);

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ApiResponse (ExpandableWebDeploymentEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExpandableWebDeploymentEntityListing>> GetWebdeploymentsDeploymentsAsyncWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Publish the configuration draft and create a new version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationVersionsDraftPublishAsync (string configurationId);

        /// <summary>
        /// Publish the configuration draft and create a new version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PostWebdeploymentsConfigurationVersionsDraftPublishAsyncWithHttpInfo (string configurationId);

        /// <summary>
        /// Create a configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationsAsync (WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Create a configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PostWebdeploymentsConfigurationsAsyncWithHttpInfo (WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>Task of WebDeployment</returns>
        
        System.Threading.Tasks.Task<WebDeployment> PostWebdeploymentsDeploymentsAsync (WebDeployment deployment);

        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeployment>> PostWebdeploymentsDeploymentsAsyncWithHttpInfo (WebDeployment deployment);

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>Task of WebDeploymentsAuthorizationResponse</returns>
        
        System.Threading.Tasks.Task<WebDeploymentsAuthorizationResponse> PostWebdeploymentsTokenOauthcodegrantjwtexchangeAsync (WebDeploymentsOAuthExchangeRequest body);

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>Task of ApiResponse (WebDeploymentsAuthorizationResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentsAuthorizationResponse>> PostWebdeploymentsTokenOauthcodegrantjwtexchangeAsyncWithHttpInfo (WebDeploymentsOAuthExchangeRequest body);

        /// <summary>
        /// Refresh a JWT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SignedData</returns>
        
        System.Threading.Tasks.Task<SignedData> PostWebdeploymentsTokenRefreshAsync (WebDeploymentsRefreshJWTRequest body = null);

        /// <summary>
        /// Refresh a JWT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SignedData)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SignedData>> PostWebdeploymentsTokenRefreshAsyncWithHttpInfo (WebDeploymentsRefreshJWTRequest body = null);

        /// <summary>
        /// Update the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PutWebdeploymentsConfigurationVersionsDraftAsync (string configurationId, WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Update the configuration draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PutWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo (string configurationId, WebDeploymentConfigurationVersion configurationVersion);

        /// <summary>
        /// Update a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>Task of WebDeployment</returns>
        
        System.Threading.Tasks.Task<WebDeployment> PutWebdeploymentsDeploymentAsync (string deploymentId, WebDeployment deployment);

        /// <summary>
        /// Update a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<WebDeployment>> PutWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId, WebDeployment deployment);

        /// <summary>
        /// Update identity resolution settings for a deployment.
        /// </summary>
        /// <remarks>
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>Task of IdentityResolutionConfig</returns>
        
        System.Threading.Tasks.Task<IdentityResolutionConfig> PutWebdeploymentsDeploymentIdentityresolutionAsync (string deploymentId, IdentityResolutionConfig body);

        /// <summary>
        /// Update identity resolution settings for a deployment.
        /// </summary>
        /// <remarks>
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IdentityResolutionConfig)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IdentityResolutionConfig>> PutWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo (string deploymentId, IdentityResolutionConfig body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebDeploymentsApi : IWebDeploymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebDeploymentsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebDeploymentsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete all versions of a configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns></returns>
        
        public void DeleteWebdeploymentsConfiguration (string configurationId)
        {
             DeleteWebdeploymentsConfigurationWithHttpInfo(configurationId);
        }

        /// <summary>
        /// Delete all versions of a configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteWebdeploymentsConfigurationWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->DeleteWebdeploymentsConfiguration");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsConfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete all versions of a configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteWebdeploymentsConfigurationAsync (string configurationId)
        {
             await DeleteWebdeploymentsConfigurationAsyncWithHttpInfo(configurationId);

        }

        /// <summary>
        /// Delete all versions of a configuration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsConfigurationAsyncWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->DeleteWebdeploymentsConfiguration");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsConfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns></returns>
        
        public void DeleteWebdeploymentsDeployment (string deploymentId)
        {
             DeleteWebdeploymentsDeploymentWithHttpInfo(deploymentId);
        }

        /// <summary>
        /// Delete a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteWebdeploymentsDeploymentWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeployment");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteWebdeploymentsDeploymentAsync (string deploymentId)
        {
             await DeleteWebdeploymentsDeploymentAsyncWithHttpInfo(deploymentId);

        }

        /// <summary>
        /// Delete a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeployment");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Deletes a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Object</returns>
        
        public Object DeleteWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId)
        {
             ApiResponse<Object> localVarResponse = DeleteWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo(deploymentId, sessionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo (string deploymentId, string sessionId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeploymentCobrowseSessionId");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeploymentCobrowseSessionId");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Deletes a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsync (string deploymentId, string sessionId)
        {
             ApiResponse<Object> localVarResponse = await DeleteWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo(deploymentId, sessionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo (string deploymentId, string sessionId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeploymentCobrowseSessionId");
            
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling WebDeploymentsApi->DeleteWebdeploymentsDeploymentCobrowseSessionId");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Invalidate JWT 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns></returns>
        
        public void DeleteWebdeploymentsTokenRevoke (string xJourneySessionId = null, string xJourneySessionType = null)
        {
             DeleteWebdeploymentsTokenRevokeWithHttpInfo(xJourneySessionId, xJourneySessionType);
        }

        /// <summary>
        /// Invalidate JWT 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteWebdeploymentsTokenRevokeWithHttpInfo (string xJourneySessionId = null, string xJourneySessionType = null)
        { 

            var localVarPath = "/api/v2/webdeployments/token/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (xJourneySessionId != null) localVarHeaderParams.Add("X-Journey-Session-Id", this.Configuration.ApiClient.ParameterToString(xJourneySessionId)); // header parameter
            if (xJourneySessionType != null) localVarHeaderParams.Add("X-Journey-Session-Type", this.Configuration.ApiClient.ParameterToString(xJourneySessionType)); // header parameter

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsTokenRevoke: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsTokenRevoke: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Invalidate JWT 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteWebdeploymentsTokenRevokeAsync (string xJourneySessionId = null, string xJourneySessionType = null)
        {
             await DeleteWebdeploymentsTokenRevokeAsyncWithHttpInfo(xJourneySessionId, xJourneySessionType);

        }

        /// <summary>
        /// Invalidate JWT 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xJourneySessionId">The Customer&#39;s journey sessionId. (optional)</param>
        /// <param name="xJourneySessionType">The Customer&#39;s journey session type. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebdeploymentsTokenRevokeAsyncWithHttpInfo (string xJourneySessionId = null, string xJourneySessionType = null)
        { 

            var localVarPath = "/api/v2/webdeployments/token/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (xJourneySessionId != null) localVarHeaderParams.Add("X-Journey-Session-Id", this.Configuration.ApiClient.ParameterToString(xJourneySessionId)); // header parameter
            if (xJourneySessionType != null) localVarHeaderParams.Add("X-Journey-Session-Type", this.Configuration.ApiClient.ParameterToString(xJourneySessionType)); // header parameter

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsTokenRevoke: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebdeploymentsTokenRevoke: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a configuration version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        public WebDeploymentConfigurationVersion GetWebdeploymentsConfigurationVersion (string configurationId, string versionId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = GetWebdeploymentsConfigurationVersionWithHttpInfo(configurationId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a configuration version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersion > GetWebdeploymentsConfigurationVersionWithHttpInfo (string configurationId, string versionId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersion");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a configuration version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionAsync (string configurationId, string versionId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = await GetWebdeploymentsConfigurationVersionAsyncWithHttpInfo(configurationId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a configuration version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="versionId">The version of the configuration to get</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> GetWebdeploymentsConfigurationVersionAsyncWithHttpInfo (string configurationId, string versionId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersion");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the versions of a configuration 
        /// This returns the 50 most recent versions for this configuration
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        
        public WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurationVersions (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = GetWebdeploymentsConfigurationVersionsWithHttpInfo(configurationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the versions of a configuration 
        /// This returns the 50 most recent versions for this configuration
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersionEntityListing</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersionEntityListing > GetWebdeploymentsConfigurationVersionsWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersions");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the versions of a configuration 
        /// This returns the 50 most recent versions for this configuration
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsAsync (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = await GetWebdeploymentsConfigurationVersionsAsyncWithHttpInfo(configurationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the versions of a configuration 
        /// This returns the 50 most recent versions for this configuration
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersionEntityListing>> GetWebdeploymentsConfigurationVersionsAsyncWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersions");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        public WebDeploymentConfigurationVersion GetWebdeploymentsConfigurationVersionsDraft (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = GetWebdeploymentsConfigurationVersionsDraftWithHttpInfo(configurationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersion > GetWebdeploymentsConfigurationVersionsDraftWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersionsDraft");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftAsync (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = await GetWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo(configurationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> GetWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->GetWebdeploymentsConfigurationVersionsDraft");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// View configuration drafts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        
        public WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurations (bool? showOnlyPublished = null)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = GetWebdeploymentsConfigurationsWithHttpInfo(showOnlyPublished);
             return localVarResponse.Data;
        }

        /// <summary>
        /// View configuration drafts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersionEntityListing</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersionEntityListing > GetWebdeploymentsConfigurationsWithHttpInfo (bool? showOnlyPublished = null)
        { 

            var localVarPath = "/api/v2/webdeployments/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (showOnlyPublished != null) localVarQueryParams.Add(new Tuple<string, string>("showOnlyPublished", this.Configuration.ApiClient.ParameterToString(showOnlyPublished)));

            // Header params

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// View configuration drafts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync (bool? showOnlyPublished = null)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = await GetWebdeploymentsConfigurationsAsyncWithHttpInfo(showOnlyPublished);
             return localVarResponse.Data;

        }

        /// <summary>
        /// View configuration drafts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersionEntityListing>> GetWebdeploymentsConfigurationsAsyncWithHttpInfo (bool? showOnlyPublished = null)
        { 

            var localVarPath = "/api/v2/webdeployments/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (showOnlyPublished != null) localVarQueryParams.Add(new Tuple<string, string>("showOnlyPublished", this.Configuration.ApiClient.ParameterToString(showOnlyPublished)));

            // Header params

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>WebDeployment</returns>
        
        public WebDeployment GetWebdeploymentsDeployment (string deploymentId, List<string> expand = null)
        {
             ApiResponse<WebDeployment> localVarResponse = GetWebdeploymentsDeploymentWithHttpInfo(deploymentId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        public ApiResponse< WebDeployment > GetWebdeploymentsDeploymentWithHttpInfo (string deploymentId, List<string> expand = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeployment");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of WebDeployment</returns>
        
        public async System.Threading.Tasks.Task<WebDeployment> GetWebdeploymentsDeploymentAsync (string deploymentId, List<string> expand = null)
        {
             ApiResponse<WebDeployment> localVarResponse = await GetWebdeploymentsDeploymentAsyncWithHttpInfo(deploymentId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeployment>> GetWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId, List<string> expand = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeployment");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieves a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>CobrowseWebMessagingSession</returns>
        
        public CobrowseWebMessagingSession GetWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId)
        {
             ApiResponse<CobrowseWebMessagingSession> localVarResponse = GetWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo(deploymentId, sessionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>ApiResponse of CobrowseWebMessagingSession</returns>
        
        public ApiResponse< CobrowseWebMessagingSession > GetWebdeploymentsDeploymentCobrowseSessionIdWithHttpInfo (string deploymentId, string sessionId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentCobrowseSessionId");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentCobrowseSessionId");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseWebMessagingSession>(localVarStatusCode,
                localVarHeaders,
                (CobrowseWebMessagingSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseWebMessagingSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieves a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of CobrowseWebMessagingSession</returns>
        
        public async System.Threading.Tasks.Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdAsync (string deploymentId, string sessionId)
        {
             ApiResponse<CobrowseWebMessagingSession> localVarResponse = await GetWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo(deploymentId, sessionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a cobrowse session 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">WebMessaging deployment ID</param>
        /// <param name="sessionId">Cobrowse session id or join code</param>
        /// <returns>Task of ApiResponse (CobrowseWebMessagingSession)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CobrowseWebMessagingSession>> GetWebdeploymentsDeploymentCobrowseSessionIdAsyncWithHttpInfo (string deploymentId, string sessionId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentCobrowseSessionId");
            
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentCobrowseSessionId");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentCobrowseSessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseWebMessagingSession>(localVarStatusCode,
                localVarHeaders,
                (CobrowseWebMessagingSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseWebMessagingSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get active configuration for a given deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>WebDeploymentActiveConfigurationOnDeployment</returns>
        
        public WebDeploymentActiveConfigurationOnDeployment GetWebdeploymentsDeploymentConfigurations (string deploymentId, string type = null, List<string> expand = null)
        {
             ApiResponse<WebDeploymentActiveConfigurationOnDeployment> localVarResponse = GetWebdeploymentsDeploymentConfigurationsWithHttpInfo(deploymentId, type, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get active configuration for a given deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>ApiResponse of WebDeploymentActiveConfigurationOnDeployment</returns>
        
        public ApiResponse< WebDeploymentActiveConfigurationOnDeployment > GetWebdeploymentsDeploymentConfigurationsWithHttpInfo (string deploymentId, string type = null, List<string> expand = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentConfigurations");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentActiveConfigurationOnDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentActiveConfigurationOnDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentActiveConfigurationOnDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get active configuration for a given deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>Task of WebDeploymentActiveConfigurationOnDeployment</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsAsync (string deploymentId, string type = null, List<string> expand = null)
        {
             ApiResponse<WebDeploymentActiveConfigurationOnDeployment> localVarResponse = await GetWebdeploymentsDeploymentConfigurationsAsyncWithHttpInfo(deploymentId, type, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get active configuration for a given deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="type">Get active configuration on a deployment (optional)</param>
        /// <param name="expand">Expand instructions for the return value (optional)</param>
        /// <returns>Task of ApiResponse (WebDeploymentActiveConfigurationOnDeployment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentActiveConfigurationOnDeployment>> GetWebdeploymentsDeploymentConfigurationsAsyncWithHttpInfo (string deploymentId, string type = null, List<string> expand = null)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentConfigurations");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", this.Configuration.ApiClient.ParameterToString(type)));
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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentActiveConfigurationOnDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentActiveConfigurationOnDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentActiveConfigurationOnDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a deployment identity resolution setting. 
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>IdentityResolutionConfig</returns>
        
        public IdentityResolutionConfig GetWebdeploymentsDeploymentIdentityresolution (string deploymentId)
        {
             ApiResponse<IdentityResolutionConfig> localVarResponse = GetWebdeploymentsDeploymentIdentityresolutionWithHttpInfo(deploymentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a deployment identity resolution setting. 
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of IdentityResolutionConfig</returns>
        
        public ApiResponse< IdentityResolutionConfig > GetWebdeploymentsDeploymentIdentityresolutionWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentIdentityresolution");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/identityresolution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IdentityResolutionConfig>(localVarStatusCode,
                localVarHeaders,
                (IdentityResolutionConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityResolutionConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a deployment identity resolution setting. 
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of IdentityResolutionConfig</returns>
        
        public async System.Threading.Tasks.Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync (string deploymentId)
        {
             ApiResponse<IdentityResolutionConfig> localVarResponse = await GetWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo(deploymentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a deployment identity resolution setting. 
        /// 
        /// GetWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse (IdentityResolutionConfig)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IdentityResolutionConfig>> GetWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->GetWebdeploymentsDeploymentIdentityresolution");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/identityresolution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IdentityResolutionConfig>(localVarStatusCode,
                localVarHeaders,
                (IdentityResolutionConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityResolutionConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get deployments 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ExpandableWebDeploymentEntityListing</returns>
        
        public ExpandableWebDeploymentEntityListing GetWebdeploymentsDeployments (List<string> expand = null)
        {
             ApiResponse<ExpandableWebDeploymentEntityListing> localVarResponse = GetWebdeploymentsDeploymentsWithHttpInfo(expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get deployments 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>ApiResponse of ExpandableWebDeploymentEntityListing</returns>
        
        public ApiResponse< ExpandableWebDeploymentEntityListing > GetWebdeploymentsDeploymentsWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/webdeployments/deployments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExpandableWebDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ExpandableWebDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpandableWebDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get deployments 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ExpandableWebDeploymentEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync (List<string> expand = null)
        {
             ApiResponse<ExpandableWebDeploymentEntityListing> localVarResponse = await GetWebdeploymentsDeploymentsAsyncWithHttpInfo(expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get deployments 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected.  (optional)</param>
        /// <returns>Task of ApiResponse (ExpandableWebDeploymentEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExpandableWebDeploymentEntityListing>> GetWebdeploymentsDeploymentsAsyncWithHttpInfo (List<string> expand = null)
        { 

            var localVarPath = "/api/v2/webdeployments/deployments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExpandableWebDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ExpandableWebDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpandableWebDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish the configuration draft and create a new version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        public WebDeploymentConfigurationVersion PostWebdeploymentsConfigurationVersionsDraftPublish (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = PostWebdeploymentsConfigurationVersionsDraftPublishWithHttpInfo(configurationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish the configuration draft and create a new version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersion > PostWebdeploymentsConfigurationVersionsDraftPublishWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->PostWebdeploymentsConfigurationVersionsDraftPublish");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft/publish";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurationVersionsDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurationVersionsDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish the configuration draft and create a new version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationVersionsDraftPublishAsync (string configurationId)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = await PostWebdeploymentsConfigurationVersionsDraftPublishAsyncWithHttpInfo(configurationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish the configuration draft and create a new version 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PostWebdeploymentsConfigurationVersionsDraftPublishAsyncWithHttpInfo (string configurationId)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->PostWebdeploymentsConfigurationVersionsDraftPublish");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft/publish";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurationVersionsDraftPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurationVersionsDraftPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        public WebDeploymentConfigurationVersion PostWebdeploymentsConfigurations (WebDeploymentConfigurationVersion configurationVersion)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = PostWebdeploymentsConfigurationsWithHttpInfo(configurationVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersion > PostWebdeploymentsConfigurationsWithHttpInfo (WebDeploymentConfigurationVersion configurationVersion)
        { 
            // verify the required parameter 'configurationVersion' is set
            if (configurationVersion == null)
                throw new ApiException(400, "Missing required parameter 'configurationVersion' when calling WebDeploymentsApi->PostWebdeploymentsConfigurations");

            var localVarPath = "/api/v2/webdeployments/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (configurationVersion != null && configurationVersion.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(configurationVersion); // http body (model) parameter
            else
                localVarPostBody = configurationVersion; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PostWebdeploymentsConfigurationsAsync (WebDeploymentConfigurationVersion configurationVersion)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = await PostWebdeploymentsConfigurationsAsyncWithHttpInfo(configurationVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PostWebdeploymentsConfigurationsAsyncWithHttpInfo (WebDeploymentConfigurationVersion configurationVersion)
        { 
            // verify the required parameter 'configurationVersion' is set
            if (configurationVersion == null)
                throw new ApiException(400, "Missing required parameter 'configurationVersion' when calling WebDeploymentsApi->PostWebdeploymentsConfigurations");
            

            var localVarPath = "/api/v2/webdeployments/configurations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (configurationVersion != null && configurationVersion.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(configurationVersion); // http body (model) parameter
            else
                localVarPostBody = configurationVersion; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsConfigurations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>WebDeployment</returns>
        
        public WebDeployment PostWebdeploymentsDeployments (WebDeployment deployment)
        {
             ApiResponse<WebDeployment> localVarResponse = PostWebdeploymentsDeploymentsWithHttpInfo(deployment);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        public ApiResponse< WebDeployment > PostWebdeploymentsDeploymentsWithHttpInfo (WebDeployment deployment)
        { 
            // verify the required parameter 'deployment' is set
            if (deployment == null)
                throw new ApiException(400, "Missing required parameter 'deployment' when calling WebDeploymentsApi->PostWebdeploymentsDeployments");

            var localVarPath = "/api/v2/webdeployments/deployments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (deployment != null && deployment.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(deployment); // http body (model) parameter
            else
                localVarPostBody = deployment; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>Task of WebDeployment</returns>
        
        public async System.Threading.Tasks.Task<WebDeployment> PostWebdeploymentsDeploymentsAsync (WebDeployment deployment)
        {
             ApiResponse<WebDeployment> localVarResponse = await PostWebdeploymentsDeploymentsAsyncWithHttpInfo(deployment);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deployment"></param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeployment>> PostWebdeploymentsDeploymentsAsyncWithHttpInfo (WebDeployment deployment)
        { 
            // verify the required parameter 'deployment' is set
            if (deployment == null)
                throw new ApiException(400, "Missing required parameter 'deployment' when calling WebDeploymentsApi->PostWebdeploymentsDeployments");
            

            var localVarPath = "/api/v2/webdeployments/deployments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (deployment != null && deployment.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(deployment); // http body (model) parameter
            else
                localVarPostBody = deployment; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>WebDeploymentsAuthorizationResponse</returns>
        
        public WebDeploymentsAuthorizationResponse PostWebdeploymentsTokenOauthcodegrantjwtexchange (WebDeploymentsOAuthExchangeRequest body)
        {
             ApiResponse<WebDeploymentsAuthorizationResponse> localVarResponse = PostWebdeploymentsTokenOauthcodegrantjwtexchangeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>ApiResponse of WebDeploymentsAuthorizationResponse</returns>
        
        public ApiResponse< WebDeploymentsAuthorizationResponse > PostWebdeploymentsTokenOauthcodegrantjwtexchangeWithHttpInfo (WebDeploymentsOAuthExchangeRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebDeploymentsApi->PostWebdeploymentsTokenOauthcodegrantjwtexchange");

            var localVarPath = "/api/v2/webdeployments/token/oauthcodegrantjwtexchange";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenOauthcodegrantjwtexchange: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenOauthcodegrantjwtexchange: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentsAuthorizationResponse>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentsAuthorizationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentsAuthorizationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>Task of WebDeploymentsAuthorizationResponse</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentsAuthorizationResponse> PostWebdeploymentsTokenOauthcodegrantjwtexchangeAsync (WebDeploymentsOAuthExchangeRequest body)
        {
             ApiResponse<WebDeploymentsAuthorizationResponse> localVarResponse = await PostWebdeploymentsTokenOauthcodegrantjwtexchangeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webDeploymentsOAuthExchangeRequest</param>
        /// <returns>Task of ApiResponse (WebDeploymentsAuthorizationResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentsAuthorizationResponse>> PostWebdeploymentsTokenOauthcodegrantjwtexchangeAsyncWithHttpInfo (WebDeploymentsOAuthExchangeRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebDeploymentsApi->PostWebdeploymentsTokenOauthcodegrantjwtexchange");
            

            var localVarPath = "/api/v2/webdeployments/token/oauthcodegrantjwtexchange";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenOauthcodegrantjwtexchange: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenOauthcodegrantjwtexchange: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentsAuthorizationResponse>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentsAuthorizationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentsAuthorizationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Refresh a JWT. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SignedData</returns>
        
        public SignedData PostWebdeploymentsTokenRefresh (WebDeploymentsRefreshJWTRequest body = null)
        {
             ApiResponse<SignedData> localVarResponse = PostWebdeploymentsTokenRefreshWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Refresh a JWT. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SignedData</returns>
        
        public ApiResponse< SignedData > PostWebdeploymentsTokenRefreshWithHttpInfo (WebDeploymentsRefreshJWTRequest body = null)
        { 

            var localVarPath = "/api/v2/webdeployments/token/refresh";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenRefresh: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenRefresh: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedData>(localVarStatusCode,
                localVarHeaders,
                (SignedData) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedData)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Refresh a JWT. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SignedData</returns>
        
        public async System.Threading.Tasks.Task<SignedData> PostWebdeploymentsTokenRefreshAsync (WebDeploymentsRefreshJWTRequest body = null)
        {
             ApiResponse<SignedData> localVarResponse = await PostWebdeploymentsTokenRefreshAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Refresh a JWT. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SignedData)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SignedData>> PostWebdeploymentsTokenRefreshAsyncWithHttpInfo (WebDeploymentsRefreshJWTRequest body = null)
        { 

            var localVarPath = "/api/v2/webdeployments/token/refresh";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenRefresh: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebdeploymentsTokenRefresh: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedData>(localVarStatusCode,
                localVarHeaders,
                (SignedData) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedData)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>WebDeploymentConfigurationVersion</returns>
        
        public WebDeploymentConfigurationVersion PutWebdeploymentsConfigurationVersionsDraft (string configurationId, WebDeploymentConfigurationVersion configurationVersion)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = PutWebdeploymentsConfigurationVersionsDraftWithHttpInfo(configurationId, configurationVersion);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>ApiResponse of WebDeploymentConfigurationVersion</returns>
        
        public ApiResponse< WebDeploymentConfigurationVersion > PutWebdeploymentsConfigurationVersionsDraftWithHttpInfo (string configurationId, WebDeploymentConfigurationVersion configurationVersion)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->PutWebdeploymentsConfigurationVersionsDraft");
            // verify the required parameter 'configurationVersion' is set
            if (configurationVersion == null)
                throw new ApiException(400, "Missing required parameter 'configurationVersion' when calling WebDeploymentsApi->PutWebdeploymentsConfigurationVersionsDraft");

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (configurationVersion != null && configurationVersion.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(configurationVersion); // http body (model) parameter
            else
                localVarPostBody = configurationVersion; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of WebDeploymentConfigurationVersion</returns>
        
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersion> PutWebdeploymentsConfigurationVersionsDraftAsync (string configurationId, WebDeploymentConfigurationVersion configurationVersion)
        {
             ApiResponse<WebDeploymentConfigurationVersion> localVarResponse = await PutWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo(configurationId, configurationVersion);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the configuration draft 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">The configuration version ID</param>
        /// <param name="configurationVersion"></param>
        /// <returns>Task of ApiResponse (WebDeploymentConfigurationVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentConfigurationVersion>> PutWebdeploymentsConfigurationVersionsDraftAsyncWithHttpInfo (string configurationId, WebDeploymentConfigurationVersion configurationVersion)
        { 
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling WebDeploymentsApi->PutWebdeploymentsConfigurationVersionsDraft");
            
            // verify the required parameter 'configurationVersion' is set
            if (configurationVersion == null)
                throw new ApiException(400, "Missing required parameter 'configurationVersion' when calling WebDeploymentsApi->PutWebdeploymentsConfigurationVersionsDraft");
            

            var localVarPath = "/api/v2/webdeployments/configurations/{configurationId}/versions/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (configurationId != null) localVarPathParams.Add("configurationId", this.Configuration.ApiClient.ParameterToString(configurationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (configurationVersion != null && configurationVersion.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(configurationVersion); // http body (model) parameter
            else
                localVarPostBody = configurationVersion; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsConfigurationVersionsDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentConfigurationVersion>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentConfigurationVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentConfigurationVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>WebDeployment</returns>
        
        public WebDeployment PutWebdeploymentsDeployment (string deploymentId, WebDeployment deployment)
        {
             ApiResponse<WebDeployment> localVarResponse = PutWebdeploymentsDeploymentWithHttpInfo(deploymentId, deployment);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>ApiResponse of WebDeployment</returns>
        
        public ApiResponse< WebDeployment > PutWebdeploymentsDeploymentWithHttpInfo (string deploymentId, WebDeployment deployment)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->PutWebdeploymentsDeployment");
            // verify the required parameter 'deployment' is set
            if (deployment == null)
                throw new ApiException(400, "Missing required parameter 'deployment' when calling WebDeploymentsApi->PutWebdeploymentsDeployment");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (deployment != null && deployment.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(deployment); // http body (model) parameter
            else
                localVarPostBody = deployment; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>Task of WebDeployment</returns>
        
        public async System.Threading.Tasks.Task<WebDeployment> PutWebdeploymentsDeploymentAsync (string deploymentId, WebDeployment deployment)
        {
             ApiResponse<WebDeployment> localVarResponse = await PutWebdeploymentsDeploymentAsyncWithHttpInfo(deploymentId, deployment);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a deployment 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="deployment"></param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<WebDeployment>> PutWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId, WebDeployment deployment)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->PutWebdeploymentsDeployment");
            
            // verify the required parameter 'deployment' is set
            if (deployment == null)
                throw new ApiException(400, "Missing required parameter 'deployment' when calling WebDeploymentsApi->PutWebdeploymentsDeployment");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (deployment != null && deployment.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(deployment); // http body (model) parameter
            else
                localVarPostBody = deployment; // byte array



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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update identity resolution settings for a deployment. 
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>IdentityResolutionConfig</returns>
        
        public IdentityResolutionConfig PutWebdeploymentsDeploymentIdentityresolution (string deploymentId, IdentityResolutionConfig body)
        {
             ApiResponse<IdentityResolutionConfig> localVarResponse = PutWebdeploymentsDeploymentIdentityresolutionWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update identity resolution settings for a deployment. 
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IdentityResolutionConfig</returns>
        
        public ApiResponse< IdentityResolutionConfig > PutWebdeploymentsDeploymentIdentityresolutionWithHttpInfo (string deploymentId, IdentityResolutionConfig body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->PutWebdeploymentsDeploymentIdentityresolution");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebDeploymentsApi->PutWebdeploymentsDeploymentIdentityresolution");

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/identityresolution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IdentityResolutionConfig>(localVarStatusCode,
                localVarHeaders,
                (IdentityResolutionConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityResolutionConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update identity resolution settings for a deployment. 
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>Task of IdentityResolutionConfig</returns>
        
        public async System.Threading.Tasks.Task<IdentityResolutionConfig> PutWebdeploymentsDeploymentIdentityresolutionAsync (string deploymentId, IdentityResolutionConfig body)
        {
             ApiResponse<IdentityResolutionConfig> localVarResponse = await PutWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update identity resolution settings for a deployment. 
        /// 
        /// PutWebdeploymentsDeploymentIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IdentityResolutionConfig)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IdentityResolutionConfig>> PutWebdeploymentsDeploymentIdentityresolutionAsyncWithHttpInfo (string deploymentId, IdentityResolutionConfig body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebDeploymentsApi->PutWebdeploymentsDeploymentIdentityresolution");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebDeploymentsApi->PutWebdeploymentsDeploymentIdentityresolution");
            

            var localVarPath = "/api/v2/webdeployments/deployments/{deploymentId}/identityresolution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                                                             .GroupBy(header => header?.Name)
                                                             .Select(header => new
                                                         {
                                                            Name = header?.FirstOrDefault()?.Name,
                                                            Value = header.Select(x => x?.Value)?.ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebdeploymentsDeploymentIdentityresolution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IdentityResolutionConfig>(localVarStatusCode,
                localVarHeaders,
                (IdentityResolutionConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdentityResolutionConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
