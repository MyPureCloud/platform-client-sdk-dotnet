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
    public interface IDataExtensionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get a specific named core type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Coretype</returns>
        
        Coretype GetDataextensionsCoretype (string coretypeName);

        /// <summary>
        /// Get a specific named core type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>ApiResponse of Coretype</returns>
        
        ApiResponse<Coretype> GetDataextensionsCoretypeWithHttpInfo (string coretypeName);

        /// <summary>
        /// Get the core types from which all schemas are built.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CoretypeListing</returns>
        
        CoretypeListing GetDataextensionsCoretypes ();

        /// <summary>
        /// Get the core types from which all schemas are built.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CoretypeListing</returns>
        
        ApiResponse<CoretypeListing> GetDataextensionsCoretypesWithHttpInfo ();

        /// <summary>
        /// Get quantitative limits on schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SchemaQuantityLimits</returns>
        
        SchemaQuantityLimits GetDataextensionsLimits ();

        /// <summary>
        /// Get quantitative limits on schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SchemaQuantityLimits</returns>
        
        ApiResponse<SchemaQuantityLimits> GetDataextensionsLimitsWithHttpInfo ();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get a specific named core type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Task of Coretype</returns>
        
        System.Threading.Tasks.Task<Coretype> GetDataextensionsCoretypeAsync (string coretypeName);

        /// <summary>
        /// Get a specific named core type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Task of ApiResponse (Coretype)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Coretype>> GetDataextensionsCoretypeAsyncWithHttpInfo (string coretypeName);

        /// <summary>
        /// Get the core types from which all schemas are built.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CoretypeListing</returns>
        
        System.Threading.Tasks.Task<CoretypeListing> GetDataextensionsCoretypesAsync ();

        /// <summary>
        /// Get the core types from which all schemas are built.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CoretypeListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CoretypeListing>> GetDataextensionsCoretypesAsyncWithHttpInfo ();

        /// <summary>
        /// Get quantitative limits on schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SchemaQuantityLimits</returns>
        
        System.Threading.Tasks.Task<SchemaQuantityLimits> GetDataextensionsLimitsAsync ();

        /// <summary>
        /// Get quantitative limits on schemas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SchemaQuantityLimits)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SchemaQuantityLimits>> GetDataextensionsLimitsAsyncWithHttpInfo ();

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataExtensionsApi : IDataExtensionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtensionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataExtensionsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtensionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataExtensionsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get a specific named core type. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Coretype</returns>
        
        public Coretype GetDataextensionsCoretype (string coretypeName)
        {
             ApiResponse<Coretype> localVarResponse = GetDataextensionsCoretypeWithHttpInfo(coretypeName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific named core type. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>ApiResponse of Coretype</returns>
        
        public ApiResponse< Coretype > GetDataextensionsCoretypeWithHttpInfo (string coretypeName)
        { 
            // verify the required parameter 'coretypeName' is set
            if (coretypeName == null)
                throw new ApiException(400, "Missing required parameter 'coretypeName' when calling DataExtensionsApi->GetDataextensionsCoretype");

            var localVarPath = "/api/v2/dataextensions/coretypes/{coretypeName}";
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
            if (coretypeName != null) localVarPathParams.Add("coretypeName", this.Configuration.ApiClient.ParameterToString(coretypeName));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Coretype>(localVarStatusCode,
                localVarHeaders,
                (Coretype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coretype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a specific named core type. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Task of Coretype</returns>
        
        public async System.Threading.Tasks.Task<Coretype> GetDataextensionsCoretypeAsync (string coretypeName)
        {
             ApiResponse<Coretype> localVarResponse = await GetDataextensionsCoretypeAsyncWithHttpInfo(coretypeName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific named core type. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="coretypeName">The core type&#39;s name</param>
        /// <returns>Task of ApiResponse (Coretype)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Coretype>> GetDataextensionsCoretypeAsyncWithHttpInfo (string coretypeName)
        { 
            // verify the required parameter 'coretypeName' is set
            if (coretypeName == null)
                throw new ApiException(400, "Missing required parameter 'coretypeName' when calling DataExtensionsApi->GetDataextensionsCoretype");
            

            var localVarPath = "/api/v2/dataextensions/coretypes/{coretypeName}";
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
            if (coretypeName != null) localVarPathParams.Add("coretypeName", this.Configuration.ApiClient.ParameterToString(coretypeName));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Coretype>(localVarStatusCode,
                localVarHeaders,
                (Coretype) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coretype)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the core types from which all schemas are built. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CoretypeListing</returns>
        
        public CoretypeListing GetDataextensionsCoretypes ()
        {
             ApiResponse<CoretypeListing> localVarResponse = GetDataextensionsCoretypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the core types from which all schemas are built. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CoretypeListing</returns>
        
        public ApiResponse< CoretypeListing > GetDataextensionsCoretypesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/dataextensions/coretypes";
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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoretypeListing>(localVarStatusCode,
                localVarHeaders,
                (CoretypeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoretypeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the core types from which all schemas are built. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CoretypeListing</returns>
        
        public async System.Threading.Tasks.Task<CoretypeListing> GetDataextensionsCoretypesAsync ()
        {
             ApiResponse<CoretypeListing> localVarResponse = await GetDataextensionsCoretypesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the core types from which all schemas are built. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CoretypeListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CoretypeListing>> GetDataextensionsCoretypesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/dataextensions/coretypes";
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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsCoretypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoretypeListing>(localVarStatusCode,
                localVarHeaders,
                (CoretypeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoretypeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get quantitative limits on schemas 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SchemaQuantityLimits</returns>
        
        public SchemaQuantityLimits GetDataextensionsLimits ()
        {
             ApiResponse<SchemaQuantityLimits> localVarResponse = GetDataextensionsLimitsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get quantitative limits on schemas 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SchemaQuantityLimits</returns>
        
        public ApiResponse< SchemaQuantityLimits > GetDataextensionsLimitsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/dataextensions/limits";
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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsLimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsLimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaQuantityLimits>(localVarStatusCode,
                localVarHeaders,
                (SchemaQuantityLimits) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaQuantityLimits)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get quantitative limits on schemas 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SchemaQuantityLimits</returns>
        
        public async System.Threading.Tasks.Task<SchemaQuantityLimits> GetDataextensionsLimitsAsync ()
        {
             ApiResponse<SchemaQuantityLimits> localVarResponse = await GetDataextensionsLimitsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get quantitative limits on schemas 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SchemaQuantityLimits)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SchemaQuantityLimits>> GetDataextensionsLimitsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/dataextensions/limits";
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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsLimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDataextensionsLimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaQuantityLimits>(localVarStatusCode,
                localVarHeaders,
                (SchemaQuantityLimits) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaQuantityLimits)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
