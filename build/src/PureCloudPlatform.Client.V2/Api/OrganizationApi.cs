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
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmbeddedIntegration</returns>
        EmbeddedIntegration GetOrganizationsEmbeddedintegration ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        ApiResponse<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationWithHttpInfo ();
        
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
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgWhitelistSettings</returns>
        OrgWhitelistSettings GetOrganizationsWhitelist ();

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
        ApiResponse<OrgWhitelistSettings> GetOrganizationsWhitelistWithHttpInfo ();
        
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
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>EmbeddedIntegration</returns>
        EmbeddedIntegration PutOrganizationsEmbeddedintegration (EmbeddedIntegration body);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
        ApiResponse<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationWithHttpInfo (EmbeddedIntegration body);
        
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
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>OrgWhitelistSettings</returns>
        OrgWhitelistSettings PutOrganizationsWhitelist (OrgWhitelistSettings body);

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
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
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmbeddedIntegration</returns>
        System.Threading.Tasks.Task<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationAsync ();

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> GetOrganizationsEmbeddedintegrationAsyncWithHttpInfo ();
        
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
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgWhitelistSettings</returns>
        System.Threading.Tasks.Task<OrgWhitelistSettings> GetOrganizationsWhitelistAsync ();

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgWhitelistSettings>> GetOrganizationsWhitelistAsyncWithHttpInfo ();
        
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
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of EmbeddedIntegration</returns>
        System.Threading.Tasks.Task<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationAsync (EmbeddedIntegration body);

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmbeddedIntegration>> PutOrganizationsEmbeddedintegrationAsyncWithHttpInfo (EmbeddedIntegration body);
        
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
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of OrgWhitelistSettings</returns>
        System.Threading.Tasks.Task<OrgWhitelistSettings> PutOrganizationsWhitelistAsync (OrgWhitelistSettings body);

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (FieldConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
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
                (FieldConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmbeddedIntegration</returns>
        public EmbeddedIntegration GetOrganizationsEmbeddedintegration ()
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = GetOrganizationsEmbeddedintegrationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmbeddedIntegration</returns>
        public async System.Threading.Tasks.Task<EmbeddedIntegration> GetOrganizationsEmbeddedintegrationAsync ()
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = await GetOrganizationsEmbeddedintegrationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of domains that will be allowed to embed PureCloud applications 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Get organization. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgWhitelistSettings</returns>
        public OrgWhitelistSettings GetOrganizationsWhitelist ()
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = GetOrganizationsWhitelistWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgWhitelistSettings</returns>
        public async System.Threading.Tasks.Task<OrgWhitelistSettings> GetOrganizationsWhitelistAsync ()
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = await GetOrganizationsWhitelistAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Update organization 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>EmbeddedIntegration</returns>
        public EmbeddedIntegration PutOrganizationsEmbeddedintegration (EmbeddedIntegration body)
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = PutOrganizationsEmbeddedintegrationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of EmbeddedIntegration</returns>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of EmbeddedIntegration</returns>
        public async System.Threading.Tasks.Task<EmbeddedIntegration> PutOrganizationsEmbeddedintegrationAsync (EmbeddedIntegration body)
        {
             ApiResponse<EmbeddedIntegration> localVarResponse = await PutOrganizationsEmbeddedintegrationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the list of domains that will be allowed to embed PureCloud applications 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (EmbeddedIntegration)</returns>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Update organization. 
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>OrgWhitelistSettings</returns>
        public OrgWhitelistSettings PutOrganizationsWhitelist (OrgWhitelistSettings body)
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = PutOrganizationsWhitelistWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>ApiResponse of OrgWhitelistSettings</returns>
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of OrgWhitelistSettings</returns>
        public async System.Threading.Tasks.Task<OrgWhitelistSettings> PutOrganizationsWhitelistAsync (OrgWhitelistSettings body)
        {
             ApiResponse<OrgWhitelistSettings> localVarResponse = await PutOrganizationsWhitelistAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Use PUT /api/v2/organizations/embeddedintegration instead 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Whitelist settings</param>
        /// <returns>Task of ApiResponse (OrgWhitelistSettings)</returns>
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

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
