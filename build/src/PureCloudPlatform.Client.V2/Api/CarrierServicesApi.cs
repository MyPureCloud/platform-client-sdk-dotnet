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
    public interface ICarrierServicesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>EmergencyLocation</returns>
        
        
        EmergencyLocation GetCarrierservicesIntegrationsEmergencylocationsMe (string phoneNumber);

        /// <summary>
        /// Get location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>ApiResponse of EmergencyLocation</returns>
        
        
        ApiResponse<EmergencyLocation> GetCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo (string phoneNumber);

        /// <summary>
        /// Set current location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EmergencyLocation</returns>
        
        
        EmergencyLocation PostCarrierservicesIntegrationsEmergencylocationsMe (EmergencyLocation body = null);

        /// <summary>
        /// Set current location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmergencyLocation</returns>
        
        
        ApiResponse<EmergencyLocation> PostCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo (EmergencyLocation body = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>Task of EmergencyLocation</returns>
        
        
        System.Threading.Tasks.Task<EmergencyLocation> GetCarrierservicesIntegrationsEmergencylocationsMeAsync (string phoneNumber);

        /// <summary>
        /// Get location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>Task of ApiResponse (EmergencyLocation)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<EmergencyLocation>> GetCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo (string phoneNumber);

        /// <summary>
        /// Set current location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmergencyLocation</returns>
        
        
        System.Threading.Tasks.Task<EmergencyLocation> PostCarrierservicesIntegrationsEmergencylocationsMeAsync (EmergencyLocation body = null);

        /// <summary>
        /// Set current location for the logged in user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmergencyLocation)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<EmergencyLocation>> PostCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo (EmergencyLocation body = null);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CarrierServicesApi : ICarrierServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CarrierServicesApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CarrierServicesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>EmergencyLocation</returns>
        
        
        public EmergencyLocation GetCarrierservicesIntegrationsEmergencylocationsMe (string phoneNumber)
        {
             ApiResponse<EmergencyLocation> localVarResponse = GetCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo(phoneNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>ApiResponse of EmergencyLocation</returns>
        
        
        public ApiResponse< EmergencyLocation > GetCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo (string phoneNumber)
        { 
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling CarrierServicesApi->GetCarrierservicesIntegrationsEmergencylocationsMe");

            var localVarPath = "/api/v2/carrierservices/integrations/emergencylocations/me";
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
            if (phoneNumber != null) localVarQueryParams.Add(new Tuple<string, string>("phoneNumber", this.Configuration.ApiClient.ParameterToString(phoneNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmergencyLocation>(localVarStatusCode,
                localVarHeaders,
                (EmergencyLocation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmergencyLocation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>Task of EmergencyLocation</returns>
        
        
        public async System.Threading.Tasks.Task<EmergencyLocation> GetCarrierservicesIntegrationsEmergencylocationsMeAsync (string phoneNumber)
        {
             ApiResponse<EmergencyLocation> localVarResponse = await GetCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo(phoneNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">Phone number in E164 format</param>
        /// <returns>Task of ApiResponse (EmergencyLocation)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<EmergencyLocation>> GetCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo (string phoneNumber)
        { 
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling CarrierServicesApi->GetCarrierservicesIntegrationsEmergencylocationsMe");
            

            var localVarPath = "/api/v2/carrierservices/integrations/emergencylocations/me";
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
            if (phoneNumber != null) localVarQueryParams.Add(new Tuple<string, string>("phoneNumber", this.Configuration.ApiClient.ParameterToString(phoneNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmergencyLocation>(localVarStatusCode,
                localVarHeaders,
                (EmergencyLocation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmergencyLocation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set current location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EmergencyLocation</returns>
        
        
        public EmergencyLocation PostCarrierservicesIntegrationsEmergencylocationsMe (EmergencyLocation body = null)
        {
             ApiResponse<EmergencyLocation> localVarResponse = PostCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set current location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmergencyLocation</returns>
        
        
        public ApiResponse< EmergencyLocation > PostCarrierservicesIntegrationsEmergencylocationsMeWithHttpInfo (EmergencyLocation body = null)
        { 

            var localVarPath = "/api/v2/carrierservices/integrations/emergencylocations/me";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmergencyLocation>(localVarStatusCode,
                localVarHeaders,
                (EmergencyLocation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmergencyLocation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set current location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmergencyLocation</returns>
        
        
        public async System.Threading.Tasks.Task<EmergencyLocation> PostCarrierservicesIntegrationsEmergencylocationsMeAsync (EmergencyLocation body = null)
        {
             ApiResponse<EmergencyLocation> localVarResponse = await PostCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set current location for the logged in user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmergencyLocation)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<EmergencyLocation>> PostCarrierservicesIntegrationsEmergencylocationsMeAsyncWithHttpInfo (EmergencyLocation body = null)
        { 

            var localVarPath = "/api/v2/carrierservices/integrations/emergencylocations/me";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCarrierservicesIntegrationsEmergencylocationsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmergencyLocation>(localVarStatusCode,
                localVarHeaders,
                (EmergencyLocation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmergencyLocation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
