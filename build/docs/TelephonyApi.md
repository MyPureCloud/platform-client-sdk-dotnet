# TelephonyApi

## PureCloudPlatform.Client.V2.Api.TelephonyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTelephonyOrganizationLinkTargetOrganizationId**](#DeleteTelephonyOrganizationLinkTargetOrganizationId) | **Delete** /api/v2/telephony/organization/link/{targetOrganizationId} | Delete a link |
| [**GetTelephonyAgentGreetings**](#GetTelephonyAgentGreetings) | **Get** /api/v2/telephony/agents/{agentId}/greetings | Get an agent&#39;s greetings. |
| [**GetTelephonyAgentsGreetingsMe**](#GetTelephonyAgentsGreetingsMe) | **Get** /api/v2/telephony/agents/greetings/me | Get the agent&#39;s own greetings. |
| [**GetTelephonyCallsMetrics**](#GetTelephonyCallsMetrics) | **Get** /api/v2/telephony/calls/metrics | Get the concurrent call metrics for a given organization. |
| [**GetTelephonyMediaregions**](#GetTelephonyMediaregions) | **Get** /api/v2/telephony/mediaregions | Retrieve the list of AWS regions media can stream through. |
| [**GetTelephonyNumbersRouting**](#GetTelephonyNumbersRouting) | **Get** /api/v2/telephony/numbers/routing | Get Number Routings by organizationId |
| [**GetTelephonyOrganizationLink**](#GetTelephonyOrganizationLink) | **Get** /api/v2/telephony/organization/link | Get organization links |
| [**GetTelephonyOrganizationLinkRegions**](#GetTelephonyOrganizationLinkRegions) | **Get** /api/v2/telephony/organization/link/regions | Get all the replica regions by primary region |
| [**GetTelephonySettings**](#GetTelephonySettings) | **Get** /api/v2/telephony/settings | Get the global telephony configuration. |
| [**GetTelephonySipmessagesConversation**](#GetTelephonySipmessagesConversation) | **Get** /api/v2/telephony/sipmessages/conversations/{conversationId} | Get a SIP message. |
| [**GetTelephonySipmessagesConversationHeaders**](#GetTelephonySipmessagesConversationHeaders) | **Get** /api/v2/telephony/sipmessages/conversations/{conversationId}/headers | Get SIP headers. |
| [**GetTelephonySiptraces**](#GetTelephonySiptraces) | **Get** /api/v2/telephony/siptraces | Fetch SIP metadata |
| [**GetTelephonySiptracesDownloadDownloadId**](#GetTelephonySiptracesDownloadDownloadId) | **Get** /api/v2/telephony/siptraces/download/{downloadId} | Get signed S3 URL for a pcap download |
| [**PatchTelephonyOrganizationLinkApproveRequestingOrganizationId**](#PatchTelephonyOrganizationLinkApproveRequestingOrganizationId) | **Patch** /api/v2/telephony/organization/link/approve/{requestingOrganizationId} | Approving a requested link |
| [**PostTelephonyNumbersRouting**](#PostTelephonyNumbersRouting) | **Post** /api/v2/telephony/numbers/routing | Update the routing of numbers for one or multiple organizations |
| [**PostTelephonyNumbersRoutingAll**](#PostTelephonyNumbersRoutingAll) | **Post** /api/v2/telephony/numbers/routing/all | Re-route all numbers on an organization |
| [**PostTelephonyNumbersRoutingReset**](#PostTelephonyNumbersRoutingReset) | **Post** /api/v2/telephony/numbers/routing/reset | Reset routing for organization |
| [**PostTelephonyOrganizationLink**](#PostTelephonyOrganizationLink) | **Post** /api/v2/telephony/organization/link | Create a link with an organization |
| [**PostTelephonySiptracesDownload**](#PostTelephonySiptracesDownload) | **Post** /api/v2/telephony/siptraces/download | Request a download of a pcap file to S3 |
| [**PutTelephonyAgentGreetings**](#PutTelephonyAgentGreetings) | **Put** /api/v2/telephony/agents/{agentId}/greetings | Updates an agent&#39;s greetings. |
| [**PutTelephonyAgentsGreetingsMe**](#PutTelephonyAgentsGreetingsMe) | **Put** /api/v2/telephony/agents/greetings/me | Updates the agent&#39;s own greetings. |
| [**PutTelephonySettings**](#PutTelephonySettings) | **Put** /api/v2/telephony/settings | Update the global telephony configuration. |



## DeleteTelephonyOrganizationLinkTargetOrganizationId

> void DeleteTelephonyOrganizationLinkTargetOrganizationId (string targetOrganizationId)


Delete a link

Requires ALL permissions: 

* telephony:organizationLink:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyOrganizationLinkTargetOrganizationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var targetOrganizationId = targetOrganizationId_example;  // string | targetOrganizationId

            try
            { 
                // Delete a link
                apiInstance.DeleteTelephonyOrganizationLinkTargetOrganizationId(targetOrganizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.DeleteTelephonyOrganizationLinkTargetOrganizationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **targetOrganizationId** | **string**| targetOrganizationId |  |

### Return type

void (empty response body)


## GetTelephonyAgentGreetings

> [**AgentGreeting**](AgentGreeting) GetTelephonyAgentGreetings (string agentId)


Get an agent's greetings.

Requires ANY permissions: 

* telephony:otherAgentGreeting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyAgentGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var agentId = agentId_example;  // string | User ID

            try
            { 
                // Get an agent's greetings.
                AgentGreeting result = apiInstance.GetTelephonyAgentGreetings(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyAgentGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| User ID |  |

### Return type

[**AgentGreeting**](AgentGreeting)


## GetTelephonyAgentsGreetingsMe

> [**SelfAgentGreeting**](SelfAgentGreeting) GetTelephonyAgentsGreetingsMe ()


Get the agent's own greetings.

Requires ANY permissions: 

* telephony:selfAgentGreeting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyAgentsGreetingsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();

            try
            { 
                // Get the agent's own greetings.
                SelfAgentGreeting result = apiInstance.GetTelephonyAgentsGreetingsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyAgentsGreetingsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**SelfAgentGreeting**](SelfAgentGreeting)


## GetTelephonyCallsMetrics

> [**OrganizationCallMetrics**](OrganizationCallMetrics) GetTelephonyCallsMetrics (string metricType = null)


Get the concurrent call metrics for a given organization.

Requires ANY permissions: 

* telephony:callMetrics:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyCallsMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var metricType = metricType_example;  // string | Flag to indicate metric type to fetch. (optional)  (default to cloud)

            try
            { 
                // Get the concurrent call metrics for a given organization.
                OrganizationCallMetrics result = apiInstance.GetTelephonyCallsMetrics(metricType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyCallsMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricType** | **string**| Flag to indicate metric type to fetch. | [optional] [default to cloud]<br />**Values**: cloud, premises |

### Return type

[**OrganizationCallMetrics**](OrganizationCallMetrics)


## GetTelephonyMediaregions

> [**MediaRegions**](MediaRegions) GetTelephonyMediaregions ()


Retrieve the list of AWS regions media can stream through.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyMediaregionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();

            try
            { 
                // Retrieve the list of AWS regions media can stream through.
                MediaRegions result = apiInstance.GetTelephonyMediaregions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyMediaregions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MediaRegions**](MediaRegions)


## GetTelephonyNumbersRouting

> [**NumberRoutingListing**](NumberRoutingListing) GetTelephonyNumbersRouting (string before = null, string after = null, string pageSize = null, string numberId = null, string activeRoutingOrganizationId = null, string ownerOrganizationId = null, string status = null)


Get Number Routings by organizationId

Requires ALL permissions: 

* telephony:numberRouting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyNumbersRoutingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var numberId = numberId_example;  // string | numberId (optional) 
            var activeRoutingOrganizationId = activeRoutingOrganizationId_example;  // string | activeRoutingOrganizationId (optional) 
            var ownerOrganizationId = ownerOrganizationId_example;  // string | ownerOrganizationId (optional) 
            var status = status_example;  // string | status (optional) 

            try
            { 
                // Get Number Routings by organizationId
                NumberRoutingListing result = apiInstance.GetTelephonyNumbersRouting(before, after, pageSize, numberId, activeRoutingOrganizationId, ownerOrganizationId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyNumbersRouting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **numberId** | **string**| numberId | [optional]  |
| **activeRoutingOrganizationId** | **string**| activeRoutingOrganizationId | [optional]  |
| **ownerOrganizationId** | **string**| ownerOrganizationId | [optional]  |
| **status** | **string**| status | [optional] <br />**Values**: Normal, Redirected, Pending |

### Return type

[**NumberRoutingListing**](NumberRoutingListing)


## GetTelephonyOrganizationLink

> [**List&lt;OrganizationLinkResponse&gt;**](OrganizationLinkResponse) GetTelephonyOrganizationLink ()


Get organization links

Requires ALL permissions: 

* telephony:organizationLink:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyOrganizationLinkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();

            try
            { 
                // Get organization links
                List<OrganizationLinkResponse> result = apiInstance.GetTelephonyOrganizationLink();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyOrganizationLink: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<OrganizationLinkResponse>**](OrganizationLinkResponse)


## GetTelephonyOrganizationLinkRegions

> [**List&lt;RegionResponse&gt;**](RegionResponse) GetTelephonyOrganizationLinkRegions ()


Get all the replica regions by primary region

Requires ALL permissions: 

* telephony:organizationLink:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyOrganizationLinkRegionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();

            try
            { 
                // Get all the replica regions by primary region
                List<RegionResponse> result = apiInstance.GetTelephonyOrganizationLinkRegions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonyOrganizationLinkRegions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<RegionResponse>**](RegionResponse)


## GetTelephonySettings

> [**TelephonySettings**](TelephonySettings) GetTelephonySettings ()


Get the global telephony configuration.

Requires ANY permissions: 

* telephony:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();

            try
            { 
                // Get the global telephony configuration.
                TelephonySettings result = apiInstance.GetTelephonySettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TelephonySettings**](TelephonySettings)


## GetTelephonySipmessagesConversation

> [**Callmessage**](Callmessage) GetTelephonySipmessagesConversation (string conversationId)


Get a SIP message.

Get the raw form of the SIP message

Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySipmessagesConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var conversationId = conversationId_example;  // string | Conversation id

            try
            { 
                // Get a SIP message.
                Callmessage result = apiInstance.GetTelephonySipmessagesConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySipmessagesConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation id |  |

### Return type

[**Callmessage**](Callmessage)


## GetTelephonySipmessagesConversationHeaders

> [**Callheader**](Callheader) GetTelephonySipmessagesConversationHeaders (string conversationId, List<string> keys = null)


Get SIP headers.

Get parsed SIP headers. Returns specific headers if key query parameters are added.

Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySipmessagesConversationHeadersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var conversationId = conversationId_example;  // string | Conversation id
            var keys = new List<string>(); // List<string> | comma-separated list of header identifiers to query. e.g. ruri,to,from (optional) 

            try
            { 
                // Get SIP headers.
                Callheader result = apiInstance.GetTelephonySipmessagesConversationHeaders(conversationId, keys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySipmessagesConversationHeaders: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation id |  |
| **keys** | [**List<string>**](string)| comma-separated list of header identifiers to query. e.g. ruri,to,from | [optional]  |

### Return type

[**Callheader**](Callheader)


## GetTelephonySiptraces

> [**SipSearchResult**](SipSearchResult) GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)


Fetch SIP metadata

Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected

Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySiptracesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var dateStart = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
            var dateEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
            var callId = callId_example;  // string | unique identification of the placed call (optional) 
            var toUser = toUser_example;  // string | User to who the call was placed (optional) 
            var fromUser = fromUser_example;  // string | user who placed the call (optional) 
            var conversationId = conversationId_example;  // string | Unique identification of the conversation (optional) 

            try
            { 
                // Fetch SIP metadata
                SipSearchResult result = apiInstance.GetTelephonySiptraces(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySiptraces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dateStart** | **DateTime?**| Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |
| **dateEnd** | **DateTime?**| End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |
| **callId** | **string**| unique identification of the placed call | [optional]  |
| **toUser** | **string**| User to who the call was placed | [optional]  |
| **fromUser** | **string**| user who placed the call | [optional]  |
| **conversationId** | **string**| Unique identification of the conversation | [optional]  |

### Return type

[**SipSearchResult**](SipSearchResult)


## GetTelephonySiptracesDownloadDownloadId

> [**SignedUrlResponse**](SignedUrlResponse) GetTelephonySiptracesDownloadDownloadId (string downloadId)


Get signed S3 URL for a pcap download

Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySiptracesDownloadDownloadIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var downloadId = downloadId_example;  // string | unique id for the downloaded file in S3

            try
            { 
                // Get signed S3 URL for a pcap download
                SignedUrlResponse result = apiInstance.GetTelephonySiptracesDownloadDownloadId(downloadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySiptracesDownloadDownloadId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **downloadId** | **string**| unique id for the downloaded file in S3 |  |

### Return type

[**SignedUrlResponse**](SignedUrlResponse)


## PatchTelephonyOrganizationLinkApproveRequestingOrganizationId

> void PatchTelephonyOrganizationLinkApproveRequestingOrganizationId (string requestingOrganizationId, OrganizationLinkApprovalRequest body)


Approving a requested link

Requires ALL permissions: 

* telephony:organizationLink:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTelephonyOrganizationLinkApproveRequestingOrganizationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var requestingOrganizationId = requestingOrganizationId_example;  // string | requestingOrganizationId
            var body = new OrganizationLinkApprovalRequest(); // OrganizationLinkApprovalRequest | Approval request body

            try
            { 
                // Approving a requested link
                apiInstance.PatchTelephonyOrganizationLinkApproveRequestingOrganizationId(requestingOrganizationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PatchTelephonyOrganizationLinkApproveRequestingOrganizationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **requestingOrganizationId** | **string**| requestingOrganizationId |  |
| **body** | [**OrganizationLinkApprovalRequest**](OrganizationLinkApprovalRequest)| Approval request body |  |

### Return type

void (empty response body)


## PostTelephonyNumbersRouting

> void PostTelephonyNumbersRouting (List<NumberRoutingRequest> body)


Update the routing of numbers for one or multiple organizations

Requires ALL permissions: 

* telephony:numberRouting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyNumbersRoutingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new List<NumberRoutingRequest>(); // List<NumberRoutingRequest> | drRoutingList

            try
            { 
                // Update the routing of numbers for one or multiple organizations
                apiInstance.PostTelephonyNumbersRouting(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonyNumbersRouting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<NumberRoutingRequest>**](NumberRoutingRequest)| drRoutingList |  |

### Return type

void (empty response body)


## PostTelephonyNumbersRoutingAll

> void PostTelephonyNumbersRoutingAll (DisasterRecoveryAllRoutingRequest body)


Re-route all numbers on an organization

Requires ALL permissions: 

* telephony:numberRouting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyNumbersRoutingAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new DisasterRecoveryAllRoutingRequest(); // DisasterRecoveryAllRoutingRequest | Value for all routing request body

            try
            { 
                // Re-route all numbers on an organization
                apiInstance.PostTelephonyNumbersRoutingAll(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonyNumbersRoutingAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DisasterRecoveryAllRoutingRequest**](DisasterRecoveryAllRoutingRequest)| Value for all routing request body |  |

### Return type

void (empty response body)


## PostTelephonyNumbersRoutingReset

> void PostTelephonyNumbersRoutingReset (NumberRoutingResetOrganizationRequest body)


Reset routing for organization

Requires ALL permissions: 

* telephony:numberRouting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyNumbersRoutingResetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new NumberRoutingResetOrganizationRequest(); // NumberRoutingResetOrganizationRequest | Value for bulk routing request body

            try
            { 
                // Reset routing for organization
                apiInstance.PostTelephonyNumbersRoutingReset(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonyNumbersRoutingReset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**NumberRoutingResetOrganizationRequest**](NumberRoutingResetOrganizationRequest)| Value for bulk routing request body |  |

### Return type

void (empty response body)


## PostTelephonyOrganizationLink

> [**OrganizationLink**](OrganizationLink) PostTelephonyOrganizationLink (CreateOrganizationLink body)


Create a link with an organization

Requires ALL permissions: 

* telephony:organizationLink:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyOrganizationLinkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new CreateOrganizationLink(); // CreateOrganizationLink | CreateLinkOrg body

            try
            { 
                // Create a link with an organization
                OrganizationLink result = apiInstance.PostTelephonyOrganizationLink(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonyOrganizationLink: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateOrganizationLink**](CreateOrganizationLink)| CreateLinkOrg body |  |

### Return type

[**OrganizationLink**](OrganizationLink)


## PostTelephonySiptracesDownload

> [**SipDownloadResponse**](SipDownloadResponse) PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest)


Request a download of a pcap file to S3

Requires ALL permissions: 

* telephony:pcap:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonySiptracesDownloadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var sIPSearchPublicRequest = new SIPSearchPublicRequest(); // SIPSearchPublicRequest | 

            try
            { 
                // Request a download of a pcap file to S3
                SipDownloadResponse result = apiInstance.PostTelephonySiptracesDownload(sIPSearchPublicRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonySiptracesDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sIPSearchPublicRequest** | [**SIPSearchPublicRequest**](SIPSearchPublicRequest)|  |  |

### Return type

[**SipDownloadResponse**](SipDownloadResponse)


## PutTelephonyAgentGreetings

> [**AgentGreeting**](AgentGreeting) PutTelephonyAgentGreetings (string agentId, AgentGreeting body)


Updates an agent's greetings.

Requires ANY permissions: 

* telephony:otherAgentGreeting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyAgentGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var agentId = agentId_example;  // string | User ID
            var body = new AgentGreeting(); // AgentGreeting | Agent Greeting

            try
            { 
                // Updates an agent's greetings.
                AgentGreeting result = apiInstance.PutTelephonyAgentGreetings(agentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PutTelephonyAgentGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| User ID |  |
| **body** | [**AgentGreeting**](AgentGreeting)| Agent Greeting |  |

### Return type

[**AgentGreeting**](AgentGreeting)


## PutTelephonyAgentsGreetingsMe

> [**SelfAgentGreeting**](SelfAgentGreeting) PutTelephonyAgentsGreetingsMe (SelfAgentGreeting body)


Updates the agent's own greetings.

Requires ANY permissions: 

* telephony:selfAgentGreeting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyAgentsGreetingsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new SelfAgentGreeting(); // SelfAgentGreeting | Agent Greeting

            try
            { 
                // Updates the agent's own greetings.
                SelfAgentGreeting result = apiInstance.PutTelephonyAgentsGreetingsMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PutTelephonyAgentsGreetingsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SelfAgentGreeting**](SelfAgentGreeting)| Agent Greeting |  |

### Return type

[**SelfAgentGreeting**](SelfAgentGreeting)


## PutTelephonySettings

> [**TelephonySettings**](TelephonySettings) PutTelephonySettings (TelephonySettings body)


Update the global telephony configuration.

Requires ANY permissions: 

* telephony:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonySettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyApi();
            var body = new TelephonySettings(); // TelephonySettings | Telephony

            try
            { 
                // Update the global telephony configuration.
                TelephonySettings result = apiInstance.PutTelephonySettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PutTelephonySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TelephonySettings**](TelephonySettings)| Telephony |  |

### Return type

[**TelephonySettings**](TelephonySettings)


_PureCloudPlatform.Client.V2 268.0.0_
