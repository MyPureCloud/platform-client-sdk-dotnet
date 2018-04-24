---
title: AppFoundryApi
---
## PureCloudPlatform.Client.V2.Api.AppFoundryApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAppfoundryPlatformNameCategories**](AppFoundryApi.html#getappfoundryplatformnamecategories) | **GET** /api/v2/appfoundry/{platformName}/categories | Return a structured hierarchy of available listing categories |
| [**GetAppfoundryPlatformNameCategory**](AppFoundryApi.html#getappfoundryplatformnamecategory) | **GET** /api/v2/appfoundry/{platformName}/categories/{categoryName} | Get listings that are part of the specified root category or a contained subcategory |
| [**GetAppfoundryPlatformNameCategorySubCategoryName**](AppFoundryApi.html#getappfoundryplatformnamecategorysubcategoryname) | **GET** /api/v2/appfoundry/{platformName}/categories/{categoryName}/{subCategoryName} | Get listings that are part of the specified subcategory |
{: class="table table-striped"}

<a name="getappfoundryplatformnamecategories"></a>

## [**List&lt;AppFoundryListingCategory&gt;**](AppFoundryListingCategory.html) GetAppfoundryPlatformNameCategories (string platformName)

Return a structured hierarchy of available listing categories



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAppfoundryPlatformNameCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AppFoundryApi();
            
            
            var platformName = platformName_example;  // string | 
            
            
            

            try
            {
                
                // Return a structured hierarchy of available listing categories
                
                List&lt;AppFoundryListingCategory&gt; result = apiInstance.GetAppfoundryPlatformNameCategories(platformName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppFoundryApi.GetAppfoundryPlatformNameCategories: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **platformName** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**List<AppFoundryListingCategory>**](AppFoundryListingCategory.html)

<a name="getappfoundryplatformnamecategory"></a>

## [**PagedListingEntity**](PagedListingEntity.html) GetAppfoundryPlatformNameCategory (string platformName, string categoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)

Get listings that are part of the specified root category or a contained subcategory



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAppfoundryPlatformNameCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AppFoundryApi();
            
            
            var platformName = platformName_example;  // string | 
            
            
            
            
            var categoryName = categoryName_example;  // string | Name of category to request listings from
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            

            try
            {
                
                // Get listings that are part of the specified root category or a contained subcategory
                
                PagedListingEntity result = apiInstance.GetAppfoundryPlatformNameCategory(platformName, categoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppFoundryApi.GetAppfoundryPlatformNameCategory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **platformName** | **string**|  |  |
| **categoryName** | **string**| Name of category to request listings from |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**PagedListingEntity**](PagedListingEntity.html)

<a name="getappfoundryplatformnamecategorysubcategoryname"></a>

## [**PagedListingEntity**](PagedListingEntity.html) GetAppfoundryPlatformNameCategorySubCategoryName (string platformName, string categoryName, string subCategoryName, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)

Get listings that are part of the specified subcategory



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAppfoundryPlatformNameCategorySubCategoryNameExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AppFoundryApi();
            
            
            var platformName = platformName_example;  // string | 
            
            
            
            
            var categoryName = categoryName_example;  // string | Name of category to request listings from
            
            
            
            
            var subCategoryName = subCategoryName_example;  // string | Name of subcategory to request listings from
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            

            try
            {
                
                // Get listings that are part of the specified subcategory
                
                PagedListingEntity result = apiInstance.GetAppfoundryPlatformNameCategorySubCategoryName(platformName, categoryName, subCategoryName, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppFoundryApi.GetAppfoundryPlatformNameCategorySubCategoryName: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **platformName** | **string**|  |  |
| **categoryName** | **string**| Name of category to request listings from |  |
| **subCategoryName** | **string**| Name of subcategory to request listings from |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**PagedListingEntity**](PagedListingEntity.html)

