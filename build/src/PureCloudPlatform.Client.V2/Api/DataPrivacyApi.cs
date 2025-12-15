using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDataPrivacyApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		/// Delete a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns></returns>

		void DeleteDataprivacyMaskingrule(string ruleId);

		/// <summary>
		/// Delete a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>ApiResponse of Object(void)</returns>

		ApiResponse<Object> DeleteDataprivacyMaskingruleWithHttpInfo(string ruleId);

		/// <summary>
		/// Fetch details about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>MaskingRule</returns>

		MaskingRule GetDataprivacyMaskingrule(string ruleId);

		/// <summary>
		/// Fetch details about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		ApiResponse<MaskingRule> GetDataprivacyMaskingruleWithHttpInfo(string ruleId);

		/// <summary>
		/// Retrieve the list of masking rules.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>MaskingRuleListing</returns>

		MaskingRuleListing GetDataprivacyMaskingrules();

		/// <summary>
		/// Retrieve the list of masking rules.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of MaskingRuleListing</returns>

		ApiResponse<MaskingRuleListing> GetDataprivacyMaskingrulesWithHttpInfo();

		/// <summary>
		/// Update information about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>MaskingRule</returns>

		MaskingRule PatchDataprivacyMaskingrule(string ruleId, MaskingRule body = null);

		/// <summary>
		/// Update information about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		ApiResponse<MaskingRule> PatchDataprivacyMaskingruleWithHttpInfo(string ruleId, MaskingRule body = null);

		/// <summary>
		/// Create a new masking rule resource.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>MaskingRule</returns>

		MaskingRule PostDataprivacyMaskingrules(MaskingRule body);

		/// <summary>
		/// Create a new masking rule resource.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		ApiResponse<MaskingRule> PostDataprivacyMaskingrulesWithHttpInfo(MaskingRule body);

		/// <summary>
		/// Validate masking before creating.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>MaskingRuleValidateResponse</returns>

		MaskingRuleValidateResponse PostDataprivacyMaskingrulesValidate(MaskingRuleValidateRequest body);

		/// <summary>
		/// Validate masking before creating.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>ApiResponse of MaskingRuleValidateResponse</returns>

		ApiResponse<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateWithHttpInfo(MaskingRuleValidateRequest body);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		/// Delete a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of void</returns>

		System.Threading.Tasks.Task DeleteDataprivacyMaskingruleAsync(string ruleId);

		/// <summary>
		/// Delete a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of ApiResponse</returns>

		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId);

		/// <summary>
		/// Fetch details about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of MaskingRule</returns>

		System.Threading.Tasks.Task<MaskingRule> GetDataprivacyMaskingruleAsync(string ruleId);

		/// <summary>
		/// Fetch details about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		System.Threading.Tasks.Task<ApiResponse<MaskingRule>> GetDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId);

		/// <summary>
		/// Retrieve the list of masking rules.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of MaskingRuleListing</returns>

		System.Threading.Tasks.Task<MaskingRuleListing> GetDataprivacyMaskingrulesAsync();

		/// <summary>
		/// Retrieve the list of masking rules.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (MaskingRuleListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<MaskingRuleListing>> GetDataprivacyMaskingrulesAsyncWithHttpInfo();

		/// <summary>
		/// Update information about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>Task of MaskingRule</returns>

		System.Threading.Tasks.Task<MaskingRule> PatchDataprivacyMaskingruleAsync(string ruleId, MaskingRule body = null);

		/// <summary>
		/// Update information about a masking rule.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		System.Threading.Tasks.Task<ApiResponse<MaskingRule>> PatchDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId, MaskingRule body = null);

		/// <summary>
		/// Create a new masking rule resource.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>Task of MaskingRule</returns>

		System.Threading.Tasks.Task<MaskingRule> PostDataprivacyMaskingrulesAsync(MaskingRule body);

		/// <summary>
		/// Create a new masking rule resource.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		System.Threading.Tasks.Task<ApiResponse<MaskingRule>> PostDataprivacyMaskingrulesAsyncWithHttpInfo(MaskingRule body);

		/// <summary>
		/// Validate masking before creating.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>Task of MaskingRuleValidateResponse</returns>

		System.Threading.Tasks.Task<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateAsync(MaskingRuleValidateRequest body);

		/// <summary>
		/// Validate masking before creating.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>Task of ApiResponse (MaskingRuleValidateResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<MaskingRuleValidateResponse>> PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(MaskingRuleValidateRequest body);

		#endregion Asynchronous Operations

	}

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public partial class DataPrivacyApi : IDataPrivacyApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataPrivacyApi"/> class.
		/// </summary>
		/// <returns></returns>
		public DataPrivacyApi(String basePath)
		{
			this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

			// ensure API client has configuration ready
			if (this.Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataPrivacyApi"/> class
		/// using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public DataPrivacyApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
		/// Delete a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns></returns>

		public void DeleteDataprivacyMaskingrule(string ruleId)
		{
			DeleteDataprivacyMaskingruleWithHttpInfo(ruleId);
		}

		/// <summary>
		/// Delete a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>ApiResponse of Object(void)</returns>

		public ApiResponse<Object> DeleteDataprivacyMaskingruleWithHttpInfo(string ruleId)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->DeleteDataprivacyMaskingrule");

			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
			var localVarHttpMethod = "Delete";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Delete a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of void</returns>

		public async System.Threading.Tasks.Task DeleteDataprivacyMaskingruleAsync(string ruleId)
		{
			await DeleteDataprivacyMaskingruleAsyncWithHttpInfo(ruleId);

		}

		/// <summary>
		/// Delete a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of ApiResponse</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->DeleteDataprivacyMaskingrule");


			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
			var localVarHttpMethod = "Delete";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Fetch details about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>MaskingRule</returns>

		public MaskingRule GetDataprivacyMaskingrule(string ruleId)
		{
			ApiResponse<MaskingRule> localVarResponse = GetDataprivacyMaskingruleWithHttpInfo(ruleId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Fetch details about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		public ApiResponse<MaskingRule> GetDataprivacyMaskingruleWithHttpInfo(string ruleId)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->GetDataprivacyMaskingrule");

			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Fetch details about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of MaskingRule</returns>

		public async System.Threading.Tasks.Task<MaskingRule> GetDataprivacyMaskingruleAsync(string ruleId)
		{
			ApiResponse<MaskingRule> localVarResponse = await GetDataprivacyMaskingruleAsyncWithHttpInfo(ruleId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Fetch details about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<MaskingRule>> GetDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->GetDataprivacyMaskingrule");


			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Retrieve the list of masking rules. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>MaskingRuleListing</returns>

		public MaskingRuleListing GetDataprivacyMaskingrules()
		{
			ApiResponse<MaskingRuleListing> localVarResponse = GetDataprivacyMaskingrulesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the list of masking rules. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of MaskingRuleListing</returns>

		public ApiResponse<MaskingRuleListing> GetDataprivacyMaskingrulesWithHttpInfo()
		{

			var localVarPath = "/dataprivacy/maskingrules";
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
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRuleListing>(localVarStatusCode,
				localVarHeaders,
				(MaskingRuleListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Retrieve the list of masking rules. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of MaskingRuleListing</returns>

		public async System.Threading.Tasks.Task<MaskingRuleListing> GetDataprivacyMaskingrulesAsync()
		{
			ApiResponse<MaskingRuleListing> localVarResponse = await GetDataprivacyMaskingrulesAsyncWithHttpInfo();
			return localVarResponse.Data;

		}

		/// <summary>
		/// Retrieve the list of masking rules. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (MaskingRuleListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<MaskingRuleListing>> GetDataprivacyMaskingrulesAsyncWithHttpInfo()
		{

			var localVarPath = "/dataprivacy/maskingrules";
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
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRuleListing>(localVarStatusCode,
				localVarHeaders,
				(MaskingRuleListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Update information about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>MaskingRule</returns>

		public MaskingRule PatchDataprivacyMaskingrule(string ruleId, MaskingRule body = null)
		{
			ApiResponse<MaskingRule> localVarResponse = PatchDataprivacyMaskingruleWithHttpInfo(ruleId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update information about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		public ApiResponse<MaskingRule> PatchDataprivacyMaskingruleWithHttpInfo(string ruleId, MaskingRule body = null)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->PatchDataprivacyMaskingrule");

			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Update information about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>Task of MaskingRule</returns>

		public async System.Threading.Tasks.Task<MaskingRule> PatchDataprivacyMaskingruleAsync(string ruleId, MaskingRule body = null)
		{
			ApiResponse<MaskingRule> localVarResponse = await PatchDataprivacyMaskingruleAsyncWithHttpInfo(ruleId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Update information about a masking rule. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ruleId">ruleId</param>
		/// <param name="body"> (optional)</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<MaskingRule>> PatchDataprivacyMaskingruleAsyncWithHttpInfo(string ruleId, MaskingRule body = null)
		{
			// verify the required parameter 'ruleId' is set
			if (ruleId == null)
				throw new ApiException(400, "Missing required parameter 'ruleId' when calling DataPrivacyApi->PatchDataprivacyMaskingrule");


			var localVarPath = "/dataprivacy/maskingrules/{ruleId}";
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
			if (ruleId != null) localVarPathParams.Add("ruleId", this.Configuration.ApiClient.ParameterToString(ruleId));

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
				throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchDataprivacyMaskingrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Create a new masking rule resource. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>MaskingRule</returns>

		public MaskingRule PostDataprivacyMaskingrules(MaskingRule body)
		{
			ApiResponse<MaskingRule> localVarResponse = PostDataprivacyMaskingrulesWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new masking rule resource. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>ApiResponse of MaskingRule</returns>

		public ApiResponse<MaskingRule> PostDataprivacyMaskingrulesWithHttpInfo(MaskingRule body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrules");

			var localVarPath = "/dataprivacy/maskingrules";
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
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Create a new masking rule resource. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>Task of MaskingRule</returns>

		public async System.Threading.Tasks.Task<MaskingRule> PostDataprivacyMaskingrulesAsync(MaskingRule body)
		{
			ApiResponse<MaskingRule> localVarResponse = await PostDataprivacyMaskingrulesAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Create a new masking rule resource. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Details for creating masking rule resource</param>
		/// <returns>Task of ApiResponse (MaskingRule)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<MaskingRule>> PostDataprivacyMaskingrulesAsyncWithHttpInfo(MaskingRule body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrules");


			var localVarPath = "/dataprivacy/maskingrules";
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
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRule>(localVarStatusCode,
				localVarHeaders,
				(MaskingRule)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRule)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Validate masking before creating. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>MaskingRuleValidateResponse</returns>

		public MaskingRuleValidateResponse PostDataprivacyMaskingrulesValidate(MaskingRuleValidateRequest body)
		{
			ApiResponse<MaskingRuleValidateResponse> localVarResponse = PostDataprivacyMaskingrulesValidateWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Validate masking before creating. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>ApiResponse of MaskingRuleValidateResponse</returns>

		public ApiResponse<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateWithHttpInfo(MaskingRuleValidateRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrulesValidate");

			var localVarPath = "/dataprivacy/maskingrules/validate";
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
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRuleValidateResponse>(localVarStatusCode,
				localVarHeaders,
				(MaskingRuleValidateResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleValidateResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Validate masking before creating. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>Task of MaskingRuleValidateResponse</returns>

		public async System.Threading.Tasks.Task<MaskingRuleValidateResponse> PostDataprivacyMaskingrulesValidateAsync(MaskingRuleValidateRequest body)
		{
			ApiResponse<MaskingRuleValidateResponse> localVarResponse = await PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Validate masking before creating. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Text to be masked</param>
		/// <returns>Task of ApiResponse (MaskingRuleValidateResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<MaskingRuleValidateResponse>> PostDataprivacyMaskingrulesValidateAsyncWithHttpInfo(MaskingRuleValidateRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling DataPrivacyApi->PostDataprivacyMaskingrulesValidate");


			var localVarPath = "/dataprivacy/maskingrules/validate";
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
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostDataprivacyMaskingrulesValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<MaskingRuleValidateResponse>(localVarStatusCode,
				localVarHeaders,
				(MaskingRuleValidateResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaskingRuleValidateResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



	}

}
