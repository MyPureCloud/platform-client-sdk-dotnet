using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IEventsApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		/// Publish Conversation Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		BatchEventResponse PostEventsConversations(BatchConversationEventRequest body);

		/// <summary>
		/// Publish Conversation Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		ApiResponse<BatchEventResponse> PostEventsConversationsWithHttpInfo(BatchConversationEventRequest body);

		/// <summary>
		/// Publish User Presence Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		BatchEventResponse PostEventsUsersPresence(BatchUserPresenceEventRequest body);

		/// <summary>
		/// Publish User Presence Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		ApiResponse<BatchEventResponse> PostEventsUsersPresenceWithHttpInfo(BatchUserPresenceEventRequest body);

		/// <summary>
		/// Publish Agent Routing Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		BatchEventResponse PostEventsUsersRoutingstatus(BatchUserRoutingStatusEventRequest body);

		/// <summary>
		/// Publish Agent Routing Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		ApiResponse<BatchEventResponse> PostEventsUsersRoutingstatusWithHttpInfo(BatchUserRoutingStatusEventRequest body);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		/// Publish Conversation Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		System.Threading.Tasks.Task<BatchEventResponse> PostEventsConversationsAsync(BatchConversationEventRequest body);

		/// <summary>
		/// Publish Conversation Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsConversationsAsyncWithHttpInfo(BatchConversationEventRequest body);

		/// <summary>
		/// Publish User Presence Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		System.Threading.Tasks.Task<BatchEventResponse> PostEventsUsersPresenceAsync(BatchUserPresenceEventRequest body);

		/// <summary>
		/// Publish User Presence Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsUsersPresenceAsyncWithHttpInfo(BatchUserPresenceEventRequest body);

		/// <summary>
		/// Publish Agent Routing Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		System.Threading.Tasks.Task<BatchEventResponse> PostEventsUsersRoutingstatusAsync(BatchUserRoutingStatusEventRequest body);

		/// <summary>
		/// Publish Agent Routing Status Batch Events
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsUsersRoutingstatusAsyncWithHttpInfo(BatchUserRoutingStatusEventRequest body);

		#endregion Asynchronous Operations

	}

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public partial class EventsApi : IEventsApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EventsApi"/> class.
		/// </summary>
		/// <returns></returns>
		public EventsApi(String basePath)
		{
			this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

			// ensure API client has configuration ready
			if (this.Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EventsApi"/> class
		/// using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public EventsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
		public PureCloudPlatform.Client.V2.Client.Configuration Configuration { get; set; }

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
		/// Publish Conversation Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		public BatchEventResponse PostEventsConversations(BatchConversationEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = PostEventsConversationsWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Publish Conversation Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		public ApiResponse<BatchEventResponse> PostEventsConversationsWithHttpInfo(BatchConversationEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsConversations");

			var localVarPath = "/events/conversations";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Publish Conversation Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		public async System.Threading.Tasks.Task<BatchEventResponse> PostEventsConversationsAsync(BatchConversationEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = await PostEventsConversationsAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Publish Conversation Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsConversationsAsyncWithHttpInfo(BatchConversationEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsConversations");


			var localVarPath = "/events/conversations";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Publish User Presence Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		public BatchEventResponse PostEventsUsersPresence(BatchUserPresenceEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = PostEventsUsersPresenceWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Publish User Presence Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		public ApiResponse<BatchEventResponse> PostEventsUsersPresenceWithHttpInfo(BatchUserPresenceEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsUsersPresence");

			var localVarPath = "/events/users/presence";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Publish User Presence Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		public async System.Threading.Tasks.Task<BatchEventResponse> PostEventsUsersPresenceAsync(BatchUserPresenceEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = await PostEventsUsersPresenceAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Publish User Presence Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsUsersPresenceAsyncWithHttpInfo(BatchUserPresenceEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsUsersPresence");


			var localVarPath = "/events/users/presence";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersPresence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Publish Agent Routing Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>BatchEventResponse</returns>

		public BatchEventResponse PostEventsUsersRoutingstatus(BatchUserRoutingStatusEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = PostEventsUsersRoutingstatusWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Publish Agent Routing Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>ApiResponse of BatchEventResponse</returns>

		public ApiResponse<BatchEventResponse> PostEventsUsersRoutingstatusWithHttpInfo(BatchUserRoutingStatusEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsUsersRoutingstatus");

			var localVarPath = "/events/users/routingstatus";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Publish Agent Routing Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of BatchEventResponse</returns>

		public async System.Threading.Tasks.Task<BatchEventResponse> PostEventsUsersRoutingstatusAsync(BatchUserRoutingStatusEventRequest body)
		{
			ApiResponse<BatchEventResponse> localVarResponse = await PostEventsUsersRoutingstatusAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Publish Agent Routing Status Batch Events 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">batchRequest</param>
		/// <returns>Task of ApiResponse (BatchEventResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BatchEventResponse>> PostEventsUsersRoutingstatusAsyncWithHttpInfo(BatchUserRoutingStatusEventRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->PostEventsUsersRoutingstatus");


			var localVarPath = "/events/users/routingstatus";
			var localVarHttpMethod = "Post";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new List<Tuple<String, String>>();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, IFileParameter>();
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
			IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersRoutingstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostEventsUsersRoutingstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BatchEventResponse>(localVarStatusCode,
				localVarHeaders,
				(BatchEventResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchEventResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



	}

}
