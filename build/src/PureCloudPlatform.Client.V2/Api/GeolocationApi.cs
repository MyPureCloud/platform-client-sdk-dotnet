using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IGeolocationApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>GeolocationSettings</returns>

		GeolocationSettings GetGeolocationsSettings();

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of GeolocationSettings</returns>

		ApiResponse<GeolocationSettings> GetGeolocationsSettingsWithHttpInfo();

		/// <summary>
		/// Get a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Geolocation</returns>

		Geolocation GetUserGeolocation(string userId, string clientId);

		/// <summary>
		/// Get a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>ApiResponse of Geolocation</returns>

		ApiResponse<Geolocation> GetUserGeolocationWithHttpInfo(string userId, string clientId);

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>GeolocationSettings</returns>

		GeolocationSettings PatchGeolocationsSettings(GeolocationSettings body);

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>ApiResponse of GeolocationSettings</returns>

		ApiResponse<GeolocationSettings> PatchGeolocationsSettingsWithHttpInfo(GeolocationSettings body);

		/// <summary>
		/// Patch a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Geolocation</returns>

		Geolocation PatchUserGeolocation(string userId, string clientId, Geolocation body);

		/// <summary>
		/// Patch a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>ApiResponse of Geolocation</returns>

		ApiResponse<Geolocation> PatchUserGeolocationWithHttpInfo(string userId, string clientId, Geolocation body);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GeolocationSettings</returns>

		System.Threading.Tasks.Task<GeolocationSettings> GetGeolocationsSettingsAsync();

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (GeolocationSettings)</returns>

		System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> GetGeolocationsSettingsAsyncWithHttpInfo();

		/// <summary>
		/// Get a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Task of Geolocation</returns>

		System.Threading.Tasks.Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId);

		/// <summary>
		/// Get a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Task of ApiResponse (Geolocation)</returns>

		System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserGeolocationAsyncWithHttpInfo(string userId, string clientId);

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>Task of GeolocationSettings</returns>

		System.Threading.Tasks.Task<GeolocationSettings> PatchGeolocationsSettingsAsync(GeolocationSettings body);

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>Task of ApiResponse (GeolocationSettings)</returns>

		System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> PatchGeolocationsSettingsAsyncWithHttpInfo(GeolocationSettings body);

		/// <summary>
		/// Patch a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Task of Geolocation</returns>

		System.Threading.Tasks.Task<Geolocation> PatchUserGeolocationAsync(string userId, string clientId, Geolocation body);

		/// <summary>
		/// Patch a user&#39;s Geolocation
		/// </summary>
		/// <remarks>
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Task of ApiResponse (Geolocation)</returns>

		System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserGeolocationAsyncWithHttpInfo(string userId, string clientId, Geolocation body);

		#endregion Asynchronous Operations

	}

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public partial class GeolocationApi : IGeolocationApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GeolocationApi"/> class.
		/// </summary>
		/// <returns></returns>
		public GeolocationApi(String basePath)
		{
			this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

			// ensure API client has configuration ready
			if (this.Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GeolocationApi"/> class
		/// using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public GeolocationApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
		/// Get a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>GeolocationSettings</returns>

		public GeolocationSettings GetGeolocationsSettings()
		{
			ApiResponse<GeolocationSettings> localVarResponse = GetGeolocationsSettingsWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of GeolocationSettings</returns>

		public ApiResponse<GeolocationSettings> GetGeolocationsSettingsWithHttpInfo()
		{

			var localVarPath = "/geolocations/settings";
			var localVarHttpMethod = "Get";
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
				throw new ApiException(localVarStatusCode, "Error calling GetGeolocationsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetGeolocationsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<GeolocationSettings>(localVarStatusCode,
				localVarHeaders,
				(GeolocationSettings)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocationSettings)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GeolocationSettings</returns>

		public async System.Threading.Tasks.Task<GeolocationSettings> GetGeolocationsSettingsAsync()
		{
			ApiResponse<GeolocationSettings> localVarResponse = await GetGeolocationsSettingsAsyncWithHttpInfo();
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (GeolocationSettings)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> GetGeolocationsSettingsAsyncWithHttpInfo()
		{

			var localVarPath = "/geolocations/settings";
			var localVarHttpMethod = "Get";
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
				throw new ApiException(localVarStatusCode, "Error calling GetGeolocationsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetGeolocationsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<GeolocationSettings>(localVarStatusCode,
				localVarHeaders,
				(GeolocationSettings)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocationSettings)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a user&#39;s Geolocation 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Geolocation</returns>

		public Geolocation GetUserGeolocation(string userId, string clientId)
		{
			ApiResponse<Geolocation> localVarResponse = GetUserGeolocationWithHttpInfo(userId, clientId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a user&#39;s Geolocation 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>ApiResponse of Geolocation</returns>

		public ApiResponse<Geolocation> GetUserGeolocationWithHttpInfo(string userId, string clientId)
		{
			// verify the required parameter 'userId' is set
			if (userId == null)
				throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->GetUserGeolocation");
			// verify the required parameter 'clientId' is set
			if (clientId == null)
				throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->GetUserGeolocation");

			var localVarPath = "/users/{userId}/geolocations/{clientId}";
			var localVarHttpMethod = "Get";
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
			if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
			if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
			IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Geolocation>(localVarStatusCode,
				localVarHeaders,
				(Geolocation)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a user&#39;s Geolocation 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Task of Geolocation</returns>

		public async System.Threading.Tasks.Task<Geolocation> GetUserGeolocationAsync(string userId, string clientId)
		{
			ApiResponse<Geolocation> localVarResponse = await GetUserGeolocationAsyncWithHttpInfo(userId, clientId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a user&#39;s Geolocation 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <returns>Task of ApiResponse (Geolocation)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserGeolocationAsyncWithHttpInfo(string userId, string clientId)
		{
			// verify the required parameter 'userId' is set
			if (userId == null)
				throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->GetUserGeolocation");

			// verify the required parameter 'clientId' is set
			if (clientId == null)
				throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->GetUserGeolocation");


			var localVarPath = "/users/{userId}/geolocations/{clientId}";
			var localVarHttpMethod = "Get";
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
			if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
			if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
			IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Geolocation>(localVarStatusCode,
				localVarHeaders,
				(Geolocation)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>GeolocationSettings</returns>

		public GeolocationSettings PatchGeolocationsSettings(GeolocationSettings body)
		{
			ApiResponse<GeolocationSettings> localVarResponse = PatchGeolocationsSettingsWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>ApiResponse of GeolocationSettings</returns>

		public ApiResponse<GeolocationSettings> PatchGeolocationsSettingsWithHttpInfo(GeolocationSettings body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling GeolocationApi->PatchGeolocationsSettings");

			var localVarPath = "/geolocations/settings";
			var localVarHttpMethod = "Patch";
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
				throw new ApiException(localVarStatusCode, "Error calling PatchGeolocationsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchGeolocationsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<GeolocationSettings>(localVarStatusCode,
				localVarHeaders,
				(GeolocationSettings)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocationSettings)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>Task of GeolocationSettings</returns>

		public async System.Threading.Tasks.Task<GeolocationSettings> PatchGeolocationsSettingsAsync(GeolocationSettings body)
		{
			ApiResponse<GeolocationSettings> localVarResponse = await PatchGeolocationsSettingsAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Patch a organization&#39;s GeolocationSettings 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Geolocation settings</param>
		/// <returns>Task of ApiResponse (GeolocationSettings)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> PatchGeolocationsSettingsAsyncWithHttpInfo(GeolocationSettings body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling GeolocationApi->PatchGeolocationsSettings");


			var localVarPath = "/geolocations/settings";
			var localVarHttpMethod = "Patch";
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
				throw new ApiException(localVarStatusCode, "Error calling PatchGeolocationsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchGeolocationsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<GeolocationSettings>(localVarStatusCode,
				localVarHeaders,
				(GeolocationSettings)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocationSettings)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Patch a user&#39;s Geolocation 
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Geolocation</returns>

		public Geolocation PatchUserGeolocation(string userId, string clientId, Geolocation body)
		{
			ApiResponse<Geolocation> localVarResponse = PatchUserGeolocationWithHttpInfo(userId, clientId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Patch a user&#39;s Geolocation 
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>ApiResponse of Geolocation</returns>

		public ApiResponse<Geolocation> PatchUserGeolocationWithHttpInfo(string userId, string clientId, Geolocation body)
		{
			// verify the required parameter 'userId' is set
			if (userId == null)
				throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->PatchUserGeolocation");
			// verify the required parameter 'clientId' is set
			if (clientId == null)
				throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->PatchUserGeolocation");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling GeolocationApi->PatchUserGeolocation");

			var localVarPath = "/users/{userId}/geolocations/{clientId}";
			var localVarHttpMethod = "Patch";
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
			if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
			if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
				throw new ApiException(localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Geolocation>(localVarStatusCode,
				localVarHeaders,
				(Geolocation)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Patch a user&#39;s Geolocation 
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Task of Geolocation</returns>

		public async System.Threading.Tasks.Task<Geolocation> PatchUserGeolocationAsync(string userId, string clientId, Geolocation body)
		{
			ApiResponse<Geolocation> localVarResponse = await PatchUserGeolocationAsyncWithHttpInfo(userId, clientId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Patch a user&#39;s Geolocation 
		/// The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="userId">user Id</param>
		/// <param name="clientId">client Id</param>
		/// <param name="body">Geolocation</param>
		/// <returns>Task of ApiResponse (Geolocation)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserGeolocationAsyncWithHttpInfo(string userId, string clientId, Geolocation body)
		{
			// verify the required parameter 'userId' is set
			if (userId == null)
				throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->PatchUserGeolocation");

			// verify the required parameter 'clientId' is set
			if (clientId == null)
				throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->PatchUserGeolocation");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling GeolocationApi->PatchUserGeolocation");


			var localVarPath = "/users/{userId}/geolocations/{clientId}";
			var localVarHttpMethod = "Patch";
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
			if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
			if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
				throw new ApiException(localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchUserGeolocation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Geolocation>(localVarStatusCode,
				localVarHeaders,
				(Geolocation)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



	}

}
