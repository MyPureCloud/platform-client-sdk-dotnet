# SocialMediaApi

## PureCloudPlatform.Client.V2.Api.SocialMediaApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteSocialmediaTopic**](#DeleteSocialmediaTopic) | **Delete** /api/v2/socialmedia/topics/{topicId} | Delete a social topic. |
| [**DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Delete a Facebook data ingestion rule. |
| [**DeleteSocialmediaTopicDataingestionrulesOpenOpenId**](#DeleteSocialmediaTopicDataingestionrulesOpenOpenId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Delete a open data ingestion rule. |
| [**DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Delete a X (formally Twitter) data ingestion rule. |
| [**GetSocialmediaTopic**](#GetSocialmediaTopic) | **Get** /api/v2/socialmedia/topics/{topicId} | Get a single social topic. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Get a single Facebook data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions/{dataIngestionRuleVersion} | Get a single Facebook data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions | Get the Facebook data ingestion rule versions. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenId**](#GetSocialmediaTopicDataingestionrulesOpenOpenId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Get a single open data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion**](#GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions/{dataIngestionRuleVersion} | Get a single Open data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions**](#GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions | Get the Open data ingestion rule versions. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Get a single X (formally Twitter) data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions/{dataIngestionRuleVersion} | Get a single X (formally Twitter) data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions | Get the Open data ingestion rule versions. |
| [**GetSocialmediaTopics**](#GetSocialmediaTopics) | **Get** /api/v2/socialmedia/topics | Retrieve all social topics. |
| [**PatchSocialmediaTopic**](#PatchSocialmediaTopic) | **Patch** /api/v2/socialmedia/topics/{topicId} | Update a social topic. |
| [**PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Update the status of a Facebook data ingestion rule. |
| [**PatchSocialmediaTopicDataingestionrulesOpenOpenId**](#PatchSocialmediaTopicDataingestionrulesOpenOpenId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Update the status of a open data ingestion rule. |
| [**PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Update the status of a X (formally Twitter) data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesFacebook**](#PostSocialmediaTopicDataingestionrulesFacebook) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook | Create an Facebook data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesOpen**](#PostSocialmediaTopicDataingestionrulesOpen) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open | Create an open data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesTwitter**](#PostSocialmediaTopicDataingestionrulesTwitter) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter | Create an twitter data ingestion rule. |
| [**PostSocialmediaTopics**](#PostSocialmediaTopics) | **Post** /api/v2/socialmedia/topics | Create a social topic. |
| [**PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Update the Facebook data ingestion rule. |
| [**PutSocialmediaTopicDataingestionrulesOpenOpenId**](#PutSocialmediaTopicDataingestionrulesOpenOpenId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Update the open data ingestion rule. |
| [**PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Update the X (formally Twitter) data ingestion rule. |



## DeleteSocialmediaTopic

> void DeleteSocialmediaTopic (string topicId, bool? hardDelete = null)


Delete a social topic.

DeleteSocialmediaTopic is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:topic:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var hardDelete = true;  // bool? | Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional) 

            try
            { 
                // Delete a social topic.
                apiInstance.DeleteSocialmediaTopic(topicId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **hardDelete** | **bool?**| Determines whether a Social topic should be soft-deleted or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional]  |

### Return type

void (empty response body)


## DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> void DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? hardDelete = null)


Delete a Facebook data ingestion rule.

DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:facebookDataIngestionRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var hardDelete = true;  // bool? | Determines whether a Facebook data ingestion rule should be soft-deleted (have it's state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)  (default to false)

            try
            { 
                // Delete a Facebook data ingestion rule.
                apiInstance.DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId(topicId, facebookIngestionRuleId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **hardDelete** | **bool?**| Determines whether a Facebook data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteSocialmediaTopicDataingestionrulesOpenOpenId

> void DeleteSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? hardDelete = null)


Delete a open data ingestion rule.

DeleteSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:openDataIngestionRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaTopicDataingestionrulesOpenOpenIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var hardDelete = true;  // bool? | Determines whether a open data ingestion rule should be soft-deleted (have it's state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)  (default to false)

            try
            { 
                // Delete a open data ingestion rule.
                apiInstance.DeleteSocialmediaTopicDataingestionrulesOpenOpenId(topicId, openId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaTopicDataingestionrulesOpenOpenId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **hardDelete** | **bool?**| Determines whether a open data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId

> void DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? hardDelete = null)


Delete a X (formally Twitter) data ingestion rule.

DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:twitterDataIngestionRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var hardDelete = true;  // bool? | Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it's state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)  (default to false)

            try
            { 
                // Delete a X (formally Twitter) data ingestion rule.
                apiInstance.DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId(topicId, twitterIngestionRuleId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **hardDelete** | **bool?**| Determines whether a X (formally Twitter) data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional] [default to false] |

### Return type

void (empty response body)


## GetSocialmediaTopic

> [**SocialTopicResponse**](SocialTopicResponse) GetSocialmediaTopic (string topicId, bool? includeDeleted = null)


Get a single social topic.

GetSocialmediaTopic is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get a single social topic.
                SocialTopicResponse result = apiInstance.GetSocialmediaTopic(topicId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**SocialTopicResponse**](SocialTopicResponse)


## GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)


Get a single Facebook data ingestion rule.

GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:facebookDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get a single Facebook data ingestion rule.
                FacebookDataIngestionRuleResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId(topicId, facebookIngestionRuleId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse)


## GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion

> [**FacebookDataIngestionRuleVersionResponse**](FacebookDataIngestionRuleVersionResponse) GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion (string topicId, string facebookIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)


Get a single Facebook data ingestion rule version.

GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:facebookDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var dataIngestionRuleVersion = dataIngestionRuleVersion_example;  // string | version
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted item in the result. (optional) 

            try
            { 
                // Get a single Facebook data ingestion rule version.
                FacebookDataIngestionRuleVersionResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion(topicId, facebookIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **dataIngestionRuleVersion** | **string**| version |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted item in the result. | [optional]  |

### Return type

[**FacebookDataIngestionRuleVersionResponse**](FacebookDataIngestionRuleVersionResponse)


## GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions

> [**FacebookDataIngestionRuleVersionResponseEntityListing**](FacebookDataIngestionRuleVersionResponseEntityListing) GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions (string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)


Get the Facebook data ingestion rule versions.

GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:facebookDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get the Facebook data ingestion rule versions.
                FacebookDataIngestionRuleVersionResponseEntityListing result = apiInstance.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions(topicId, facebookIngestionRuleId, pageNumber, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**FacebookDataIngestionRuleVersionResponseEntityListing**](FacebookDataIngestionRuleVersionResponseEntityListing)


## GetSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? includeDeleted = null)


Get a single open data ingestion rule.

GetSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:openDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesOpenOpenIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get a single open data ingestion rule.
                OpenDataIngestionRuleResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesOpenOpenId(topicId, openId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesOpenOpenId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse)


## GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion

> [**OpenDataIngestionRuleVersionResponse**](OpenDataIngestionRuleVersionResponse) GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion (string topicId, string openId, string dataIngestionRuleVersion, bool? includeDeleted = null)


Get a single Open data ingestion rule version.

GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:openDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var dataIngestionRuleVersion = dataIngestionRuleVersion_example;  // string | version
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted item in the result. (optional) 

            try
            { 
                // Get a single Open data ingestion rule version.
                OpenDataIngestionRuleVersionResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion(topicId, openId, dataIngestionRuleVersion, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **dataIngestionRuleVersion** | **string**| version |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted item in the result. | [optional]  |

### Return type

[**OpenDataIngestionRuleVersionResponse**](OpenDataIngestionRuleVersionResponse)


## GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions

> [**OpenDataIngestionRuleVersionResponseEntityListing**](OpenDataIngestionRuleVersionResponseEntityListing) GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions (string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)


Get the Open data ingestion rule versions.

GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:openDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesOpenOpenIdVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get the Open data ingestion rule versions.
                OpenDataIngestionRuleVersionResponseEntityListing result = apiInstance.GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions(topicId, openId, pageNumber, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**OpenDataIngestionRuleVersionResponseEntityListing**](OpenDataIngestionRuleVersionResponseEntityListing)


## GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId

> [**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, bool? includeDeleted = null)


Get a single X (formally Twitter) data ingestion rule.

GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:twitterDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get a single X (formally Twitter) data ingestion rule.
                TwitterDataIngestionRuleResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId(topicId, twitterIngestionRuleId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse)


## GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion

> [**TwitterDataIngestionRuleVersionResponse**](TwitterDataIngestionRuleVersionResponse) GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion (string topicId, string twitterIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)


Get a single X (formally Twitter) data ingestion rule version.

GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:twitterDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var dataIngestionRuleVersion = dataIngestionRuleVersion_example;  // string | version
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted item in the result. (optional) 

            try
            { 
                // Get a single X (formally Twitter) data ingestion rule version.
                TwitterDataIngestionRuleVersionResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion(topicId, twitterIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **dataIngestionRuleVersion** | **string**| version |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted item in the result. | [optional]  |

### Return type

[**TwitterDataIngestionRuleVersionResponse**](TwitterDataIngestionRuleVersionResponse)


## GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions

> [**TwitterDataIngestionRuleVersionResponseEntityListing**](TwitterDataIngestionRuleVersionResponseEntityListing) GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions (string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)


Get the Open data ingestion rule versions.

GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:twitterDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get the Open data ingestion rule versions.
                TwitterDataIngestionRuleVersionResponseEntityListing result = apiInstance.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions(topicId, twitterIngestionRuleId, pageNumber, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**TwitterDataIngestionRuleVersionResponseEntityListing**](TwitterDataIngestionRuleVersionResponseEntityListing)


## GetSocialmediaTopics

> [**SocialTopicResponseEntityListing**](SocialTopicResponseEntityListing) GetSocialmediaTopics (int? pageNumber = null, int? pageSize = null, List<string> divisionIds = null, bool? includeDeleted = null)


Retrieve all social topics.

GetSocialmediaTopics is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var divisionIds = new List<string>(); // List<string> | One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. (optional) 
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Retrieve all social topics.
                SocialTopicResponseEntityListing result = apiInstance.GetSocialmediaTopics(pageNumber, pageSize, divisionIds, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **divisionIds** | [**List<string>**](string)| One or more division IDs. If nothing is provided, the social topics associated withthe list of divisions that the user has access to will be returned. | [optional]  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**SocialTopicResponseEntityListing**](SocialTopicResponseEntityListing)


## PatchSocialmediaTopic

> [**SocialTopicResponse**](SocialTopicResponse) PatchSocialmediaTopic (string topicId, SocialTopicPatchRequest body = null)


Update a social topic.

PatchSocialmediaTopic is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSocialmediaTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var body = new SocialTopicPatchRequest(); // SocialTopicPatchRequest |  (optional) 

            try
            { 
                // Update a social topic.
                SocialTopicResponse result = apiInstance.PatchSocialmediaTopic(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PatchSocialmediaTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **body** | [**SocialTopicPatchRequest**](SocialTopicPatchRequest)|  | [optional]  |

### Return type

[**SocialTopicResponse**](SocialTopicResponse)


## PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)


Update the status of a Facebook data ingestion rule.

PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:facebookDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var body = new DataIngestionRuleStatusPatchRequest(); // DataIngestionRuleStatusPatchRequest |  (optional) 

            try
            { 
                // Update the status of a Facebook data ingestion rule.
                FacebookDataIngestionRuleResponse result = apiInstance.PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId(topicId, facebookIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **body** | [**DataIngestionRuleStatusPatchRequest**](DataIngestionRuleStatusPatchRequest)|  | [optional]  |

### Return type

[**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse)


## PatchSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PatchSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)


Update the status of a open data ingestion rule.

PatchSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:openDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSocialmediaTopicDataingestionrulesOpenOpenIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var body = new DataIngestionRuleStatusPatchRequest(); // DataIngestionRuleStatusPatchRequest |  (optional) 

            try
            { 
                // Update the status of a open data ingestion rule.
                OpenDataIngestionRuleResponse result = apiInstance.PatchSocialmediaTopicDataingestionrulesOpenOpenId(topicId, openId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PatchSocialmediaTopicDataingestionrulesOpenOpenId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **body** | [**DataIngestionRuleStatusPatchRequest**](DataIngestionRuleStatusPatchRequest)|  | [optional]  |

### Return type

[**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse)


## PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId

> [**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse) PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)


Update the status of a X (formally Twitter) data ingestion rule.

PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:twitterDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var body = new DataIngestionRuleStatusPatchRequest(); // DataIngestionRuleStatusPatchRequest |  (optional) 

            try
            { 
                // Update the status of a X (formally Twitter) data ingestion rule.
                TwitterDataIngestionRuleResponse result = apiInstance.PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId(topicId, twitterIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **body** | [**DataIngestionRuleStatusPatchRequest**](DataIngestionRuleStatusPatchRequest)|  | [optional]  |

### Return type

[**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse)


## PostSocialmediaTopicDataingestionrulesFacebook

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesFacebook (string topicId, FacebookDataIngestionRuleRequest body = null)


Create an Facebook data ingestion rule.

PostSocialmediaTopicDataingestionrulesFacebook is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:facebookDataIngestionRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var body = new FacebookDataIngestionRuleRequest(); // FacebookDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Create an Facebook data ingestion rule.
                FacebookDataIngestionRuleResponse result = apiInstance.PostSocialmediaTopicDataingestionrulesFacebook(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **body** | [**FacebookDataIngestionRuleRequest**](FacebookDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse)


## PostSocialmediaTopicDataingestionrulesOpen

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesOpen (string topicId, OpenDataIngestionRuleRequest body = null)


Create an open data ingestion rule.

PostSocialmediaTopicDataingestionrulesOpen is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:openDataIngestionRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesOpenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var body = new OpenDataIngestionRuleRequest(); // OpenDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Create an open data ingestion rule.
                OpenDataIngestionRuleResponse result = apiInstance.PostSocialmediaTopicDataingestionrulesOpen(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **body** | [**OpenDataIngestionRuleRequest**](OpenDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse)


## PostSocialmediaTopicDataingestionrulesTwitter

> [**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesTwitter (string topicId, TwitterDataIngestionRuleRequest body = null)


Create an twitter data ingestion rule.

PostSocialmediaTopicDataingestionrulesTwitter is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:twitterDataIngestionRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var body = new TwitterDataIngestionRuleRequest(); // TwitterDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Create an twitter data ingestion rule.
                TwitterDataIngestionRuleResponse result = apiInstance.PostSocialmediaTopicDataingestionrulesTwitter(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **body** | [**TwitterDataIngestionRuleRequest**](TwitterDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse)


## PostSocialmediaTopics

> [**SocialTopicResponse**](SocialTopicResponse) PostSocialmediaTopics (SocialTopicRequest body = null)


Create a social topic.

PostSocialmediaTopics is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:topic:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var body = new SocialTopicRequest(); // SocialTopicRequest |  (optional) 

            try
            { 
                // Create a social topic.
                SocialTopicResponse result = apiInstance.PostSocialmediaTopics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SocialTopicRequest**](SocialTopicRequest)|  | [optional]  |

### Return type

[**SocialTopicResponse**](SocialTopicResponse)


## PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)


Update the Facebook data ingestion rule.

PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:facebookDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var facebookIngestionRuleId = facebookIngestionRuleId_example;  // string | facebookIngestionRuleId
            var body = new FacebookDataIngestionRuleRequest(); // FacebookDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Update the Facebook data ingestion rule.
                FacebookDataIngestionRuleResponse result = apiInstance.PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId(topicId, facebookIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **facebookIngestionRuleId** | **string**| facebookIngestionRuleId |  |
| **body** | [**FacebookDataIngestionRuleRequest**](FacebookDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse)


## PutSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, OpenDataIngestionRuleRequest body = null)


Update the open data ingestion rule.

PutSocialmediaTopicDataingestionrulesOpenOpenId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:openDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSocialmediaTopicDataingestionrulesOpenOpenIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var openId = openId_example;  // string | openId
            var body = new OpenDataIngestionRuleRequest(); // OpenDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Update the open data ingestion rule.
                OpenDataIngestionRuleResponse result = apiInstance.PutSocialmediaTopicDataingestionrulesOpenOpenId(topicId, openId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PutSocialmediaTopicDataingestionrulesOpenOpenId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **openId** | **string**| openId |  |
| **body** | [**OpenDataIngestionRuleRequest**](OpenDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse)


## PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId

> [**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId (string topicId, string twitterIngestionRuleId, TwitterDataIngestionRuleRequest body = null)


Update the X (formally Twitter) data ingestion rule.

PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* socialmedia:twitterDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SocialMediaApi();
            var topicId = topicId_example;  // string | topicId
            var twitterIngestionRuleId = twitterIngestionRuleId_example;  // string | twitterIngestionRuleId
            var body = new TwitterDataIngestionRuleRequest(); // TwitterDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Update the X (formally Twitter) data ingestion rule.
                TwitterDataIngestionRuleResponse result = apiInstance.PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId(topicId, twitterIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **twitterIngestionRuleId** | **string**| twitterIngestionRuleId |  |
| **body** | [**TwitterDataIngestionRuleRequest**](TwitterDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse)


_PureCloudPlatform.Client.V2 222.0.0_
