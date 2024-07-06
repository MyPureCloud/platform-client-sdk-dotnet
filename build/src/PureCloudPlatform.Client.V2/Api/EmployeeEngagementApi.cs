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
    public interface IEmployeeEngagementApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Deletes a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns></returns>
        
        void DeleteEmployeeengagementCelebration (string celebrationId);

        /// <summary>
        /// Deletes a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteEmployeeengagementCelebrationWithHttpInfo (string celebrationId);

        /// <summary>
        /// Get all celebrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>GetCelebrationListing</returns>
        
        GetCelebrationListing GetEmployeeengagementCelebrations (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all celebrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of GetCelebrationListing</returns>
        
        ApiResponse<GetCelebrationListing> GetEmployeeengagementCelebrationsWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a single recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Recognition</returns>
        
        Recognition GetEmployeeengagementRecognition (string recognitionId);

        /// <summary>
        /// Gets a single recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>ApiResponse of Recognition</returns>
        
        ApiResponse<Recognition> GetEmployeeengagementRecognitionWithHttpInfo (string recognitionId);

        /// <summary>
        /// Set a state for a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns></returns>
        
        void PatchEmployeeengagementCelebration (string celebrationId, CelebrationStateParam body);

        /// <summary>
        /// Set a state for a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PatchEmployeeengagementCelebrationWithHttpInfo (string celebrationId, CelebrationStateParam body);

        /// <summary>
        /// Creates a recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>RecognitionBase</returns>
        
        RecognitionBase PostEmployeeengagementRecognitions (CreateRecognition body);

        /// <summary>
        /// Creates a recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>ApiResponse of RecognitionBase</returns>
        
        ApiResponse<RecognitionBase> PostEmployeeengagementRecognitionsWithHttpInfo (CreateRecognition body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Deletes a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteEmployeeengagementCelebrationAsync (string celebrationId);

        /// <summary>
        /// Deletes a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmployeeengagementCelebrationAsyncWithHttpInfo (string celebrationId);

        /// <summary>
        /// Get all celebrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of GetCelebrationListing</returns>
        
        System.Threading.Tasks.Task<GetCelebrationListing> GetEmployeeengagementCelebrationsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all celebrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (GetCelebrationListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GetCelebrationListing>> GetEmployeeengagementCelebrationsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a single recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Task of Recognition</returns>
        
        System.Threading.Tasks.Task<Recognition> GetEmployeeengagementRecognitionAsync (string recognitionId);

        /// <summary>
        /// Gets a single recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Task of ApiResponse (Recognition)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Recognition>> GetEmployeeengagementRecognitionAsyncWithHttpInfo (string recognitionId);

        /// <summary>
        /// Set a state for a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PatchEmployeeengagementCelebrationAsync (string celebrationId, CelebrationStateParam body);

        /// <summary>
        /// Set a state for a celebration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmployeeengagementCelebrationAsyncWithHttpInfo (string celebrationId, CelebrationStateParam body);

        /// <summary>
        /// Creates a recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>Task of RecognitionBase</returns>
        
        System.Threading.Tasks.Task<RecognitionBase> PostEmployeeengagementRecognitionsAsync (CreateRecognition body);

        /// <summary>
        /// Creates a recognition
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>Task of ApiResponse (RecognitionBase)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<RecognitionBase>> PostEmployeeengagementRecognitionsAsyncWithHttpInfo (CreateRecognition body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmployeeEngagementApi : IEmployeeEngagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeEngagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmployeeEngagementApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeEngagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmployeeEngagementApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Deletes a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns></returns>
        
        public void DeleteEmployeeengagementCelebration (string celebrationId)
        {
             DeleteEmployeeengagementCelebrationWithHttpInfo(celebrationId);
        }

        /// <summary>
        /// Deletes a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteEmployeeengagementCelebrationWithHttpInfo (string celebrationId)
        { 
            // verify the required parameter 'celebrationId' is set
            if (celebrationId == null)
                throw new ApiException(400, "Missing required parameter 'celebrationId' when calling EmployeeEngagementApi->DeleteEmployeeengagementCelebration");

            var localVarPath = "/api/v2/employeeengagement/celebrations/{celebrationId}";
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
            if (celebrationId != null) localVarPathParams.Add("celebrationId", this.Configuration.ApiClient.ParameterToString(celebrationId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmployeeengagementCelebration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmployeeengagementCelebration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Deletes a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteEmployeeengagementCelebrationAsync (string celebrationId)
        {
             await DeleteEmployeeengagementCelebrationAsyncWithHttpInfo(celebrationId);

        }

        /// <summary>
        /// Deletes a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmployeeengagementCelebrationAsyncWithHttpInfo (string celebrationId)
        { 
            // verify the required parameter 'celebrationId' is set
            if (celebrationId == null)
                throw new ApiException(400, "Missing required parameter 'celebrationId' when calling EmployeeEngagementApi->DeleteEmployeeengagementCelebration");
            

            var localVarPath = "/api/v2/employeeengagement/celebrations/{celebrationId}";
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
            if (celebrationId != null) localVarPathParams.Add("celebrationId", this.Configuration.ApiClient.ParameterToString(celebrationId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmployeeengagementCelebration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmployeeengagementCelebration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all celebrations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>GetCelebrationListing</returns>
        
        public GetCelebrationListing GetEmployeeengagementCelebrations (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<GetCelebrationListing> localVarResponse = GetEmployeeengagementCelebrationsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all celebrations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of GetCelebrationListing</returns>
        
        public ApiResponse< GetCelebrationListing > GetEmployeeengagementCelebrationsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/employeeengagement/celebrations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementCelebrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementCelebrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetCelebrationListing>(localVarStatusCode,
                localVarHeaders,
                (GetCelebrationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetCelebrationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all celebrations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of GetCelebrationListing</returns>
        
        public async System.Threading.Tasks.Task<GetCelebrationListing> GetEmployeeengagementCelebrationsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<GetCelebrationListing> localVarResponse = await GetEmployeeengagementCelebrationsAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all celebrations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (GetCelebrationListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GetCelebrationListing>> GetEmployeeengagementCelebrationsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/employeeengagement/celebrations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementCelebrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementCelebrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetCelebrationListing>(localVarStatusCode,
                localVarHeaders,
                (GetCelebrationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetCelebrationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets a single recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Recognition</returns>
        
        public Recognition GetEmployeeengagementRecognition (string recognitionId)
        {
             ApiResponse<Recognition> localVarResponse = GetEmployeeengagementRecognitionWithHttpInfo(recognitionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a single recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>ApiResponse of Recognition</returns>
        
        public ApiResponse< Recognition > GetEmployeeengagementRecognitionWithHttpInfo (string recognitionId)
        { 
            // verify the required parameter 'recognitionId' is set
            if (recognitionId == null)
                throw new ApiException(400, "Missing required parameter 'recognitionId' when calling EmployeeEngagementApi->GetEmployeeengagementRecognition");

            var localVarPath = "/api/v2/employeeengagement/recognitions/{recognitionId}";
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
            if (recognitionId != null) localVarPathParams.Add("recognitionId", this.Configuration.ApiClient.ParameterToString(recognitionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementRecognition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementRecognition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recognition>(localVarStatusCode,
                localVarHeaders,
                (Recognition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recognition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets a single recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Task of Recognition</returns>
        
        public async System.Threading.Tasks.Task<Recognition> GetEmployeeengagementRecognitionAsync (string recognitionId)
        {
             ApiResponse<Recognition> localVarResponse = await GetEmployeeengagementRecognitionAsyncWithHttpInfo(recognitionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a single recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognitionId">The Recognition ID</param>
        /// <returns>Task of ApiResponse (Recognition)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Recognition>> GetEmployeeengagementRecognitionAsyncWithHttpInfo (string recognitionId)
        { 
            // verify the required parameter 'recognitionId' is set
            if (recognitionId == null)
                throw new ApiException(400, "Missing required parameter 'recognitionId' when calling EmployeeEngagementApi->GetEmployeeengagementRecognition");
            

            var localVarPath = "/api/v2/employeeengagement/recognitions/{recognitionId}";
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
            if (recognitionId != null) localVarPathParams.Add("recognitionId", this.Configuration.ApiClient.ParameterToString(recognitionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementRecognition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmployeeengagementRecognition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recognition>(localVarStatusCode,
                localVarHeaders,
                (Recognition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recognition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set a state for a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns></returns>
        
        public void PatchEmployeeengagementCelebration (string celebrationId, CelebrationStateParam body)
        {
             PatchEmployeeengagementCelebrationWithHttpInfo(celebrationId, body);
        }

        /// <summary>
        /// Set a state for a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PatchEmployeeengagementCelebrationWithHttpInfo (string celebrationId, CelebrationStateParam body)
        { 
            // verify the required parameter 'celebrationId' is set
            if (celebrationId == null)
                throw new ApiException(400, "Missing required parameter 'celebrationId' when calling EmployeeEngagementApi->PatchEmployeeengagementCelebration");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmployeeEngagementApi->PatchEmployeeengagementCelebration");

            var localVarPath = "/api/v2/employeeengagement/celebrations/{celebrationId}";
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
            if (celebrationId != null) localVarPathParams.Add("celebrationId", this.Configuration.ApiClient.ParameterToString(celebrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmployeeengagementCelebration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmployeeengagementCelebration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set a state for a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PatchEmployeeengagementCelebrationAsync (string celebrationId, CelebrationStateParam body)
        {
             await PatchEmployeeengagementCelebrationAsyncWithHttpInfo(celebrationId, body);

        }

        /// <summary>
        /// Set a state for a celebration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="celebrationId">The ID of the celebration</param>
        /// <param name="body">Patch Celebration state</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmployeeengagementCelebrationAsyncWithHttpInfo (string celebrationId, CelebrationStateParam body)
        { 
            // verify the required parameter 'celebrationId' is set
            if (celebrationId == null)
                throw new ApiException(400, "Missing required parameter 'celebrationId' when calling EmployeeEngagementApi->PatchEmployeeengagementCelebration");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmployeeEngagementApi->PatchEmployeeengagementCelebration");
            

            var localVarPath = "/api/v2/employeeengagement/celebrations/{celebrationId}";
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
            if (celebrationId != null) localVarPathParams.Add("celebrationId", this.Configuration.ApiClient.ParameterToString(celebrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmployeeengagementCelebration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmployeeengagementCelebration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>RecognitionBase</returns>
        
        public RecognitionBase PostEmployeeengagementRecognitions (CreateRecognition body)
        {
             ApiResponse<RecognitionBase> localVarResponse = PostEmployeeengagementRecognitionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>ApiResponse of RecognitionBase</returns>
        
        public ApiResponse< RecognitionBase > PostEmployeeengagementRecognitionsWithHttpInfo (CreateRecognition body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmployeeEngagementApi->PostEmployeeengagementRecognitions");

            var localVarPath = "/api/v2/employeeengagement/recognitions";
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmployeeengagementRecognitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmployeeengagementRecognitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecognitionBase>(localVarStatusCode,
                localVarHeaders,
                (RecognitionBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecognitionBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>Task of RecognitionBase</returns>
        
        public async System.Threading.Tasks.Task<RecognitionBase> PostEmployeeengagementRecognitionsAsync (CreateRecognition body)
        {
             ApiResponse<RecognitionBase> localVarResponse = await PostEmployeeengagementRecognitionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a recognition 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Recognition</param>
        /// <returns>Task of ApiResponse (RecognitionBase)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<RecognitionBase>> PostEmployeeengagementRecognitionsAsyncWithHttpInfo (CreateRecognition body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmployeeEngagementApi->PostEmployeeengagementRecognitions");
            

            var localVarPath = "/api/v2/employeeengagement/recognitions";
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmployeeengagementRecognitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmployeeengagementRecognitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecognitionBase>(localVarStatusCode,
                localVarHeaders,
                (RecognitionBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecognitionBase)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
