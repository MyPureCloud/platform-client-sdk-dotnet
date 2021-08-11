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
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurations (bool? showOnlyPublished = null);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
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
        /// <returns>WebDeployment</returns>
        WebDeployment GetWebdeploymentsDeployment (string deploymentId);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of WebDeployment</returns>
        ApiResponse<WebDeployment> GetWebdeploymentsDeploymentWithHttpInfo (string deploymentId);
        
        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebDeploymentEntityListing</returns>
        WebDeploymentEntityListing GetWebdeploymentsDeployments ();

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebDeploymentEntityListing</returns>
        ApiResponse<WebDeploymentEntityListing> GetWebdeploymentsDeploymentsWithHttpInfo ();
        
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
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync (bool? showOnlyPublished = null);

        /// <summary>
        /// View configuration drafts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
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
        /// <returns>Task of WebDeployment</returns>
        System.Threading.Tasks.Task<WebDeployment> GetWebdeploymentsDeploymentAsync (string deploymentId);

        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebDeployment>> GetWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId);
        
        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebDeploymentEntityListing</returns>
        System.Threading.Tasks.Task<WebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync ();

        /// <summary>
        /// Get deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebDeploymentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebDeploymentEntityListing>> GetWebdeploymentsDeploymentsAsyncWithHttpInfo ();
        
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
        /// Delete all versions of a configuration 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Get a configuration version 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Get the versions of a configuration This returns the 50 most recent versions for this configuration
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
        /// Get the versions of a configuration This returns the 50 most recent versions for this configuration
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Get the versions of a configuration This returns the 50 most recent versions for this configuration
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
        /// Get the versions of a configuration This returns the 50 most recent versions for this configuration
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
        /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
        public WebDeploymentConfigurationVersionEntityListing GetWebdeploymentsConfigurations (bool? showOnlyPublished = null)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = GetWebdeploymentsConfigurationsWithHttpInfo(showOnlyPublished);
             return localVarResponse.Data;
        }

        /// <summary>
        /// View configuration drafts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
        /// <returns>Task of WebDeploymentConfigurationVersionEntityListing</returns>
        public async System.Threading.Tasks.Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync (bool? showOnlyPublished = null)
        {
             ApiResponse<WebDeploymentConfigurationVersionEntityListing> localVarResponse = await GetWebdeploymentsConfigurationsAsyncWithHttpInfo(showOnlyPublished);
             return localVarResponse.Data;

        }

        /// <summary>
        /// View configuration drafts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="showOnlyPublished">Get only configuration drafts with published versions (optional, default to false)</param>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>WebDeployment</returns>
        public WebDeployment GetWebdeploymentsDeployment (string deploymentId)
        {
             ApiResponse<WebDeployment> localVarResponse = GetWebdeploymentsDeploymentWithHttpInfo(deploymentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>ApiResponse of WebDeployment</returns>
        public ApiResponse< WebDeployment > GetWebdeploymentsDeploymentWithHttpInfo (string deploymentId)
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of WebDeployment</returns>
        public async System.Threading.Tasks.Task<WebDeployment> GetWebdeploymentsDeploymentAsync (string deploymentId)
        {
             ApiResponse<WebDeployment> localVarResponse = await GetWebdeploymentsDeploymentAsyncWithHttpInfo(deploymentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">The deployment ID</param>
        /// <returns>Task of ApiResponse (WebDeployment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebDeployment>> GetWebdeploymentsDeploymentAsyncWithHttpInfo (string deploymentId)
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
        /// Get deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebDeploymentEntityListing</returns>
        public WebDeploymentEntityListing GetWebdeploymentsDeployments ()
        {
             ApiResponse<WebDeploymentEntityListing> localVarResponse = GetWebdeploymentsDeploymentsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebDeploymentEntityListing</returns>
        public ApiResponse< WebDeploymentEntityListing > GetWebdeploymentsDeploymentsWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebDeploymentEntityListing</returns>
        public async System.Threading.Tasks.Task<WebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync ()
        {
             ApiResponse<WebDeploymentEntityListing> localVarResponse = await GetWebdeploymentsDeploymentsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebDeploymentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebDeploymentEntityListing>> GetWebdeploymentsDeploymentsAsyncWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebdeploymentsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Publish the configuration draft and create a new version 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Update the configuration draft 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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

        
        
    }
    
}
