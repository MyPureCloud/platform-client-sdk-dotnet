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
    public interface ITelephonyApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MediaRegions</returns>
        
        MediaRegions GetTelephonyMediaregions ();

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MediaRegions</returns>
        
        ApiResponse<MediaRegions> GetTelephonyMediaregionsWithHttpInfo ();

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>SipSearchResult</returns>
        
        SipSearchResult GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>ApiResponse of SipSearchResult</returns>
        
        ApiResponse<SipSearchResult> GetTelephonySiptracesWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>SignedUrlResponse</returns>
        
        SignedUrlResponse GetTelephonySiptracesDownloadDownloadId (string downloadId);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>ApiResponse of SignedUrlResponse</returns>
        
        ApiResponse<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdWithHttpInfo (string downloadId);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>SipDownloadResponse</returns>
        
        SipDownloadResponse PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>ApiResponse of SipDownloadResponse</returns>
        
        ApiResponse<SipDownloadResponse> PostTelephonySiptracesDownloadWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MediaRegions</returns>
        
        System.Threading.Tasks.Task<MediaRegions> GetTelephonyMediaregionsAsync ();

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MediaRegions)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<MediaRegions>> GetTelephonyMediaregionsAsyncWithHttpInfo ();

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of SipSearchResult</returns>
        
        System.Threading.Tasks.Task<SipSearchResult> GetTelephonySiptracesAsync (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Fetch SIP metadata
        /// </summary>
        /// <remarks>
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of ApiResponse (SipSearchResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SipSearchResult>> GetTelephonySiptracesAsyncWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of SignedUrlResponse</returns>
        
        System.Threading.Tasks.Task<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdAsync (string downloadId);

        /// <summary>
        /// Get signed S3 URL for a pcap download
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of ApiResponse (SignedUrlResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SignedUrlResponse>> GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo (string downloadId);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of SipDownloadResponse</returns>
        
        System.Threading.Tasks.Task<SipDownloadResponse> PostTelephonySiptracesDownloadAsync (SIPSearchPublicRequest sIPSearchPublicRequest);

        /// <summary>
        /// Request a download of a pcap file to S3
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of ApiResponse (SipDownloadResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SipDownloadResponse>> PostTelephonySiptracesDownloadAsyncWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TelephonyApi : ITelephonyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelephonyApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelephonyApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MediaRegions</returns>
        
        public MediaRegions GetTelephonyMediaregions ()
        {
             ApiResponse<MediaRegions> localVarResponse = GetTelephonyMediaregionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MediaRegions</returns>
        
        public ApiResponse< MediaRegions > GetTelephonyMediaregionsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/mediaregions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MediaRegions>(localVarStatusCode,
                localVarHeaders,
                (MediaRegions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaRegions)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MediaRegions</returns>
        
        public async System.Threading.Tasks.Task<MediaRegions> GetTelephonyMediaregionsAsync ()
        {
             ApiResponse<MediaRegions> localVarResponse = await GetTelephonyMediaregionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the list of AWS regions media can stream through. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MediaRegions)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<MediaRegions>> GetTelephonyMediaregionsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/telephony/mediaregions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonyMediaregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MediaRegions>(localVarStatusCode,
                localVarHeaders,
                (MediaRegions) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaRegions)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>SipSearchResult</returns>
        
        public SipSearchResult GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        {
             ApiResponse<SipSearchResult> localVarResponse = GetTelephonySiptracesWithHttpInfo(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>ApiResponse of SipSearchResult</returns>
        
        public ApiResponse< SipSearchResult > GetTelephonySiptracesWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        { 
            // verify the required parameter 'dateStart' is set
            if (dateStart == null)
                throw new ApiException(400, "Missing required parameter 'dateStart' when calling TelephonyApi->GetTelephonySiptraces");
            // verify the required parameter 'dateEnd' is set
            if (dateEnd == null)
                throw new ApiException(400, "Missing required parameter 'dateEnd' when calling TelephonyApi->GetTelephonySiptraces");

            var localVarPath = "/api/v2/telephony/siptraces";
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
            if (callId != null) localVarQueryParams.Add(new Tuple<string, string>("callId", this.Configuration.ApiClient.ParameterToString(callId)));
            if (toUser != null) localVarQueryParams.Add(new Tuple<string, string>("toUser", this.Configuration.ApiClient.ParameterToString(toUser)));
            if (fromUser != null) localVarQueryParams.Add(new Tuple<string, string>("fromUser", this.Configuration.ApiClient.ParameterToString(fromUser)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipSearchResult>(localVarStatusCode,
                localVarHeaders,
                (SipSearchResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipSearchResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of SipSearchResult</returns>
        
        public async System.Threading.Tasks.Task<SipSearchResult> GetTelephonySiptracesAsync (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        {
             ApiResponse<SipSearchResult> localVarResponse = await GetTelephonySiptracesAsyncWithHttpInfo(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch SIP metadata 
        /// Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="dateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</param>
        /// <param name="callId">unique identification of the placed call (optional)</param>
        /// <param name="toUser">User to who the call was placed (optional)</param>
        /// <param name="fromUser">user who placed the call (optional)</param>
        /// <param name="conversationId">Unique identification of the conversation (optional)</param>
        /// <returns>Task of ApiResponse (SipSearchResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SipSearchResult>> GetTelephonySiptracesAsyncWithHttpInfo (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)
        { 
            // verify the required parameter 'dateStart' is set
            if (dateStart == null)
                throw new ApiException(400, "Missing required parameter 'dateStart' when calling TelephonyApi->GetTelephonySiptraces");
            
            // verify the required parameter 'dateEnd' is set
            if (dateEnd == null)
                throw new ApiException(400, "Missing required parameter 'dateEnd' when calling TelephonyApi->GetTelephonySiptraces");
            

            var localVarPath = "/api/v2/telephony/siptraces";
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
            if (callId != null) localVarQueryParams.Add(new Tuple<string, string>("callId", this.Configuration.ApiClient.ParameterToString(callId)));
            if (toUser != null) localVarQueryParams.Add(new Tuple<string, string>("toUser", this.Configuration.ApiClient.ParameterToString(toUser)));
            if (fromUser != null) localVarQueryParams.Add(new Tuple<string, string>("fromUser", this.Configuration.ApiClient.ParameterToString(fromUser)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (dateStart != null) localVarQueryParams.Add(new Tuple<string, string>("dateStart", this.Configuration.ApiClient.ParameterToString(dateStart)));
            if (dateEnd != null) localVarQueryParams.Add(new Tuple<string, string>("dateEnd", this.Configuration.ApiClient.ParameterToString(dateEnd)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptraces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipSearchResult>(localVarStatusCode,
                localVarHeaders,
                (SipSearchResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipSearchResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>SignedUrlResponse</returns>
        
        public SignedUrlResponse GetTelephonySiptracesDownloadDownloadId (string downloadId)
        {
             ApiResponse<SignedUrlResponse> localVarResponse = GetTelephonySiptracesDownloadDownloadIdWithHttpInfo(downloadId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>ApiResponse of SignedUrlResponse</returns>
        
        public ApiResponse< SignedUrlResponse > GetTelephonySiptracesDownloadDownloadIdWithHttpInfo (string downloadId)
        { 
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling TelephonyApi->GetTelephonySiptracesDownloadDownloadId");

            var localVarPath = "/api/v2/telephony/siptraces/download/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", this.Configuration.ApiClient.ParameterToString(downloadId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (SignedUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of SignedUrlResponse</returns>
        
        public async System.Threading.Tasks.Task<SignedUrlResponse> GetTelephonySiptracesDownloadDownloadIdAsync (string downloadId)
        {
             ApiResponse<SignedUrlResponse> localVarResponse = await GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo(downloadId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get signed S3 URL for a pcap download 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">unique id for the downloaded file in S3</param>
        /// <returns>Task of ApiResponse (SignedUrlResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SignedUrlResponse>> GetTelephonySiptracesDownloadDownloadIdAsyncWithHttpInfo (string downloadId)
        { 
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling TelephonyApi->GetTelephonySiptracesDownloadDownloadId");
            

            var localVarPath = "/api/v2/telephony/siptraces/download/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", this.Configuration.ApiClient.ParameterToString(downloadId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTelephonySiptracesDownloadDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignedUrlResponse>(localVarStatusCode,
                localVarHeaders,
                (SignedUrlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignedUrlResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>SipDownloadResponse</returns>
        
        public SipDownloadResponse PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest)
        {
             ApiResponse<SipDownloadResponse> localVarResponse = PostTelephonySiptracesDownloadWithHttpInfo(sIPSearchPublicRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>ApiResponse of SipDownloadResponse</returns>
        
        public ApiResponse< SipDownloadResponse > PostTelephonySiptracesDownloadWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest)
        { 
            // verify the required parameter 'sIPSearchPublicRequest' is set
            if (sIPSearchPublicRequest == null)
                throw new ApiException(400, "Missing required parameter 'sIPSearchPublicRequest' when calling TelephonyApi->PostTelephonySiptracesDownload");

            var localVarPath = "/api/v2/telephony/siptraces/download";
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
            if (sIPSearchPublicRequest != null && sIPSearchPublicRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(sIPSearchPublicRequest); // http body (model) parameter
            else
                localVarPostBody = sIPSearchPublicRequest; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipDownloadResponse>(localVarStatusCode,
                localVarHeaders,
                (SipDownloadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipDownloadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of SipDownloadResponse</returns>
        
        public async System.Threading.Tasks.Task<SipDownloadResponse> PostTelephonySiptracesDownloadAsync (SIPSearchPublicRequest sIPSearchPublicRequest)
        {
             ApiResponse<SipDownloadResponse> localVarResponse = await PostTelephonySiptracesDownloadAsyncWithHttpInfo(sIPSearchPublicRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request a download of a pcap file to S3 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sIPSearchPublicRequest"></param>
        /// <returns>Task of ApiResponse (SipDownloadResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SipDownloadResponse>> PostTelephonySiptracesDownloadAsyncWithHttpInfo (SIPSearchPublicRequest sIPSearchPublicRequest)
        { 
            // verify the required parameter 'sIPSearchPublicRequest' is set
            if (sIPSearchPublicRequest == null)
                throw new ApiException(400, "Missing required parameter 'sIPSearchPublicRequest' when calling TelephonyApi->PostTelephonySiptracesDownload");
            

            var localVarPath = "/api/v2/telephony/siptraces/download";
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
            if (sIPSearchPublicRequest != null && sIPSearchPublicRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(sIPSearchPublicRequest); // http body (model) parameter
            else
                localVarPostBody = sIPSearchPublicRequest; // byte array



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
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTelephonySiptracesDownload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SipDownloadResponse>(localVarStatusCode,
                localVarHeaders,
                (SipDownloadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SipDownloadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
