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
    public interface IInfrastructureAsCodeApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get job status and results
        /// </summary>
        /// <remarks>
        /// Get the execution status of a submitted job, optionally including results and error details.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>InfrastructureascodeJob</returns>
        InfrastructureascodeJob GetInfrastructureascodeJob (string jobId, bool? details = null);

        /// <summary>
        /// Get job status and results
        /// </summary>
        /// <remarks>
        /// Get the execution status of a submitted job, optionally including results and error details.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobWithHttpInfo (string jobId, bool? details = null);

        /// <summary>
        /// Get job history
        /// </summary>
        /// <remarks>
        /// Get a history of submitted jobs, optionally including error messages.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>InfrastructureascodeJob</returns>
        InfrastructureascodeJob GetInfrastructureascodeJobs (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get job history
        /// </summary>
        /// <remarks>
        /// Get a history of submitted jobs, optionally including error messages.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        ApiResponse<InfrastructureascodeJob> GetInfrastructureascodeJobsWithHttpInfo (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Create a Job
        /// </summary>
        /// <remarks>
        /// Create and submit a job for remote execution or see job planning results.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InfrastructureascodeJob</returns>
        InfrastructureascodeJob PostInfrastructureascodeJobs (AcceleratorInput body);

        /// <summary>
        /// Create a Job
        /// </summary>
        /// <remarks>
        /// Create and submit a job for remote execution or see job planning results.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        ApiResponse<InfrastructureascodeJob> PostInfrastructureascodeJobsWithHttpInfo (AcceleratorInput body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get job status and results
        /// </summary>
        /// <remarks>
        /// Get the execution status of a submitted job, optionally including results and error details.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        System.Threading.Tasks.Task<InfrastructureascodeJob> GetInfrastructureascodeJobAsync (string jobId, bool? details = null);

        /// <summary>
        /// Get job status and results
        /// </summary>
        /// <remarks>
        /// Get the execution status of a submitted job, optionally including results and error details.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobAsyncWithHttpInfo (string jobId, bool? details = null);

        /// <summary>
        /// Get job history
        /// </summary>
        /// <remarks>
        /// Get a history of submitted jobs, optionally including error messages.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        System.Threading.Tasks.Task<InfrastructureascodeJob> GetInfrastructureascodeJobsAsync (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get job history
        /// </summary>
        /// <remarks>
        /// Get a history of submitted jobs, optionally including error messages.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobsAsyncWithHttpInfo (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Create a Job
        /// </summary>
        /// <remarks>
        /// Create and submit a job for remote execution or see job planning results.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        System.Threading.Tasks.Task<InfrastructureascodeJob> PostInfrastructureascodeJobsAsync (AcceleratorInput body);

        /// <summary>
        /// Create a Job
        /// </summary>
        /// <remarks>
        /// Create and submit a job for remote execution or see job planning results.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> PostInfrastructureascodeJobsAsyncWithHttpInfo (AcceleratorInput body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InfrastructureAsCodeApi : IInfrastructureAsCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureAsCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InfrastructureAsCodeApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureAsCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InfrastructureAsCodeApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Get job status and results Get the execution status of a submitted job, optionally including results and error details.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>InfrastructureascodeJob</returns>
        public InfrastructureascodeJob GetInfrastructureascodeJob (string jobId, bool? details = null)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = GetInfrastructureascodeJobWithHttpInfo(jobId, details);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get job status and results Get the execution status of a submitted job, optionally including results and error details.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        public ApiResponse< InfrastructureascodeJob > GetInfrastructureascodeJobWithHttpInfo (string jobId, bool? details = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeJob");

            var localVarPath = "/api/v2/infrastructureascode/jobs/{jobId}";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
            if (details != null) localVarQueryParams.Add(new Tuple<string, string>("details", this.Configuration.ApiClient.ParameterToString(details)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get job status and results Get the execution status of a submitted job, optionally including results and error details.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        public async System.Threading.Tasks.Task<InfrastructureascodeJob> GetInfrastructureascodeJobAsync (string jobId, bool? details = null)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = await GetInfrastructureascodeJobAsyncWithHttpInfo(jobId, details);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get job status and results Get the execution status of a submitted job, optionally including results and error details.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <param name="details">Include details of execution, including job results or error information (optional, default to false)</param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobAsyncWithHttpInfo (string jobId, bool? details = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling InfrastructureAsCodeApi->GetInfrastructureascodeJob");
            

            var localVarPath = "/api/v2/infrastructureascode/jobs/{jobId}";
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
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
            if (details != null) localVarQueryParams.Add(new Tuple<string, string>("details", this.Configuration.ApiClient.ParameterToString(details)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get job history Get a history of submitted jobs, optionally including error messages.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>InfrastructureascodeJob</returns>
        public InfrastructureascodeJob GetInfrastructureascodeJobs (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = GetInfrastructureascodeJobsWithHttpInfo(maxResults, includeErrors, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get job history Get a history of submitted jobs, optionally including error messages.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        public ApiResponse< InfrastructureascodeJob > GetInfrastructureascodeJobsWithHttpInfo (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/infrastructureascode/jobs";
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
            if (maxResults != null) localVarQueryParams.Add(new Tuple<string, string>("maxResults", this.Configuration.ApiClient.ParameterToString(maxResults)));
            if (includeErrors != null) localVarQueryParams.Add(new Tuple<string, string>("includeErrors", this.Configuration.ApiClient.ParameterToString(includeErrors)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get job history Get a history of submitted jobs, optionally including error messages.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        public async System.Threading.Tasks.Task<InfrastructureascodeJob> GetInfrastructureascodeJobsAsync (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = await GetInfrastructureascodeJobsAsyncWithHttpInfo(maxResults, includeErrors, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get job history Get a history of submitted jobs, optionally including error messages.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maxResults">Number of jobs to show (optional, default to 1)</param>
        /// <param name="includeErrors">Include error messages (optional, default to false)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> GetInfrastructureascodeJobsAsyncWithHttpInfo (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/infrastructureascode/jobs";
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
            if (maxResults != null) localVarQueryParams.Add(new Tuple<string, string>("maxResults", this.Configuration.ApiClient.ParameterToString(maxResults)));
            if (includeErrors != null) localVarQueryParams.Add(new Tuple<string, string>("includeErrors", this.Configuration.ApiClient.ParameterToString(includeErrors)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Job Create and submit a job for remote execution or see job planning results.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InfrastructureascodeJob</returns>
        public InfrastructureascodeJob PostInfrastructureascodeJobs (AcceleratorInput body)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = PostInfrastructureascodeJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Job Create and submit a job for remote execution or see job planning results.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InfrastructureascodeJob</returns>
        public ApiResponse< InfrastructureascodeJob > PostInfrastructureascodeJobsWithHttpInfo (AcceleratorInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InfrastructureAsCodeApi->PostInfrastructureascodeJobs");

            var localVarPath = "/api/v2/infrastructureascode/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Job Create and submit a job for remote execution or see job planning results.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InfrastructureascodeJob</returns>
        public async System.Threading.Tasks.Task<InfrastructureascodeJob> PostInfrastructureascodeJobsAsync (AcceleratorInput body)
        {
             ApiResponse<InfrastructureascodeJob> localVarResponse = await PostInfrastructureascodeJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Job Create and submit a job for remote execution or see job planning results.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InfrastructureascodeJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InfrastructureascodeJob>> PostInfrastructureascodeJobsAsyncWithHttpInfo (AcceleratorInput body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InfrastructureAsCodeApi->PostInfrastructureascodeJobs");
            

            var localVarPath = "/api/v2/infrastructureascode/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostInfrastructureascodeJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InfrastructureascodeJob>(localVarStatusCode,
                localVarHeaders,
                (InfrastructureascodeJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InfrastructureascodeJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
