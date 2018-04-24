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
    public interface IAppFoundryApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Return a structured hierarchy of available listing categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>List&lt;AppFoundryListingCategory&gt;</returns>
        List<AppFoundryListingCategory> GetAppfoundryPlatformNameCategories (string platformName);

        /// <summary>
        /// Return a structured hierarchy of available listing categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>ApiResponse of List&lt;AppFoundryListingCategory&gt;</returns>
        ApiResponse<List<AppFoundryListingCategory>> GetAppfoundryPlatformNameCategoriesWithHttpInfo (string platformName);
        
        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>PagedListingEntity</returns>
        PagedListingEntity GetAppfoundryPlatformNameCategory (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of PagedListingEntity</returns>
        ApiResponse<PagedListingEntity> GetAppfoundryPlatformNameCategoryWithHttpInfo (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Get listings that are part of the specified subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>PagedListingEntity</returns>
        PagedListingEntity GetAppfoundryPlatformNameCategorySubCategoryName (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get listings that are part of the specified subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of PagedListingEntity</returns>
        ApiResponse<PagedListingEntity> GetAppfoundryPlatformNameCategorySubCategoryNameWithHttpInfo (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Return a structured hierarchy of available listing categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>Task of List&lt;AppFoundryListingCategory&gt;</returns>
        System.Threading.Tasks.Task<List<AppFoundryListingCategory>> GetAppfoundryPlatformNameCategoriesAsync (string platformName);

        /// <summary>
        /// Return a structured hierarchy of available listing categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>Task of ApiResponse (List&lt;AppFoundryListingCategory&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AppFoundryListingCategory>>> GetAppfoundryPlatformNameCategoriesAsyncWithHttpInfo (string platformName);
        
        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of PagedListingEntity</returns>
        System.Threading.Tasks.Task<PagedListingEntity> GetAppfoundryPlatformNameCategoryAsync (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (PagedListingEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedListingEntity>> GetAppfoundryPlatformNameCategoryAsyncWithHttpInfo (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        /// <summary>
        /// Get listings that are part of the specified subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of PagedListingEntity</returns>
        System.Threading.Tasks.Task<PagedListingEntity> GetAppfoundryPlatformNameCategorySubCategoryNameAsync (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);

        /// <summary>
        /// Get listings that are part of the specified subcategory
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (PagedListingEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedListingEntity>> GetAppfoundryPlatformNameCategorySubCategoryNameAsyncWithHttpInfo (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppFoundryApi : IAppFoundryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppFoundryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppFoundryApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppFoundryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppFoundryApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Return a structured hierarchy of available listing categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>List&lt;AppFoundryListingCategory&gt;</returns>
        public List<AppFoundryListingCategory> GetAppfoundryPlatformNameCategories (string platformName)
        {
             ApiResponse<List<AppFoundryListingCategory>> localVarResponse = GetAppfoundryPlatformNameCategoriesWithHttpInfo(platformName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Return a structured hierarchy of available listing categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>ApiResponse of List&lt;AppFoundryListingCategory&gt;</returns>
        public ApiResponse< List<AppFoundryListingCategory> > GetAppfoundryPlatformNameCategoriesWithHttpInfo (string platformName)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategories");

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AppFoundryListingCategory>>(localVarStatusCode,
                localVarHeaders,
                (List<AppFoundryListingCategory>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AppFoundryListingCategory>)));
            
        }

        
        /// <summary>
        /// Return a structured hierarchy of available listing categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>Task of List&lt;AppFoundryListingCategory&gt;</returns>
        public async System.Threading.Tasks.Task<List<AppFoundryListingCategory>> GetAppfoundryPlatformNameCategoriesAsync (string platformName)
        {
             ApiResponse<List<AppFoundryListingCategory>> localVarResponse = await GetAppfoundryPlatformNameCategoriesAsyncWithHttpInfo(platformName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Return a structured hierarchy of available listing categories 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <returns>Task of ApiResponse (List&lt;AppFoundryListingCategory&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AppFoundryListingCategory>>> GetAppfoundryPlatformNameCategoriesAsyncWithHttpInfo (string platformName)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategories");
            

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategories: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AppFoundryListingCategory>>(localVarStatusCode,
                localVarHeaders,
                (List<AppFoundryListingCategory>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AppFoundryListingCategory>)));
            
        }

        
        
        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>PagedListingEntity</returns>
        public PagedListingEntity GetAppfoundryPlatformNameCategory (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<PagedListingEntity> localVarResponse = GetAppfoundryPlatformNameCategoryWithHttpInfo(platformName, categoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of PagedListingEntity</returns>
        public ApiResponse< PagedListingEntity > GetAppfoundryPlatformNameCategoryWithHttpInfo (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategory");
            // verify the required parameter 'categoryName' is set
            if (categoryName == null)
                throw new ApiException(400, "Missing required parameter 'categoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategory");

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories/{categoryName}";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));
            if (categoryName != null) localVarPathParams.Add("categoryName", this.Configuration.ApiClient.ParameterToString(categoryName));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagedListingEntity>(localVarStatusCode,
                localVarHeaders,
                (PagedListingEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedListingEntity)));
            
        }

        
        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of PagedListingEntity</returns>
        public async System.Threading.Tasks.Task<PagedListingEntity> GetAppfoundryPlatformNameCategoryAsync (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<PagedListingEntity> localVarResponse = await GetAppfoundryPlatformNameCategoryAsyncWithHttpInfo(platformName, categoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get listings that are part of the specified root category or a contained subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (PagedListingEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagedListingEntity>> GetAppfoundryPlatformNameCategoryAsyncWithHttpInfo (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategory");
            
            // verify the required parameter 'categoryName' is set
            if (categoryName == null)
                throw new ApiException(400, "Missing required parameter 'categoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategory");
            

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories/{categoryName}";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));
            if (categoryName != null) localVarPathParams.Add("categoryName", this.Configuration.ApiClient.ParameterToString(categoryName));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagedListingEntity>(localVarStatusCode,
                localVarHeaders,
                (PagedListingEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedListingEntity)));
            
        }

        
        
        /// <summary>
        /// Get listings that are part of the specified subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>PagedListingEntity</returns>
        public PagedListingEntity GetAppfoundryPlatformNameCategorySubCategoryName (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<PagedListingEntity> localVarResponse = GetAppfoundryPlatformNameCategorySubCategoryNameWithHttpInfo(platformName, categoryName, subCategoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get listings that are part of the specified subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>ApiResponse of PagedListingEntity</returns>
        public ApiResponse< PagedListingEntity > GetAppfoundryPlatformNameCategorySubCategoryNameWithHttpInfo (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");
            // verify the required parameter 'categoryName' is set
            if (categoryName == null)
                throw new ApiException(400, "Missing required parameter 'categoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");
            // verify the required parameter 'subCategoryName' is set
            if (subCategoryName == null)
                throw new ApiException(400, "Missing required parameter 'subCategoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories/{categoryName}/{subCategoryName}";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));
            if (categoryName != null) localVarPathParams.Add("categoryName", this.Configuration.ApiClient.ParameterToString(categoryName));
            if (subCategoryName != null) localVarPathParams.Add("subCategoryName", this.Configuration.ApiClient.ParameterToString(subCategoryName));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategorySubCategoryName: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategorySubCategoryName: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagedListingEntity>(localVarStatusCode,
                localVarHeaders,
                (PagedListingEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedListingEntity)));
            
        }

        
        /// <summary>
        /// Get listings that are part of the specified subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of PagedListingEntity</returns>
        public async System.Threading.Tasks.Task<PagedListingEntity> GetAppfoundryPlatformNameCategorySubCategoryNameAsync (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        {
             ApiResponse<PagedListingEntity> localVarResponse = await GetAppfoundryPlatformNameCategorySubCategoryNameAsyncWithHttpInfo(platformName, categoryName, subCategoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get listings that are part of the specified subcategory 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platformName"></param>
        /// <param name="categoryName">Name of category to request listings from</param>
        /// <param name="subCategoryName">Name of subcategory to request listings from</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <returns>Task of ApiResponse (PagedListingEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagedListingEntity>> GetAppfoundryPlatformNameCategorySubCategoryNameAsyncWithHttpInfo (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)
        { 
            // verify the required parameter 'platformName' is set
            if (platformName == null)
                throw new ApiException(400, "Missing required parameter 'platformName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");
            
            // verify the required parameter 'categoryName' is set
            if (categoryName == null)
                throw new ApiException(400, "Missing required parameter 'categoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");
            
            // verify the required parameter 'subCategoryName' is set
            if (subCategoryName == null)
                throw new ApiException(400, "Missing required parameter 'subCategoryName' when calling AppFoundryApi->GetAppfoundryPlatformNameCategorySubCategoryName");
            

            var localVarPath = "/api/v2/appfoundry/{platformName}/categories/{categoryName}/{subCategoryName}";
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
            if (platformName != null) localVarPathParams.Add("platformName", this.Configuration.ApiClient.ParameterToString(platformName));
            if (categoryName != null) localVarPathParams.Add("categoryName", this.Configuration.ApiClient.ParameterToString(categoryName));
            if (subCategoryName != null) localVarPathParams.Add("subCategoryName", this.Configuration.ApiClient.ParameterToString(subCategoryName));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategorySubCategoryName: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAppfoundryPlatformNameCategorySubCategoryName: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagedListingEntity>(localVarStatusCode,
                localVarHeaders,
                (PagedListingEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedListingEntity)));
            
        }

        
        
    }
    
}
