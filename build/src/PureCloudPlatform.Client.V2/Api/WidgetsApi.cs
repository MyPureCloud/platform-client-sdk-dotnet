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
    public interface IWidgetsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns></returns>
        void DeleteWidgetsDeployment (string deploymentId);

        /// <summary>
        /// Delete a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWidgetsDeploymentWithHttpInfo (string deploymentId);

        /// <summary>
        /// Get a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>WidgetDeployment</returns>
        WidgetDeployment GetWidgetsDeployment (string deploymentId);

        /// <summary>
        /// Get a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        ApiResponse<WidgetDeployment> GetWidgetsDeploymentWithHttpInfo (string deploymentId);

        /// <summary>
        /// List Widget deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WidgetDeploymentEntityListing</returns>
        WidgetDeploymentEntityListing GetWidgetsDeployments ();

        /// <summary>
        /// List Widget deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WidgetDeploymentEntityListing</returns>
        ApiResponse<WidgetDeploymentEntityListing> GetWidgetsDeploymentsWithHttpInfo ();

        /// <summary>
        /// Create Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>WidgetDeployment</returns>
        WidgetDeployment PostWidgetsDeployments (WidgetDeployment body);

        /// <summary>
        /// Create Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        ApiResponse<WidgetDeployment> PostWidgetsDeploymentsWithHttpInfo (WidgetDeployment body);

        /// <summary>
        /// Update a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>WidgetDeployment</returns>
        WidgetDeployment PutWidgetsDeployment (string deploymentId, WidgetDeployment body);

        /// <summary>
        /// Update a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        ApiResponse<WidgetDeployment> PutWidgetsDeploymentWithHttpInfo (string deploymentId, WidgetDeployment body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWidgetsDeploymentAsync (string deploymentId);

        /// <summary>
        /// Delete a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWidgetsDeploymentAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// Get a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of WidgetDeployment</returns>
        System.Threading.Tasks.Task<WidgetDeployment> GetWidgetsDeploymentAsync (string deploymentId);

        /// <summary>
        /// Get a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> GetWidgetsDeploymentAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// List Widget deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WidgetDeploymentEntityListing</returns>
        System.Threading.Tasks.Task<WidgetDeploymentEntityListing> GetWidgetsDeploymentsAsync ();

        /// <summary>
        /// List Widget deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WidgetDeploymentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WidgetDeploymentEntityListing>> GetWidgetsDeploymentsAsyncWithHttpInfo ();

        /// <summary>
        /// Create Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WidgetDeployment</returns>
        System.Threading.Tasks.Task<WidgetDeployment> PostWidgetsDeploymentsAsync (WidgetDeployment body);

        /// <summary>
        /// Create Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> PostWidgetsDeploymentsAsyncWithHttpInfo (WidgetDeployment body);

        /// <summary>
        /// Update a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WidgetDeployment</returns>
        System.Threading.Tasks.Task<WidgetDeployment> PutWidgetsDeploymentAsync (string deploymentId, WidgetDeployment body);

        /// <summary>
        /// Update a Widget deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> PutWidgetsDeploymentAsyncWithHttpInfo (string deploymentId, WidgetDeployment body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WidgetsApi : IWidgetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WidgetsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WidgetsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns></returns>
        public void DeleteWidgetsDeployment (string deploymentId)
        {
             DeleteWidgetsDeploymentWithHttpInfo(deploymentId);
        }

        /// <summary>
        /// Delete a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWidgetsDeploymentWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->DeleteWidgetsDeployment");

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWidgetsDeploymentAsync (string deploymentId)
        {
             await DeleteWidgetsDeploymentAsyncWithHttpInfo(deploymentId);

        }

        /// <summary>
        /// Delete a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWidgetsDeploymentAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->DeleteWidgetsDeployment");
            

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>WidgetDeployment</returns>
        public WidgetDeployment GetWidgetsDeployment (string deploymentId)
        {
             ApiResponse<WidgetDeployment> localVarResponse = GetWidgetsDeploymentWithHttpInfo(deploymentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        public ApiResponse< WidgetDeployment > GetWidgetsDeploymentWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->GetWidgetsDeployment");

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of WidgetDeployment</returns>
        public async System.Threading.Tasks.Task<WidgetDeployment> GetWidgetsDeploymentAsync (string deploymentId)
        {
             ApiResponse<WidgetDeployment> localVarResponse = await GetWidgetsDeploymentAsyncWithHttpInfo(deploymentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> GetWidgetsDeploymentAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->GetWidgetsDeployment");
            

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List Widget deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WidgetDeploymentEntityListing</returns>
        public WidgetDeploymentEntityListing GetWidgetsDeployments ()
        {
             ApiResponse<WidgetDeploymentEntityListing> localVarResponse = GetWidgetsDeploymentsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Widget deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WidgetDeploymentEntityListing</returns>
        public ApiResponse< WidgetDeploymentEntityListing > GetWidgetsDeploymentsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/widgets/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List Widget deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WidgetDeploymentEntityListing</returns>
        public async System.Threading.Tasks.Task<WidgetDeploymentEntityListing> GetWidgetsDeploymentsAsync ()
        {
             ApiResponse<WidgetDeploymentEntityListing> localVarResponse = await GetWidgetsDeploymentsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Widget deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WidgetDeploymentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WidgetDeploymentEntityListing>> GetWidgetsDeploymentsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/widgets/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWidgetsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>WidgetDeployment</returns>
        public WidgetDeployment PostWidgetsDeployments (WidgetDeployment body)
        {
             ApiResponse<WidgetDeployment> localVarResponse = PostWidgetsDeploymentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        public ApiResponse< WidgetDeployment > PostWidgetsDeploymentsWithHttpInfo (WidgetDeployment body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WidgetsApi->PostWidgetsDeployments");

            var localVarPath = "/api/v2/widgets/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostWidgetsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWidgetsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WidgetDeployment</returns>
        public async System.Threading.Tasks.Task<WidgetDeployment> PostWidgetsDeploymentsAsync (WidgetDeployment body)
        {
             ApiResponse<WidgetDeployment> localVarResponse = await PostWidgetsDeploymentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> PostWidgetsDeploymentsAsyncWithHttpInfo (WidgetDeployment body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WidgetsApi->PostWidgetsDeployments");
            

            var localVarPath = "/api/v2/widgets/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostWidgetsDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWidgetsDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>WidgetDeployment</returns>
        public WidgetDeployment PutWidgetsDeployment (string deploymentId, WidgetDeployment body)
        {
             ApiResponse<WidgetDeployment> localVarResponse = PutWidgetsDeploymentWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WidgetDeployment</returns>
        public ApiResponse< WidgetDeployment > PutWidgetsDeploymentWithHttpInfo (string deploymentId, WidgetDeployment body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->PutWidgetsDeployment");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WidgetsApi->PutWidgetsDeployment");

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WidgetDeployment</returns>
        public async System.Threading.Tasks.Task<WidgetDeployment> PutWidgetsDeploymentAsync (string deploymentId, WidgetDeployment body)
        {
             ApiResponse<WidgetDeployment> localVarResponse = await PutWidgetsDeploymentAsyncWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Widget deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Widget Config Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WidgetDeployment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WidgetDeployment>> PutWidgetsDeploymentAsyncWithHttpInfo (string deploymentId, WidgetDeployment body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WidgetsApi->PutWidgetsDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WidgetsApi->PutWidgetsDeployment");
            

            var localVarPath = "/api/v2/widgets/deployments/{deploymentId}";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWidgetsDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWidgetsDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WidgetDeployment>(localVarStatusCode,
                localVarHeaders,
                (WidgetDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WidgetDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
