# TelephonyApi

## PureCloudPlatform.Client.V2.Api.TelephonyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetTelephonyAgentGreetings**](#GetTelephonyAgentGreetings) | **Get** /api/v2/telephony/agents/{agentId}/greetings | Get an agent&#39;s greetings. |
| [**GetTelephonyAgentsGreetingsMe**](#GetTelephonyAgentsGreetingsMe) | **Get** /api/v2/telephony/agents/greetings/me | Get the agent&#39;s own greetings. |
| [**GetTelephonyMediaregions**](#GetTelephonyMediaregions) | **Get** /api/v2/telephony/mediaregions | Retrieve the list of AWS regions media can stream through. |
| [**GetTelephonySipmessagesConversation**](#GetTelephonySipmessagesConversation) | **Get** /api/v2/telephony/sipmessages/conversations/{conversationId} | Get a SIP message. |
| [**GetTelephonySipmessagesConversationHeaders**](#GetTelephonySipmessagesConversationHeaders) | **Get** /api/v2/telephony/sipmessages/conversations/{conversationId}/headers | Get SIP headers. |
| [**GetTelephonySiptraces**](#GetTelephonySiptraces) | **Get** /api/v2/telephony/siptraces | Fetch SIP metadata |
| [**GetTelephonySiptracesDownloadDownloadId**](#GetTelephonySiptracesDownloadDownloadId) | **Get** /api/v2/telephony/siptraces/download/{downloadId} | Get signed S3 URL for a pcap download |
| [**PostTelephonySiptracesDownload**](#PostTelephonySiptracesDownload) | **Post** /api/v2/telephony/siptraces/download | Request a download of a pcap file to S3 |
| [**PutTelephonyAgentGreetings**](#PutTelephonyAgentGreetings) | **Put** /api/v2/telephony/agents/{agentId}/greetings | Updates an agent&#39;s greetings. |
| [**PutTelephonyAgentsGreetingsMe**](#PutTelephonyAgentsGreetingsMe) | **Put** /api/v2/telephony/agents/greetings/me | Updates the agent&#39;s own greetings. |



## GetTelephonyAgentGreetings

> [**AgentGreeting**](AgentGreeting) GetTelephonyAgentGreetings (string agentId)


Get an agent's greetings.

GetTelephonyAgentGreetings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

GetTelephonyAgentsGreetingsMe is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

PutTelephonyAgentGreetings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

PutTelephonyAgentsGreetingsMe is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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


_PureCloudPlatform.Client.V2 239.1.0_
