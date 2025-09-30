# SocialMediaApi

## PureCloudPlatform.Client.V2.Api.SocialMediaApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteSocialmediaEscalationrule**](#DeleteSocialmediaEscalationrule) | **Delete** /api/v2/socialmedia/escalationrules/{escalationRuleId} | Delete an escalation rule. |
| [**DeleteSocialmediaMessage**](#DeleteSocialmediaMessage) | **Delete** /api/v2/socialmedia/messages/{messageId} | Delete a social media message. |
| [**DeleteSocialmediaTopic**](#DeleteSocialmediaTopic) | **Delete** /api/v2/socialmedia/topics/{topicId} | Delete a social topic. |
| [**DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#DeleteSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Delete a Facebook data ingestion rule. |
| [**DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId**](#DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId} | Delete a Instagram data ingestion rule. |
| [**DeleteSocialmediaTopicDataingestionrulesOpenOpenId**](#DeleteSocialmediaTopicDataingestionrulesOpenOpenId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Delete a open data ingestion rule. |
| [**DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#DeleteSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Delete** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Delete a X (formally Twitter) data ingestion rule. |
| [**GetSocialmediaAnalyticsAggregatesJob**](#GetSocialmediaAnalyticsAggregatesJob) | **Get** /api/v2/socialmedia/analytics/aggregates/jobs/{jobId} | Get status for async query for social media aggregates |
| [**GetSocialmediaAnalyticsAggregatesJobResults**](#GetSocialmediaAnalyticsAggregatesJobResults) | **Get** /api/v2/socialmedia/analytics/aggregates/jobs/{jobId}/results | Fetch a page of results for an async social media query |
| [**GetSocialmediaAnalyticsMessagesJob**](#GetSocialmediaAnalyticsMessagesJob) | **Get** /api/v2/socialmedia/analytics/messages/jobs/{jobId} | Get status for async query for social media messages job |
| [**GetSocialmediaAnalyticsMessagesJobResults**](#GetSocialmediaAnalyticsMessagesJobResults) | **Get** /api/v2/socialmedia/analytics/messages/jobs/{jobId}/results | Fetch a page of results for an async social media messages query |
| [**GetSocialmediaEscalationrule**](#GetSocialmediaEscalationrule) | **Get** /api/v2/socialmedia/escalationrules/{escalationRuleId} | Get a single escalation rule. |
| [**GetSocialmediaEscalationrules**](#GetSocialmediaEscalationrules) | **Get** /api/v2/socialmedia/escalationrules | Retrieve all escalation rules for a division. |
| [**GetSocialmediaTopic**](#GetSocialmediaTopic) | **Get** /api/v2/socialmedia/topics/{topicId} | Get a single social topic. |
| [**GetSocialmediaTopicDataingestionrules**](#GetSocialmediaTopicDataingestionrules) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules | Retrieve all social topic data ingestion rules with pagination. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Get a single Facebook data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions/{dataIngestionRuleVersion} | Get a single Facebook data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions**](#GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId}/versions | Get the Facebook data ingestion rule versions. |
| [**GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId**](#GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId} | Get a single Instagram data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion**](#GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId}/versions/{dataIngestionRuleVersion} | Get a single Instagram data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions**](#GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId}/versions | Get the Instagram data ingestion rule versions. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenId**](#GetSocialmediaTopicDataingestionrulesOpenOpenId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Get a single open data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion**](#GetSocialmediaTopicDataingestionrulesOpenOpenIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions/{dataIngestionRuleVersion} | Get a single Open data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions**](#GetSocialmediaTopicDataingestionrulesOpenOpenIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId}/versions | Get the Open data ingestion rule versions. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Get a single X (formally Twitter) data ingestion rule. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersion) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions/{dataIngestionRuleVersion} | Get a single X (formally Twitter) data ingestion rule version. |
| [**GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions**](#GetSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleIdVersions) | **Get** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId}/versions | Get the Open data ingestion rule versions. |
| [**GetSocialmediaTopics**](#GetSocialmediaTopics) | **Get** /api/v2/socialmedia/topics | Retrieve all social topics. |
| [**PatchSocialmediaTopic**](#PatchSocialmediaTopic) | **Patch** /api/v2/socialmedia/topics/{topicId} | Update a social topic. |
| [**PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#PatchSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Update the status of a Facebook data ingestion rule. |
| [**PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId**](#PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId} | Update the status of a Instagram data ingestion rule. |
| [**PatchSocialmediaTopicDataingestionrulesOpenOpenId**](#PatchSocialmediaTopicDataingestionrulesOpenOpenId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Update the status of a open data ingestion rule. |
| [**PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#PatchSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Patch** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Update the status of a X (formally Twitter) data ingestion rule. |
| [**PostSocialmediaAnalyticsAggregatesJobs**](#PostSocialmediaAnalyticsAggregatesJobs) | **Post** /api/v2/socialmedia/analytics/aggregates/jobs | Query for social media aggregates asynchronously |
| [**PostSocialmediaAnalyticsMessagesJobs**](#PostSocialmediaAnalyticsMessagesJobs) | **Post** /api/v2/socialmedia/analytics/messages/jobs | Query for social media messages asynchronously |
| [**PostSocialmediaEscalationrules**](#PostSocialmediaEscalationrules) | **Post** /api/v2/socialmedia/escalationrules | Create an escalation rule. |
| [**PostSocialmediaEscalationsMessages**](#PostSocialmediaEscalationsMessages) | **Post** /api/v2/socialmedia/escalations/messages | Escalate message to a conversation manually |
| [**PostSocialmediaTopicDataingestionrulesFacebook**](#PostSocialmediaTopicDataingestionrulesFacebook) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook | Create an Facebook data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesInstagram**](#PostSocialmediaTopicDataingestionrulesInstagram) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram | Create an Instagram data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesOpen**](#PostSocialmediaTopicDataingestionrulesOpen) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open | Create an open data ingestion rule. |
| [**PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk**](#PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{ruleId}/messages/bulk | Ingest a list of Open Social Messages |
| [**PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk**](#PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{ruleId}/reactions/bulk | Ingest a list of Open Social Reactions |
| [**PostSocialmediaTopicDataingestionrulesTwitter**](#PostSocialmediaTopicDataingestionrulesTwitter) | **Post** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter | Create an twitter data ingestion rule. |
| [**PostSocialmediaTopics**](#PostSocialmediaTopics) | **Post** /api/v2/socialmedia/topics | Create a social topic. |
| [**PostSocialmediaTwitterHistoricalTweets**](#PostSocialmediaTwitterHistoricalTweets) | **Post** /api/v2/socialmedia/twitter/historical/tweets | Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization. |
| [**PutSocialmediaEscalationrule**](#PutSocialmediaEscalationrule) | **Put** /api/v2/socialmedia/escalationrules/{escalationRuleId} | Update the escalation rule. |
| [**PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId**](#PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/facebook/{facebookIngestionRuleId} | Update the Facebook data ingestion rule. |
| [**PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId**](#PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/instagram/{instagramIngestionRuleId} | Update the Instagram data ingestion rule. |
| [**PutSocialmediaTopicDataingestionrulesOpenOpenId**](#PutSocialmediaTopicDataingestionrulesOpenOpenId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/open/{openId} | Update the open data ingestion rule. |
| [**PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId**](#PutSocialmediaTopicDataingestionrulesTwitterTwitterIngestionRuleId) | **Put** /api/v2/socialmedia/topics/{topicId}/dataingestionrules/twitter/{twitterIngestionRuleId} | Update the X (formally Twitter) data ingestion rule. |



## DeleteSocialmediaEscalationrule

> void DeleteSocialmediaEscalationrule (string escalationRuleId)


Delete an escalation rule.

Requires ANY permissions: 

* socialmedia:escalationRules:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaEscalationruleExample
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
            var escalationRuleId = escalationRuleId_example;  // string | escalationRuleId

            try
            { 
                // Delete an escalation rule.
                apiInstance.DeleteSocialmediaEscalationrule(escalationRuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaEscalationrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **escalationRuleId** | **string**| escalationRuleId |  |

### Return type

void (empty response body)


## DeleteSocialmediaMessage

> void DeleteSocialmediaMessage (string messageId)


Delete a social media message.

DeleteSocialmediaMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* socialmedia:message:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaMessageExample
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
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Delete a social media message.
                apiInstance.DeleteSocialmediaMessage(messageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| messageId |  |

### Return type

void (empty response body)


## DeleteSocialmediaTopic

> void DeleteSocialmediaTopic (string topicId, bool? hardDelete = null)


Delete a social topic.

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


## DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId

> void DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId (string topicId, string instagramIngestionRuleId, bool? hardDelete = null)


Delete a Instagram data ingestion rule.

Requires ANY permissions: 

* socialmedia:instagramDataIngestionRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var hardDelete = true;  // bool? | Determines whether a Instagram data ingestion rule should be soft-deleted (have it's state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional)  (default to false)

            try
            { 
                // Delete a Instagram data ingestion rule.
                apiInstance.DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId(topicId, instagramIngestionRuleId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.DeleteSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **hardDelete** | **bool?**| Determines whether a Instagram data ingestion rule should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteSocialmediaTopicDataingestionrulesOpenOpenId

> void DeleteSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? hardDelete = null)


Delete a open data ingestion rule.

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


## GetSocialmediaAnalyticsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetSocialmediaAnalyticsAggregatesJob (string jobId)


Get status for async query for social media aggregates

Requires ANY permissions: 

* socialmedia:postAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaAnalyticsAggregatesJobExample
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
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for social media aggregates
                AsyncQueryStatus result = apiInstance.GetSocialmediaAnalyticsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaAnalyticsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetSocialmediaAnalyticsAggregatesJobResults

> [**SocialMediaAsyncAggregateQueryResponse**](SocialMediaAsyncAggregateQueryResponse) GetSocialmediaAnalyticsAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async social media query

Requires ANY permissions: 

* socialmedia:postAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaAnalyticsAggregatesJobResultsExample
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
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async social media query
                SocialMediaAsyncAggregateQueryResponse result = apiInstance.GetSocialmediaAnalyticsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaAnalyticsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |

### Return type

[**SocialMediaAsyncAggregateQueryResponse**](SocialMediaAsyncAggregateQueryResponse)


## GetSocialmediaAnalyticsMessagesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetSocialmediaAnalyticsMessagesJob (string jobId)


Get status for async query for social media messages job

Requires ANY permissions: 

* socialmedia:postDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaAnalyticsMessagesJobExample
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
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for social media messages job
                AsyncQueryStatus result = apiInstance.GetSocialmediaAnalyticsMessagesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaAnalyticsMessagesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetSocialmediaAnalyticsMessagesJobResults

> [**SocialMediaAsyncDetailQueryResponse**](SocialMediaAsyncDetailQueryResponse) GetSocialmediaAnalyticsMessagesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async social media messages query

Requires ANY permissions: 

* socialmedia:postDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaAnalyticsMessagesJobResultsExample
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
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async social media messages query
                SocialMediaAsyncDetailQueryResponse result = apiInstance.GetSocialmediaAnalyticsMessagesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaAnalyticsMessagesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |

### Return type

[**SocialMediaAsyncDetailQueryResponse**](SocialMediaAsyncDetailQueryResponse)


## GetSocialmediaEscalationrule

> [**EscalationRuleResponse**](EscalationRuleResponse) GetSocialmediaEscalationrule (string escalationRuleId)


Get a single escalation rule.

Requires ALL permissions: 

* socialmedia:escalationRules:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaEscalationruleExample
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
            var escalationRuleId = escalationRuleId_example;  // string | escalationRuleId

            try
            { 
                // Get a single escalation rule.
                EscalationRuleResponse result = apiInstance.GetSocialmediaEscalationrule(escalationRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaEscalationrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **escalationRuleId** | **string**| escalationRuleId |  |

### Return type

[**EscalationRuleResponse**](EscalationRuleResponse)


## GetSocialmediaEscalationrules

> [**SocialEscalationResponseEntityListing**](SocialEscalationResponseEntityListing) GetSocialmediaEscalationrules (string divisionId, int? pageNumber = null, int? pageSize = null)


Retrieve all escalation rules for a division.

Requires ANY permissions: 

* socialmedia:escalationRules:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaEscalationrulesExample
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
            var divisionId = divisionId_example;  // string | One division ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Retrieve all escalation rules for a division.
                SocialEscalationResponseEntityListing result = apiInstance.GetSocialmediaEscalationrules(divisionId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaEscalationrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| One division ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**SocialEscalationResponseEntityListing**](SocialEscalationResponseEntityListing)


## GetSocialmediaTopic

> [**SocialTopicResponse**](SocialTopicResponse) GetSocialmediaTopic (string topicId, bool? includeDeleted = null)


Get a single social topic.

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


## GetSocialmediaTopicDataingestionrules

> [**DataIngestionRuleResponseEntityListing**](DataIngestionRuleResponseEntityListing) GetSocialmediaTopicDataingestionrules (string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)


Retrieve all social topic data ingestion rules with pagination.

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
    public class GetSocialmediaTopicDataingestionrulesExample
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
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Retrieve all social topic data ingestion rules with pagination.
                DataIngestionRuleResponseEntityListing result = apiInstance.GetSocialmediaTopicDataingestionrules(topicId, pageNumber, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**DataIngestionRuleResponseEntityListing**](DataIngestionRuleResponseEntityListing)


## GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, bool? includeDeleted = null)


Get a single Facebook data ingestion rule.

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


## GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId

> [**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId (string topicId, string instagramIngestionRuleId, bool? includeDeleted = null)


Get a single Instagram data ingestion rule.

Requires ALL permissions: 

* socialmedia:instagramDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get a single Instagram data ingestion rule.
                InstagramDataIngestionRuleResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId(topicId, instagramIngestionRuleId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse)


## GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion

> [**InstagramDataIngestionRuleVersionResponse**](InstagramDataIngestionRuleVersionResponse) GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion (string topicId, string instagramIngestionRuleId, string dataIngestionRuleVersion, bool? includeDeleted = null)


Get a single Instagram data ingestion rule version.

Requires ALL permissions: 

* socialmedia:instagramDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersionExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var dataIngestionRuleVersion = dataIngestionRuleVersion_example;  // string | version
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted item in the result. (optional) 

            try
            { 
                // Get a single Instagram data ingestion rule version.
                InstagramDataIngestionRuleVersionResponse result = apiInstance.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion(topicId, instagramIngestionRuleId, dataIngestionRuleVersion, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **dataIngestionRuleVersion** | **string**| version |  |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted item in the result. | [optional]  |

### Return type

[**InstagramDataIngestionRuleVersionResponse**](InstagramDataIngestionRuleVersionResponse)


## GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions

> [**InstagramDataIngestionRuleVersionResponseEntityListing**](InstagramDataIngestionRuleVersionResponseEntityListing) GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions (string topicId, string instagramIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null)


Get the Instagram data ingestion rule versions.

Requires ALL permissions: 

* socialmedia:instagramDataIngestionRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersionsExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeDeleted = true;  // bool? | Determines whether to include soft-deleted items in the result. (optional) 

            try
            { 
                // Get the Instagram data ingestion rule versions.
                InstagramDataIngestionRuleVersionResponseEntityListing result = apiInstance.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions(topicId, instagramIngestionRuleId, pageNumber, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeDeleted** | **bool?**| Determines whether to include soft-deleted items in the result. | [optional]  |

### Return type

[**InstagramDataIngestionRuleVersionResponseEntityListing**](InstagramDataIngestionRuleVersionResponseEntityListing)


## GetSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) GetSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, bool? includeDeleted = null)


Get a single open data ingestion rule.

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


## PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId

> [**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse) PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId (string topicId, string instagramIngestionRuleId, DataIngestionRuleStatusPatchRequest body = null)


Update the status of a Instagram data ingestion rule.

Requires ALL permissions: 

* socialmedia:instagramDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var body = new DataIngestionRuleStatusPatchRequest(); // DataIngestionRuleStatusPatchRequest |  (optional) 

            try
            { 
                // Update the status of a Instagram data ingestion rule.
                InstagramDataIngestionRuleResponse result = apiInstance.PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId(topicId, instagramIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PatchSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **body** | [**DataIngestionRuleStatusPatchRequest**](DataIngestionRuleStatusPatchRequest)|  | [optional]  |

### Return type

[**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse)


## PatchSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PatchSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, DataIngestionRuleStatusPatchRequest body = null)


Update the status of a open data ingestion rule.

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


## PostSocialmediaAnalyticsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostSocialmediaAnalyticsAggregatesJobs (SocialMediaAsyncAggregationQuery body)


Query for social media aggregates asynchronously

Requires ANY permissions: 

* socialmedia:postAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaAnalyticsAggregatesJobsExample
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
            var body = new SocialMediaAsyncAggregationQuery(); // SocialMediaAsyncAggregationQuery | query

            try
            { 
                // Query for social media aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostSocialmediaAnalyticsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaAnalyticsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SocialMediaAsyncAggregationQuery**](SocialMediaAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostSocialmediaAnalyticsMessagesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostSocialmediaAnalyticsMessagesJobs (SocialMediaAsyncDetailQuery body)


Query for social media messages asynchronously

Requires ANY permissions: 

* socialmedia:postDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaAnalyticsMessagesJobsExample
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
            var body = new SocialMediaAsyncDetailQuery(); // SocialMediaAsyncDetailQuery | query

            try
            { 
                // Query for social media messages asynchronously
                AsyncQueryResponse result = apiInstance.PostSocialmediaAnalyticsMessagesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaAnalyticsMessagesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SocialMediaAsyncDetailQuery**](SocialMediaAsyncDetailQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostSocialmediaEscalationrules

> [**EscalationRuleResponse**](EscalationRuleResponse) PostSocialmediaEscalationrules (EscalationRuleRequest body = null)


Create an escalation rule.

Requires ANY permissions: 

* socialmedia:escalationRules:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaEscalationrulesExample
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
            var body = new EscalationRuleRequest(); // EscalationRuleRequest |  (optional) 

            try
            { 
                // Create an escalation rule.
                EscalationRuleResponse result = apiInstance.PostSocialmediaEscalationrules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaEscalationrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EscalationRuleRequest**](EscalationRuleRequest)|  | [optional]  |

### Return type

[**EscalationRuleResponse**](EscalationRuleResponse)


## PostSocialmediaEscalationsMessages

> [**ManualEscalationResponse**](ManualEscalationResponse) PostSocialmediaEscalationsMessages (string divisionId, ManualEscalationRequest body = null)


Escalate message to a conversation manually

Requires ANY permissions: 

* socialmedia:message:escalate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaEscalationsMessagesExample
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
            var divisionId = divisionId_example;  // string | One division ID
            var body = new ManualEscalationRequest(); // ManualEscalationRequest |  (optional) 

            try
            { 
                // Escalate message to a conversation manually
                ManualEscalationResponse result = apiInstance.PostSocialmediaEscalationsMessages(divisionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaEscalationsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| One division ID |  |
| **body** | [**ManualEscalationRequest**](ManualEscalationRequest)|  | [optional]  |

### Return type

[**ManualEscalationResponse**](ManualEscalationResponse)


## PostSocialmediaTopicDataingestionrulesFacebook

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesFacebook (string topicId, FacebookDataIngestionRuleRequest body = null)


Create an Facebook data ingestion rule.

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


## PostSocialmediaTopicDataingestionrulesInstagram

> [**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesInstagram (string topicId, InstagramDataIngestionRuleRequest body = null)


Create an Instagram data ingestion rule.

Requires ANY permissions: 

* socialmedia:instagramDataIngestionRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesInstagramExample
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
            var body = new InstagramDataIngestionRuleRequest(); // InstagramDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Create an Instagram data ingestion rule.
                InstagramDataIngestionRuleResponse result = apiInstance.PostSocialmediaTopicDataingestionrulesInstagram(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesInstagram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **body** | [**InstagramDataIngestionRuleRequest**](InstagramDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse)


## PostSocialmediaTopicDataingestionrulesOpen

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesOpen (string topicId, OpenDataIngestionRuleRequest body = null)


Create an open data ingestion rule.

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


## PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk

> [**OpenSocialNormalizedMessageEntityListing**](OpenSocialNormalizedMessageEntityListing) PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk (string topicId, string ruleId, List<OpenSocialMediaNormalizedMessage> body)


Ingest a list of Open Social Messages

Ingest a list of open social messages to an ingestion rule on a topic. This endpoint will ingest and enrich these messages.  In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least social scope.

Requires ALL permissions: 

* socialmedia:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulkExample
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
            var topicId = topicId_example;  // string | Topic ID
            var ruleId = ruleId_example;  // string | Data Ingestion Rule ID
            var body = new List<OpenSocialMediaNormalizedMessage>(); // List<OpenSocialMediaNormalizedMessage> | NormalizedMessage

            try
            { 
                // Ingest a list of Open Social Messages
                OpenSocialNormalizedMessageEntityListing result = apiInstance.PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk(topicId, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesOpenRuleIdMessagesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| Topic ID |  |
| **ruleId** | **string**| Data Ingestion Rule ID |  |
| **body** | [**List<OpenSocialMediaNormalizedMessage>**](OpenSocialMediaNormalizedMessage)| NormalizedMessage |  |

### Return type

[**OpenSocialNormalizedMessageEntityListing**](OpenSocialNormalizedMessageEntityListing)


## PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk

> [**OpenSocialReactionsNormalizedEventEntityListing**](OpenSocialReactionsNormalizedEventEntityListing) PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk (string topicId, string ruleId, OpenSocialMediaReactionsRequest body)


Ingest a list of Open Social Reactions

Ingest a list of open social reactions to an ingestion rule on a topic. This endpoint will ingest these reactions.  In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least social scope.

Requires ALL permissions: 

* socialmedia:reaction:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulkExample
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
            var topicId = topicId_example;  // string | Topic ID
            var ruleId = ruleId_example;  // string | Data Ingestion Rule ID
            var body = new OpenSocialMediaReactionsRequest(); // OpenSocialMediaReactionsRequest | NormalizedEvent

            try
            { 
                // Ingest a list of Open Social Reactions
                OpenSocialReactionsNormalizedEventEntityListing result = apiInstance.PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk(topicId, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTopicDataingestionrulesOpenRuleIdReactionsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| Topic ID |  |
| **ruleId** | **string**| Data Ingestion Rule ID |  |
| **body** | [**OpenSocialMediaReactionsRequest**](OpenSocialMediaReactionsRequest)| NormalizedEvent |  |

### Return type

[**OpenSocialReactionsNormalizedEventEntityListing**](OpenSocialReactionsNormalizedEventEntityListing)


## PostSocialmediaTopicDataingestionrulesTwitter

> [**TwitterDataIngestionRuleResponse**](TwitterDataIngestionRuleResponse) PostSocialmediaTopicDataingestionrulesTwitter (string topicId, TwitterDataIngestionRuleRequest body = null)


Create an twitter data ingestion rule.

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


## PostSocialmediaTwitterHistoricalTweets

> [**TwitterDataHistoricalTweetResponse**](TwitterDataHistoricalTweetResponse) PostSocialmediaTwitterHistoricalTweets (TwitterDataHistoricalTweetRequest body)


Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.

Requires ALL permissions: 

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
    public class PostSocialmediaTwitterHistoricalTweetsExample
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
            var body = new TwitterDataHistoricalTweetRequest(); // TwitterDataHistoricalTweetRequest | TwitterDataHistoricalTweetRequest

            try
            { 
                // Retrieves historical tweet count for search terms, optional countries list and the current limit and usage for the organization.
                TwitterDataHistoricalTweetResponse result = apiInstance.PostSocialmediaTwitterHistoricalTweets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PostSocialmediaTwitterHistoricalTweets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TwitterDataHistoricalTweetRequest**](TwitterDataHistoricalTweetRequest)| TwitterDataHistoricalTweetRequest |  |

### Return type

[**TwitterDataHistoricalTweetResponse**](TwitterDataHistoricalTweetResponse)


## PutSocialmediaEscalationrule

> [**EscalationRuleResponse**](EscalationRuleResponse) PutSocialmediaEscalationrule (string escalationRuleId, EscalationRuleRequest body = null)


Update the escalation rule.

Requires ALL permissions: 

* socialmedia:escalationRules:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSocialmediaEscalationruleExample
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
            var escalationRuleId = escalationRuleId_example;  // string | escalationRuleId
            var body = new EscalationRuleRequest(); // EscalationRuleRequest |  (optional) 

            try
            { 
                // Update the escalation rule.
                EscalationRuleResponse result = apiInstance.PutSocialmediaEscalationrule(escalationRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PutSocialmediaEscalationrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **escalationRuleId** | **string**| escalationRuleId |  |
| **body** | [**EscalationRuleRequest**](EscalationRuleRequest)|  | [optional]  |

### Return type

[**EscalationRuleResponse**](EscalationRuleResponse)


## PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId

> [**FacebookDataIngestionRuleResponse**](FacebookDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesFacebookFacebookIngestionRuleId (string topicId, string facebookIngestionRuleId, FacebookDataIngestionRuleRequest body = null)


Update the Facebook data ingestion rule.

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


## PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId

> [**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId (string topicId, string instagramIngestionRuleId, InstagramDataIngestionRuleRequest body = null)


Update the Instagram data ingestion rule.

Requires ALL permissions: 

* socialmedia:instagramDataIngestionRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleIdExample
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
            var instagramIngestionRuleId = instagramIngestionRuleId_example;  // string | instagramIngestionRuleId
            var body = new InstagramDataIngestionRuleRequest(); // InstagramDataIngestionRuleRequest |  (optional) 

            try
            { 
                // Update the Instagram data ingestion rule.
                InstagramDataIngestionRuleResponse result = apiInstance.PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId(topicId, instagramIngestionRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.PutSocialmediaTopicDataingestionrulesInstagramInstagramIngestionRuleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| topicId |  |
| **instagramIngestionRuleId** | **string**| instagramIngestionRuleId |  |
| **body** | [**InstagramDataIngestionRuleRequest**](InstagramDataIngestionRuleRequest)|  | [optional]  |

### Return type

[**InstagramDataIngestionRuleResponse**](InstagramDataIngestionRuleResponse)


## PutSocialmediaTopicDataingestionrulesOpenOpenId

> [**OpenDataIngestionRuleResponse**](OpenDataIngestionRuleResponse) PutSocialmediaTopicDataingestionrulesOpenOpenId (string topicId, string openId, OpenDataIngestionRuleRequest body = null)


Update the open data ingestion rule.

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


_PureCloudPlatform.Client.V2 244.0.0_
