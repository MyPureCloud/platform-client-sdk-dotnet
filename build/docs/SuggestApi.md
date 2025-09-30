# SuggestApi

## PureCloudPlatform.Client.V2.Api.SuggestApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSearch**](#GetSearch) | **Get** /api/v2/search | Search using the q64 value returned from a previous search. |
| [**GetSearchSuggest**](#GetSearchSuggest) | **Get** /api/v2/search/suggest | Suggest resources using the q64 value returned from a previous suggest query. |
| [**PostSearch**](#PostSearch) | **Post** /api/v2/search | Search resources. |
| [**PostSearchSuggest**](#PostSearchSuggest) | **Post** /api/v2/search/suggest | Suggest resources. |



## GetSearch

> [**JsonNodeSearchResponse**](JsonNodeSearchResponse) GetSearch (string q64, List<string> expand = null, bool? profile = null)


Search using the q64 value returned from a previous search.

Requires ANY permissions: 

* directory:user:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, externalContactsSettings, groups, profileSkills, certifications, locations, skills, languages, languagePreference, employerInfo, biography, dateLastLogin, dateWelcomeSent, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, conversations, transcription, images, addressVerificationDetails |
| **profile** | **bool?**| profile | [optional] [default to true] |

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse)


## GetSearchSuggest

> [**JsonNodeSearchResponse**](JsonNodeSearchResponse) GetSearchSuggest (string q64, List<string> expand = null, bool? profile = null)


Suggest resources using the q64 value returned from a previous suggest query.

Requires ANY permissions: 

* directory:user:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, externalContactsSettings, groups, profileSkills, certifications, locations, skills, languages, languagePreference, employerInfo, biography, dateLastLogin, dateWelcomeSent, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, conversations, transcription, images, addressVerificationDetails |
| **profile** | **bool?**| profile | [optional] [default to true] |

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse)


## PostSearch

> [**JsonNodeSearchResponse**](JsonNodeSearchResponse) PostSearch (SearchRequest body, bool? profile = null)


Search resources.

Requires ANY permissions: 

* directory:user:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SearchRequest**](SearchRequest)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse)


## PostSearchSuggest

> [**JsonNodeSearchResponse**](JsonNodeSearchResponse) PostSearchSuggest (SuggestSearchRequest body, bool? profile = null)


Suggest resources.

Requires ANY permissions: 

* directory:user:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SuggestSearchRequest**](SuggestSearchRequest)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse)


_PureCloudPlatform.Client.V2 244.0.0_
