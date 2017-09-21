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
    public interface IBillingApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>BillingUsageReport</returns>
        BillingUsageReport GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>ApiResponse of BillingUsageReport</returns>
        ApiResponse<BillingUsageReport> GetBillingReportsBillableusageWithHttpInfo (DateTime? startDate, DateTime? endDate);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>Task of BillingUsageReport</returns>
        System.Threading.Tasks.Task<BillingUsageReport> GetBillingReportsBillableusageAsync (DateTime? startDate, DateTime? endDate);

        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>Task of ApiResponse (BillingUsageReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BillingApi : IBillingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
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
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>BillingUsageReport</returns>
        public BillingUsageReport GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate)
        {
             ApiResponse<BillingUsageReport> localVarResponse = GetBillingReportsBillableusageWithHttpInfo(startDate, endDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>ApiResponse of BillingUsageReport</returns>
        public ApiResponse< BillingUsageReport > GetBillingReportsBillableusageWithHttpInfo (DateTime? startDate, DateTime? endDate)
        { 
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");

            var localVarPath = "/api/v2/billing/reports/billableusage";
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startDate != null) localVarQueryParams.Add(new Tuple<string, string>("startDate", Configuration.ApiClient.ParameterToString(startDate)));
            if (endDate != null) localVarQueryParams.Add(new Tuple<string, string>("endDate", Configuration.ApiClient.ParameterToString(endDate)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingUsageReport>(localVarStatusCode,
                localVarHeaders,
                (BillingUsageReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)));
            
        }

        
        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>Task of BillingUsageReport</returns>
        public async System.Threading.Tasks.Task<BillingUsageReport> GetBillingReportsBillableusageAsync (DateTime? startDate, DateTime? endDate)
        {
             ApiResponse<BillingUsageReport> localVarResponse = await GetBillingReportsBillableusageAsyncWithHttpInfo(startDate, endDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endDate">The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <returns>Task of ApiResponse (BillingUsageReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingUsageReport>> GetBillingReportsBillableusageAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate)
        { 
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BillingApi->GetBillingReportsBillableusage");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling BillingApi->GetBillingReportsBillableusage");
            

            var localVarPath = "/api/v2/billing/reports/billableusage";
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startDate != null) localVarQueryParams.Add(new Tuple<string, string>("startDate", Configuration.ApiClient.ParameterToString(startDate)));
            if (endDate != null) localVarQueryParams.Add(new Tuple<string, string>("endDate", Configuration.ApiClient.ParameterToString(endDate)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingReportsBillableusage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingUsageReport>(localVarStatusCode,
                localVarHeaders,
                (BillingUsageReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingUsageReport)));
            
        }

        
        
    }
    
}
