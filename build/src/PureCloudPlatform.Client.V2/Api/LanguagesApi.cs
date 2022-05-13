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
    public interface ILanguagesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns></returns>
        void DeleteLanguage (string languageId);

        /// <summary>
        /// Delete Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLanguageWithHttpInfo (string languageId);

        /// <summary>
        /// Delete Language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns></returns>
        void DeleteRoutingLanguage (string languageId);

        /// <summary>
        /// Delete Language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRoutingLanguageWithHttpInfo (string languageId);

        /// <summary>
        /// Get language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Language</returns>
        Language GetLanguage (string languageId);

        /// <summary>
        /// Get language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Language</returns>
        ApiResponse<Language> GetLanguageWithHttpInfo (string languageId);

        /// <summary>
        /// Get the list of supported languages. (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>LanguageEntityListing</returns>
        LanguageEntityListing GetLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get the list of supported languages. (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of LanguageEntityListing</returns>
        ApiResponse<LanguageEntityListing> GetLanguagesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get all available languages for translation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AvailableTranslations</returns>
        AvailableTranslations GetLanguagesTranslations ();

        /// <summary>
        /// Get all available languages for translation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AvailableTranslations</returns>
        ApiResponse<AvailableTranslations> GetLanguagesTranslationsWithHttpInfo ();

        /// <summary>
        /// Get the builtin translation for a language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetLanguagesTranslationsBuiltin (string language);

        /// <summary>
        /// Get the builtin translation for a language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> GetLanguagesTranslationsBuiltinWithHttpInfo (string language);

        /// <summary>
        /// Get effective translation for an organization by language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetLanguagesTranslationsOrganization (string language);

        /// <summary>
        /// Get effective translation for an organization by language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> GetLanguagesTranslationsOrganizationWithHttpInfo (string language);

        /// <summary>
        /// Get effective language translation for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetLanguagesTranslationsUser (string userId);

        /// <summary>
        /// Get effective language translation for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> GetLanguagesTranslationsUserWithHttpInfo (string userId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Language</returns>
        Language GetRoutingLanguage (string languageId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Language</returns>
        ApiResponse<Language> GetRoutingLanguageWithHttpInfo (string languageId);

        /// <summary>
        /// Create Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Language</returns>
        Language PostLanguages (Language body);

        /// <summary>
        /// Create Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>ApiResponse of Language</returns>
        ApiResponse<Language> PostLanguagesWithHttpInfo (Language body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLanguageAsync (string languageId);

        /// <summary>
        /// Delete Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageAsyncWithHttpInfo (string languageId);

        /// <summary>
        /// Delete Language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRoutingLanguageAsync (string languageId);

        /// <summary>
        /// Delete Language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoutingLanguageAsyncWithHttpInfo (string languageId);

        /// <summary>
        /// Get language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        System.Threading.Tasks.Task<Language> GetLanguageAsync (string languageId);

        /// <summary>
        /// Get language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        System.Threading.Tasks.Task<ApiResponse<Language>> GetLanguageAsyncWithHttpInfo (string languageId);

        /// <summary>
        /// Get the list of supported languages. (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of LanguageEntityListing</returns>
        System.Threading.Tasks.Task<LanguageEntityListing> GetLanguagesAsync (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get the list of supported languages. (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanguageEntityListing>> GetLanguagesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get all available languages for translation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AvailableTranslations</returns>
        System.Threading.Tasks.Task<AvailableTranslations> GetLanguagesTranslationsAsync ();

        /// <summary>
        /// Get all available languages for translation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AvailableTranslations)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailableTranslations>> GetLanguagesTranslationsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the builtin translation for a language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsBuiltinAsync (string language);

        /// <summary>
        /// Get the builtin translation for a language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsBuiltinAsyncWithHttpInfo (string language);

        /// <summary>
        /// Get effective translation for an organization by language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsOrganizationAsync (string language);

        /// <summary>
        /// Get effective translation for an organization by language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsOrganizationAsyncWithHttpInfo (string language);

        /// <summary>
        /// Get effective language translation for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsUserAsync (string userId);

        /// <summary>
        /// Get effective language translation for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsUserAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        System.Threading.Tasks.Task<Language> GetRoutingLanguageAsync (string languageId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        System.Threading.Tasks.Task<ApiResponse<Language>> GetRoutingLanguageAsyncWithHttpInfo (string languageId);

        /// <summary>
        /// Create Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Task of Language</returns>
        System.Threading.Tasks.Task<Language> PostLanguagesAsync (Language body);

        /// <summary>
        /// Create Language (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. It has been moved to /routing/languages
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        System.Threading.Tasks.Task<ApiResponse<Language>> PostLanguagesAsyncWithHttpInfo (Language body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LanguagesApi : ILanguagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanguagesApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguagesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns></returns>
        public void DeleteLanguage (string languageId)
        {
             DeleteLanguageWithHttpInfo(languageId);
        }

        /// <summary>
        /// Delete Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLanguageWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteLanguage");

            var localVarPath = "/api/v2/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLanguageAsync (string languageId)
        {
             await DeleteLanguageAsyncWithHttpInfo(languageId);

        }

        /// <summary>
        /// Delete Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLanguageAsyncWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteLanguage");
            

            var localVarPath = "/api/v2/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete Language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns></returns>
        public void DeleteRoutingLanguage (string languageId)
        {
             DeleteRoutingLanguageWithHttpInfo(languageId);
        }

        /// <summary>
        /// Delete Language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRoutingLanguageWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteRoutingLanguage");

            var localVarPath = "/api/v2/routing/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRoutingLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRoutingLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete Language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRoutingLanguageAsync (string languageId)
        {
             await DeleteRoutingLanguageAsyncWithHttpInfo(languageId);

        }

        /// <summary>
        /// Delete Language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoutingLanguageAsyncWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->DeleteRoutingLanguage");
            

            var localVarPath = "/api/v2/routing/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRoutingLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRoutingLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Language</returns>
        public Language GetLanguage (string languageId)
        {
             ApiResponse<Language> localVarResponse = GetLanguageWithHttpInfo(languageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Language</returns>
        public ApiResponse< Language > GetLanguageWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetLanguage");

            var localVarPath = "/api/v2/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        public async System.Threading.Tasks.Task<Language> GetLanguageAsync (string languageId)
        {
             ApiResponse<Language> localVarResponse = await GetLanguageAsyncWithHttpInfo(languageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages/{languageId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Language>> GetLanguageAsyncWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetLanguage");
            

            var localVarPath = "/api/v2/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of supported languages. (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>LanguageEntityListing</returns>
        public LanguageEntityListing GetLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
        {
             ApiResponse<LanguageEntityListing> localVarResponse = GetLanguagesWithHttpInfo(pageSize, pageNumber, sortOrder, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of supported languages. (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of LanguageEntityListing</returns>
        public ApiResponse< LanguageEntityListing > GetLanguagesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/languages";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LanguageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of supported languages. (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of LanguageEntityListing</returns>
        public async System.Threading.Tasks.Task<LanguageEntityListing> GetLanguagesAsync (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
        {
             ApiResponse<LanguageEntityListing> localVarResponse = await GetLanguagesAsyncWithHttpInfo(pageSize, pageNumber, sortOrder, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of supported languages. (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanguageEntityListing>> GetLanguagesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/languages";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LanguageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all available languages for translation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AvailableTranslations</returns>
        public AvailableTranslations GetLanguagesTranslations ()
        {
             ApiResponse<AvailableTranslations> localVarResponse = GetLanguagesTranslationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available languages for translation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AvailableTranslations</returns>
        public ApiResponse< AvailableTranslations > GetLanguagesTranslationsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/languages/translations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvailableTranslations>(localVarStatusCode,
                localVarHeaders,
                (AvailableTranslations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTranslations)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all available languages for translation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AvailableTranslations</returns>
        public async System.Threading.Tasks.Task<AvailableTranslations> GetLanguagesTranslationsAsync ()
        {
             ApiResponse<AvailableTranslations> localVarResponse = await GetLanguagesTranslationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available languages for translation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AvailableTranslations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvailableTranslations>> GetLanguagesTranslationsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/languages/translations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvailableTranslations>(localVarStatusCode,
                localVarHeaders,
                (AvailableTranslations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTranslations)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the builtin translation for a language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetLanguagesTranslationsBuiltin (string language)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = GetLanguagesTranslationsBuiltinWithHttpInfo(language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the builtin translation for a language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse< Dictionary<string, Object> > GetLanguagesTranslationsBuiltinWithHttpInfo (string language)
        { 
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsBuiltin");

            var localVarPath = "/api/v2/languages/translations/builtin";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the builtin translation for a language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsBuiltinAsync (string language)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await GetLanguagesTranslationsBuiltinAsyncWithHttpInfo(language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the builtin translation for a language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the builtin translation to retrieve</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsBuiltinAsyncWithHttpInfo (string language)
        { 
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsBuiltin");
            

            var localVarPath = "/api/v2/languages/translations/builtin";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsBuiltin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get effective translation for an organization by language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetLanguagesTranslationsOrganization (string language)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = GetLanguagesTranslationsOrganizationWithHttpInfo(language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get effective translation for an organization by language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse< Dictionary<string, Object> > GetLanguagesTranslationsOrganizationWithHttpInfo (string language)
        { 
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsOrganization");

            var localVarPath = "/api/v2/languages/translations/organization";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get effective translation for an organization by language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsOrganizationAsync (string language)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await GetLanguagesTranslationsOrganizationAsyncWithHttpInfo(language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get effective translation for an organization by language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The language of the translation to retrieve for the organization</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsOrganizationAsyncWithHttpInfo (string language)
        { 
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling LanguagesApi->GetLanguagesTranslationsOrganization");
            

            var localVarPath = "/api/v2/languages/translations/organization";
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
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get effective language translation for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetLanguagesTranslationsUser (string userId)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = GetLanguagesTranslationsUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get effective language translation for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse< Dictionary<string, Object> > GetLanguagesTranslationsUserWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LanguagesApi->GetLanguagesTranslationsUser");

            var localVarPath = "/api/v2/languages/translations/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get effective language translation for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> GetLanguagesTranslationsUserAsync (string userId)
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await GetLanguagesTranslationsUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get effective language translation for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user id</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetLanguagesTranslationsUserAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling LanguagesApi->GetLanguagesTranslationsUser");
            

            var localVarPath = "/api/v2/languages/translations/users/{userId}";
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguagesTranslationsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarHeaders,
                (Dictionary<string, Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Language</returns>
        public Language GetRoutingLanguage (string languageId)
        {
             ApiResponse<Language> localVarResponse = GetRoutingLanguageWithHttpInfo(languageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Language</returns>
        public ApiResponse< Language > GetRoutingLanguageWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetRoutingLanguage");

            var localVarPath = "/api/v2/routing/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoutingLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoutingLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        public async System.Threading.Tasks.Task<Language> GetRoutingLanguageAsync (string languageId)
        {
             ApiResponse<Language> localVarResponse = await GetRoutingLanguageAsyncWithHttpInfo(languageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get language 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Language>> GetRoutingLanguageAsyncWithHttpInfo (string languageId)
        { 
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesApi->GetRoutingLanguage");
            

            var localVarPath = "/api/v2/routing/languages/{languageId}";
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
            if (languageId != null) localVarPathParams.Add("languageId", this.Configuration.ApiClient.ParameterToString(languageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoutingLanguage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoutingLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Language</returns>
        public Language PostLanguages (Language body)
        {
             ApiResponse<Language> localVarResponse = PostLanguagesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>ApiResponse of Language</returns>
        public ApiResponse< Language > PostLanguagesWithHttpInfo (Language body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguagesApi->PostLanguages");

            var localVarPath = "/api/v2/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Task of Language</returns>
        public async System.Threading.Tasks.Task<Language> PostLanguagesAsync (Language body)
        {
             ApiResponse<Language> localVarResponse = await PostLanguagesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Language (Deprecated) This endpoint is deprecated. It has been moved to /routing/languages
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Language</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Language>> PostLanguagesAsyncWithHttpInfo (Language body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LanguagesApi->PostLanguages");
            

            var localVarPath = "/api/v2/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Language>(localVarStatusCode,
                localVarHeaders,
                (Language) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Language)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
