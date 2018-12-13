---
title: SuggestApi
---
## PureCloudPlatform.Client.V2.Api.SuggestApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSearch**](SuggestApi.html#getsearch) | **GET** /api/v2/search | Search using the q64 value returned from a previous search. |
| [**GetSearchSuggest**](SuggestApi.html#getsearchsuggest) | **GET** /api/v2/search/suggest | Suggest resources using the q64 value returned from a previous suggest query. |
| [**PostSearch**](SuggestApi.html#postsearch) | **POST** /api/v2/search | Search resources. |
| [**PostSearchSuggest**](SuggestApi.html#postsearchsuggest) | **POST** /api/v2/search/suggest | Suggest resources. |
{: class="table table-striped"}

<a name="getsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch (string q64, List<string> expand = null, bool? profile = null)



Search using the q64 value returned from a previous search.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new SuggestApi();
            
            
            var q64 = q64_example;  // string | q64
            
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            
            
            var profile = true;  // bool? | profile (optional)  (default to true)
            
            
            

            try
            {
                
                // Search using the q64 value returned from a previous search.
                
                JsonNodeSearchResponse result = apiInstance.GetSearch(q64, expand, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.GetSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, profileSkills, locations, groups, skills, languages, languagePreference, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsearchsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearchSuggest (string q64, List<string> expand = null, bool? profile = null)



Suggest resources using the q64 value returned from a previous suggest query.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSearchSuggestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new SuggestApi();
            
            
            var q64 = q64_example;  // string | q64
            
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            
            
            var profile = true;  // bool? | profile (optional)  (default to true)
            
            
            

            try
            {
                
                // Suggest resources using the q64 value returned from a previous suggest query.
                
                JsonNodeSearchResponse result = apiInstance.GetSearchSuggest(q64, expand, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.GetSearchSuggest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, profileSkills, locations, groups, skills, languages, languagePreference, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch (SearchRequest body, bool? profile = null)



Search resources.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new SuggestApi();
            
            
            
            var body = new SearchRequest(); // SearchRequest | Search request options
            
            
            
            var profile = true;  // bool? | profile (optional)  (default to true)
            
            
            

            try
            {
                
                // Search resources.
                
                JsonNodeSearchResponse result = apiInstance.PostSearch(body, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.PostSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SearchRequest**](SearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearchsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearchSuggest (SuggestSearchRequest body, bool? profile = null)



Suggest resources.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSearchSuggestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new SuggestApi();
            
            
            
            var body = new SuggestSearchRequest(); // SuggestSearchRequest | Search request options
            
            
            
            var profile = true;  // bool? | profile (optional)  (default to true)
            
            
            

            try
            {
                
                // Suggest resources.
                
                JsonNodeSearchResponse result = apiInstance.PostSearchSuggest(body, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.PostSearchSuggest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SuggestSearchRequest**](SuggestSearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

