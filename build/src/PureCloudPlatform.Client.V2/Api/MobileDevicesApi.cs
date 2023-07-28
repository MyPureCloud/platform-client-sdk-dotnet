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
    public interface IMobileDevicesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns></returns>
        
        void DeleteMobiledevice (string deviceId);

        /// <summary>
        /// Delete device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteMobiledeviceWithHttpInfo (string deviceId);

        /// <summary>
        /// Get device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>UserDevice</returns>
        
        UserDevice GetMobiledevice (string deviceId);

        /// <summary>
        /// Get device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        ApiResponse<UserDevice> GetMobiledeviceWithHttpInfo (string deviceId);

        /// <summary>
        /// Get a list of all devices.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>DirectoryUserDevicesListing</returns>
        
        DirectoryUserDevicesListing GetMobiledevices (int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get a list of all devices.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>ApiResponse of DirectoryUserDevicesListing</returns>
        
        ApiResponse<DirectoryUserDevicesListing> GetMobiledevicesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Create User device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>UserDevice</returns>
        
        UserDevice PostMobiledevices (UserDevice body);

        /// <summary>
        /// Create User device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        ApiResponse<UserDevice> PostMobiledevicesWithHttpInfo (UserDevice body);

        /// <summary>
        /// Update device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>UserDevice</returns>
        
        UserDevice PutMobiledevice (string deviceId, UserDevice body = null);

        /// <summary>
        /// Update device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        ApiResponse<UserDevice> PutMobiledeviceWithHttpInfo (string deviceId, UserDevice body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteMobiledeviceAsync (string deviceId);

        /// <summary>
        /// Delete device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMobiledeviceAsyncWithHttpInfo (string deviceId);

        /// <summary>
        /// Get device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of UserDevice</returns>
        
        System.Threading.Tasks.Task<UserDevice> GetMobiledeviceAsync (string deviceId);

        /// <summary>
        /// Get device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserDevice>> GetMobiledeviceAsyncWithHttpInfo (string deviceId);

        /// <summary>
        /// Get a list of all devices.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>Task of DirectoryUserDevicesListing</returns>
        
        System.Threading.Tasks.Task<DirectoryUserDevicesListing> GetMobiledevicesAsync (int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get a list of all devices.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DirectoryUserDevicesListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DirectoryUserDevicesListing>> GetMobiledevicesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Create User device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>Task of UserDevice</returns>
        
        System.Threading.Tasks.Task<UserDevice> PostMobiledevicesAsync (UserDevice body);

        /// <summary>
        /// Create User device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserDevice>> PostMobiledevicesAsyncWithHttpInfo (UserDevice body);

        /// <summary>
        /// Update device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>Task of UserDevice</returns>
        
        System.Threading.Tasks.Task<UserDevice> PutMobiledeviceAsync (string deviceId, UserDevice body = null);

        /// <summary>
        /// Update device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<UserDevice>> PutMobiledeviceAsyncWithHttpInfo (string deviceId, UserDevice body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MobileDevicesApi : IMobileDevicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileDevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobileDevicesApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileDevicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobileDevicesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns></returns>
        
        public void DeleteMobiledevice (string deviceId)
        {
             DeleteMobiledeviceWithHttpInfo(deviceId);
        }

        /// <summary>
        /// Delete device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteMobiledeviceWithHttpInfo (string deviceId)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->DeleteMobiledevice");

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteMobiledeviceAsync (string deviceId)
        {
             await DeleteMobiledeviceAsyncWithHttpInfo(deviceId);

        }

        /// <summary>
        /// Delete device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMobiledeviceAsyncWithHttpInfo (string deviceId)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->DeleteMobiledevice");
            

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>UserDevice</returns>
        
        public UserDevice GetMobiledevice (string deviceId)
        {
             ApiResponse<UserDevice> localVarResponse = GetMobiledeviceWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        public ApiResponse< UserDevice > GetMobiledeviceWithHttpInfo (string deviceId)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->GetMobiledevice");

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of UserDevice</returns>
        
        public async System.Threading.Tasks.Task<UserDevice> GetMobiledeviceAsync (string deviceId)
        {
             ApiResponse<UserDevice> localVarResponse = await GetMobiledeviceAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserDevice>> GetMobiledeviceAsyncWithHttpInfo (string deviceId)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->GetMobiledevice");
            

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of all devices. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>DirectoryUserDevicesListing</returns>
        
        public DirectoryUserDevicesListing GetMobiledevices (int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<DirectoryUserDevicesListing> localVarResponse = GetMobiledevicesWithHttpInfo(pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of all devices. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>ApiResponse of DirectoryUserDevicesListing</returns>
        
        public ApiResponse< DirectoryUserDevicesListing > GetMobiledevicesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/mobiledevices";
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
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DirectoryUserDevicesListing>(localVarStatusCode,
                localVarHeaders,
                (DirectoryUserDevicesListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DirectoryUserDevicesListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of all devices. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>Task of DirectoryUserDevicesListing</returns>
        
        public async System.Threading.Tasks.Task<DirectoryUserDevicesListing> GetMobiledevicesAsync (int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<DirectoryUserDevicesListing> localVarResponse = await GetMobiledevicesAsyncWithHttpInfo(pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of all devices. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DirectoryUserDevicesListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DirectoryUserDevicesListing>> GetMobiledevicesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/mobiledevices";
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
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMobiledevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DirectoryUserDevicesListing>(localVarStatusCode,
                localVarHeaders,
                (DirectoryUserDevicesListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DirectoryUserDevicesListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create User device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>UserDevice</returns>
        
        public UserDevice PostMobiledevices (UserDevice body)
        {
             ApiResponse<UserDevice> localVarResponse = PostMobiledevicesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create User device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        public ApiResponse< UserDevice > PostMobiledevicesWithHttpInfo (UserDevice body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobileDevicesApi->PostMobiledevices");

            var localVarPath = "/api/v2/mobiledevices";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMobiledevices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMobiledevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create User device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>Task of UserDevice</returns>
        
        public async System.Threading.Tasks.Task<UserDevice> PostMobiledevicesAsync (UserDevice body)
        {
             ApiResponse<UserDevice> localVarResponse = await PostMobiledevicesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create User device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Device</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserDevice>> PostMobiledevicesAsyncWithHttpInfo (UserDevice body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobileDevicesApi->PostMobiledevices");
            

            var localVarPath = "/api/v2/mobiledevices";
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
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMobiledevices: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMobiledevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>UserDevice</returns>
        
        public UserDevice PutMobiledevice (string deviceId, UserDevice body = null)
        {
             ApiResponse<UserDevice> localVarResponse = PutMobiledeviceWithHttpInfo(deviceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>ApiResponse of UserDevice</returns>
        
        public ApiResponse< UserDevice > PutMobiledeviceWithHttpInfo (string deviceId, UserDevice body = null)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->PutMobiledevice");

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>Task of UserDevice</returns>
        
        public async System.Threading.Tasks.Task<UserDevice> PutMobiledeviceAsync (string deviceId, UserDevice body = null)
        {
             ApiResponse<UserDevice> localVarResponse = await PutMobiledeviceAsyncWithHttpInfo(deviceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update device 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID</param>
        /// <param name="body">Device (optional)</param>
        /// <returns>Task of ApiResponse (UserDevice)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<UserDevice>> PutMobiledeviceAsyncWithHttpInfo (string deviceId, UserDevice body = null)
        { 
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling MobileDevicesApi->PutMobiledevice");
            

            var localVarPath = "/api/v2/mobiledevices/{deviceId}";
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
            if (deviceId != null) localVarPathParams.Add("deviceId", this.Configuration.ApiClient.ParameterToString(deviceId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMobiledevice: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMobiledevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserDevice>(localVarStatusCode,
                localVarHeaders,
                (UserDevice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDevice)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
