# SearchApi

## PureCloudPlatform.Client.V2.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDocumentationGknSearch**](#GetDocumentationGknSearch) | **Get** /api/v2/documentation/gkn/search | Search gkn documentation using the q64 value returned from a previous search |
| [**GetDocumentationSearch**](#GetDocumentationSearch) | **Get** /api/v2/documentation/search | Search documentation using the q64 value returned from a previous search |
| [**GetGroupsSearch**](#GetGroupsSearch) | **Get** /api/v2/groups/search | Search groups using the q64 value returned from a previous search |
| [**GetLocationsSearch**](#GetLocationsSearch) | **Get** /api/v2/locations/search | Search locations using the q64 value returned from a previous search |
| [**GetSearch**](#GetSearch) | **Get** /api/v2/search | Search using the q64 value returned from a previous search. |
| [**GetSearchSuggest**](#GetSearchSuggest) | **Get** /api/v2/search/suggest | Suggest resources using the q64 value returned from a previous suggest query. |
| [**GetTelephonyProvidersEdgesSitesSearch**](#GetTelephonyProvidersEdgesSitesSearch) | **Get** /api/v2/telephony/providers/edges/sites/search | Search sites using the q64 value returned from a previous search |
| [**GetUsersSearch**](#GetUsersSearch) | **Get** /api/v2/users/search | Search users using the q64 value returned from a previous search |
| [**GetVoicemailSearch**](#GetVoicemailSearch) | **Get** /api/v2/voicemail/search | Search voicemails using the q64 value returned from a previous search |
| [**PostAnalyticsConversationsTranscriptsQuery**](#PostAnalyticsConversationsTranscriptsQuery) | **Post** /api/v2/analytics/conversations/transcripts/query | Search resources. |
| [**PostConversationsParticipantsAttributesSearch**](#PostConversationsParticipantsAttributesSearch) | **Post** /api/v2/conversations/participants/attributes/search | Search conversations |
| [**PostDocumentationAllSearch**](#PostDocumentationAllSearch) | **Post** /api/v2/documentation/all/search | Search all documents |
| [**PostDocumentationGknSearch**](#PostDocumentationGknSearch) | **Post** /api/v2/documentation/gkn/search | Search gkn documentation |
| [**PostDocumentationSearch**](#PostDocumentationSearch) | **Post** /api/v2/documentation/search | Search documentation |
| [**PostGroupsSearch**](#PostGroupsSearch) | **Post** /api/v2/groups/search | Search groups |
| [**PostKnowledgeKnowledgebaseSearch**](#PostKnowledgeKnowledgebaseSearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search | Search Documents |
| [**PostLocationsSearch**](#PostLocationsSearch) | **Post** /api/v2/locations/search | Search locations |
| [**PostSearch**](#PostSearch) | **Post** /api/v2/search | Search resources. |
| [**PostSearchSuggest**](#PostSearchSuggest) | **Post** /api/v2/search/suggest | Suggest resources. |
| [**PostSpeechandtextanalyticsTranscriptsSearch**](#PostSpeechandtextanalyticsTranscriptsSearch) | **Post** /api/v2/speechandtextanalytics/transcripts/search | Search resources. |
| [**PostTeamsSearch**](#PostTeamsSearch) | **Post** /api/v2/teams/search | Search resources. |
| [**PostTelephonyProvidersEdgesSitesSearch**](#PostTelephonyProvidersEdgesSitesSearch) | **Post** /api/v2/telephony/providers/edges/sites/search | Search sites |
| [**PostUsersSearch**](#PostUsersSearch) | **Post** /api/v2/users/search | Search users |
| [**PostUsersSearchConversationTarget**](#PostUsersSearchConversationTarget) | **Post** /api/v2/users/search/conversation/target | Search users as conversation targets |
| [**PostUsersSearchQueuemembersManage**](#PostUsersSearchQueuemembersManage) | **Post** /api/v2/users/search/queuemembers/manage | Search manage queue member |
| [**PostUsersSearchTeamsAssign**](#PostUsersSearchTeamsAssign) | **Post** /api/v2/users/search/teams/assign | Search users assigned to teams |
| [**PostVoicemailSearch**](#PostVoicemailSearch) | **Post** /api/v2/voicemail/search | Search voicemails |



## GetDocumentationGknSearch

> [**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse) GetDocumentationGknSearch (string q64)


Search gkn documentation using the q64 value returned from a previous search

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDocumentationGknSearchExample
    {
        public void main()
        { 

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64

            try
            { 
                // Search gkn documentation using the q64 value returned from a previous search
                GKNDocumentationSearchResponse result = apiInstance.GetDocumentationGknSearch(q64);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetDocumentationGknSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |

### Return type

[**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse)


## GetDocumentationSearch

> [**DocumentationSearchResponse**](DocumentationSearchResponse) GetDocumentationSearch (string q64)


Search documentation using the q64 value returned from a previous search

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDocumentationSearchExample
    {
        public void main()
        { 

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64

            try
            { 
                // Search documentation using the q64 value returned from a previous search
                DocumentationSearchResponse result = apiInstance.GetDocumentationSearch(q64);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetDocumentationSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |

### Return type

[**DocumentationSearchResponse**](DocumentationSearchResponse)


## GetGroupsSearch

> [**GroupsSearchResponse**](GroupsSearchResponse) GetGroupsSearch (string q64, List<string> expand = null)


Search groups using the q64 value returned from a previous search

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search groups using the q64 value returned from a previous search
                GroupsSearchResponse result = apiInstance.GetGroupsSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse)


## GetLocationsSearch

> [**LocationsSearchResponse**](LocationsSearchResponse) GetLocationsSearch (string q64, List<string> expand = null)


Search locations using the q64 value returned from a previous search

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLocationsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | Provides more details about a specified resource (optional) 

            try
            { 
                // Search locations using the q64 value returned from a previous search
                LocationsSearchResponse result = apiInstance.GetLocationsSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetLocationsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| Provides more details about a specified resource | [optional] <br />**Values**: images, addressVerificationDetails |

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse)


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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message );
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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.GetSearchSuggest: " + e.Message );
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


## GetTelephonyProvidersEdgesSitesSearch

> [**SitesSearchResponse**](SitesSearchResponse) GetTelephonyProvidersEdgesSitesSearch (string q64, List<string> expand = null)


Search sites using the q64 value returned from a previous search

Requires ANY permissions: 

* telephony:plugin:all
* telephony:sites:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSitesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search sites using the q64 value returned from a previous search
                SitesSearchResponse result = apiInstance.GetTelephonyProvidersEdgesSitesSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetTelephonyProvidersEdgesSitesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |

### Return type

[**SitesSearchResponse**](SitesSearchResponse)


## GetUsersSearch

> [**UsersSearchResponse**](UsersSearchResponse) GetUsersSearch (string q64, List<string> expand = null, string integrationPresenceSource = null)


Search users using the q64 value returned from a previous search

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
    public class GetUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | integrationPresenceSource (optional) 

            try
            { 
                // Search users using the q64 value returned from a previous search
                UsersSearchResponse result = apiInstance.GetUsersSearch(q64, expand, integrationPresenceSource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetUsersSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |
| **integrationPresenceSource** | **string**| integrationPresenceSource | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |

### Return type

[**UsersSearchResponse**](UsersSearchResponse)


## GetVoicemailSearch

> [**VoicemailsSearchResponse**](VoicemailsSearchResponse) GetVoicemailSearch (string q64, List<string> expand = null)


Search voicemails using the q64 value returned from a previous search

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search voicemails using the q64 value returned from a previous search
                VoicemailsSearchResponse result = apiInstance.GetVoicemailSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetVoicemailSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse)


## PostAnalyticsConversationsTranscriptsQuery

> [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse) PostAnalyticsConversationsTranscriptsQuery (TranscriptConversationDetailSearchRequest body)


Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsTranscriptsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new TranscriptConversationDetailSearchRequest(); // TranscriptConversationDetailSearchRequest | Search request options

            try
            { 
                // Search resources.
                AnalyticsConversationWithoutAttributesMultiGetResponse result = apiInstance.PostAnalyticsConversationsTranscriptsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostAnalyticsConversationsTranscriptsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptConversationDetailSearchRequest**](TranscriptConversationDetailSearchRequest)| Search request options |  |

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse)


## PostConversationsParticipantsAttributesSearch

> [**JsonCursorSearchResponse**](JsonCursorSearchResponse) PostConversationsParticipantsAttributesSearch (ConversationParticipantSearchRequest body)


Search conversations

Requires ANY permissions: 

* conversation:participant:attributesview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsParticipantsAttributesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new ConversationParticipantSearchRequest(); // ConversationParticipantSearchRequest | Search request options

            try
            { 
                // Search conversations
                JsonCursorSearchResponse result = apiInstance.PostConversationsParticipantsAttributesSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostConversationsParticipantsAttributesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationParticipantSearchRequest**](ConversationParticipantSearchRequest)| Search request options |  |

### Return type

[**JsonCursorSearchResponse**](JsonCursorSearchResponse)


## PostDocumentationAllSearch

> [**JsonNodeSearchResponse**](JsonNodeSearchResponse) PostDocumentationAllSearch (DocumentationV2SearchRequest body)


Search all documents

PostDocumentationAllSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDocumentationAllSearchExample
    {
        public void main()
        { 

            var apiInstance = new SearchApi();
            var body = new DocumentationV2SearchRequest(); // DocumentationV2SearchRequest | Search request options

            try
            { 
                // Search all documents
                JsonNodeSearchResponse result = apiInstance.PostDocumentationAllSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostDocumentationAllSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DocumentationV2SearchRequest**](DocumentationV2SearchRequest)| Search request options |  |

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse)


## PostDocumentationGknSearch

> [**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse) PostDocumentationGknSearch (GKNDocumentationSearchRequest body)


Search gkn documentation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDocumentationGknSearchExample
    {
        public void main()
        { 

            var apiInstance = new SearchApi();
            var body = new GKNDocumentationSearchRequest(); // GKNDocumentationSearchRequest | Search request options

            try
            { 
                // Search gkn documentation
                GKNDocumentationSearchResponse result = apiInstance.PostDocumentationGknSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostDocumentationGknSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GKNDocumentationSearchRequest**](GKNDocumentationSearchRequest)| Search request options |  |

### Return type

[**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse)


## PostDocumentationSearch

> [**DocumentationSearchResponse**](DocumentationSearchResponse) PostDocumentationSearch (DocumentationSearchRequest body)


Search documentation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDocumentationSearchExample
    {
        public void main()
        { 

            var apiInstance = new SearchApi();
            var body = new DocumentationSearchRequest(); // DocumentationSearchRequest | Search request options

            try
            { 
                // Search documentation
                DocumentationSearchResponse result = apiInstance.PostDocumentationSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostDocumentationSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DocumentationSearchRequest**](DocumentationSearchRequest)| Search request options |  |

### Return type

[**DocumentationSearchResponse**](DocumentationSearchResponse)


## PostGroupsSearch

> [**GroupsSearchResponse**](GroupsSearchResponse) PostGroupsSearch (GroupSearchRequest body)


Search groups

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            { 
                // Search groups
                GroupsSearchResponse result = apiInstance.PostGroupsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupSearchRequest**](GroupSearchRequest)| Search request options |  |

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse)


## PostKnowledgeKnowledgebaseSearch

> [**KnowledgeSearchResponse**](KnowledgeSearchResponse) PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Search Documents

Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeSearchRequest(); // KnowledgeSearchRequest |  (optional) 

            try
            { 
                // Search Documents
                KnowledgeSearchResponse result = apiInstance.PostKnowledgeKnowledgebaseSearch(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostKnowledgeKnowledgebaseSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeSearchRequest**](KnowledgeSearchRequest)|  | [optional]  |

### Return type

[**KnowledgeSearchResponse**](KnowledgeSearchResponse)


## PostLocationsSearch

> [**LocationsSearchResponse**](LocationsSearchResponse) PostLocationsSearch (LocationSearchRequest body)


Search locations

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLocationsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new LocationSearchRequest(); // LocationSearchRequest | Search request options

            try
            { 
                // Search locations
                LocationsSearchResponse result = apiInstance.PostLocationsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostLocationsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocationSearchRequest**](LocationSearchRequest)| Search request options |  |

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse)


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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.PostSearch: " + e.Message );
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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.PostSearchSuggest: " + e.Message );
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


## PostSpeechandtextanalyticsTranscriptsSearch

> [**JsonSearchResponse**](JsonSearchResponse) PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)


Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view
* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTranscriptsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new TranscriptSearchRequest(); // TranscriptSearchRequest | Search request options

            try
            { 
                // Search resources.
                JsonSearchResponse result = apiInstance.PostSpeechandtextanalyticsTranscriptsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSpeechandtextanalyticsTranscriptsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptSearchRequest**](TranscriptSearchRequest)| Search request options |  |

### Return type

[**JsonSearchResponse**](JsonSearchResponse)


## PostTeamsSearch

> [**TeamsSearchResponse**](TeamsSearchResponse) PostTeamsSearch (TeamSearchRequest body)


Search resources.

Requires ANY permissions: 

* groups:team:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTeamsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new TeamSearchRequest(); // TeamSearchRequest | Search request options

            try
            { 
                // Search resources.
                TeamsSearchResponse result = apiInstance.PostTeamsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostTeamsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TeamSearchRequest**](TeamSearchRequest)| Search request options |  |

### Return type

[**TeamsSearchResponse**](TeamsSearchResponse)


## PostTelephonyProvidersEdgesSitesSearch

> [**SitesSearchResponse**](SitesSearchResponse) PostTelephonyProvidersEdgesSitesSearch (SiteSearchRequest body)


Search sites

Requires ANY permissions: 

* telephony:plugin:all
* telephony:sites:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSitesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new SiteSearchRequest(); // SiteSearchRequest | Search request options

            try
            { 
                // Search sites
                SitesSearchResponse result = apiInstance.PostTelephonyProvidersEdgesSitesSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostTelephonyProvidersEdgesSitesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SiteSearchRequest**](SiteSearchRequest)| Search request options |  |

### Return type

[**SitesSearchResponse**](SitesSearchResponse)


## PostUsersSearch

> [**UsersSearchResponse**](UsersSearchResponse) PostUsersSearch (UserSearchRequest body)


Search users

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
    public class PostUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users
                UsersSearchResponse result = apiInstance.PostUsersSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostUsersSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest)| Search request options |  |

### Return type

[**UsersSearchResponse**](UsersSearchResponse)


## PostUsersSearchConversationTarget

> [**UsersSearchResponse**](UsersSearchResponse) PostUsersSearchConversationTarget (UserSearchRequest body)


Search users as conversation targets

PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:target

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchConversationTargetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users as conversation targets
                UsersSearchResponse result = apiInstance.PostUsersSearchConversationTarget(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostUsersSearchConversationTarget: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest)| Search request options |  |

### Return type

[**UsersSearchResponse**](UsersSearchResponse)


## PostUsersSearchQueuemembersManage

> [**UsersSearchResponse**](UsersSearchResponse) PostUsersSearchQueuemembersManage (UserSearchRequest body)


Search manage queue member

PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* routing:queueMember:manage
* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchQueuemembersManageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search manage queue member
                UsersSearchResponse result = apiInstance.PostUsersSearchQueuemembersManage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostUsersSearchQueuemembersManage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest)| Search request options |  |

### Return type

[**UsersSearchResponse**](UsersSearchResponse)


## PostUsersSearchTeamsAssign

> [**UsersSearchResponse**](UsersSearchResponse) PostUsersSearchTeamsAssign (UserSearchRequest body)


Search users assigned to teams

Requires ANY permissions: 

* groups:team:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchTeamsAssignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users assigned to teams
                UsersSearchResponse result = apiInstance.PostUsersSearchTeamsAssign(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostUsersSearchTeamsAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest)| Search request options |  |

### Return type

[**UsersSearchResponse**](UsersSearchResponse)


## PostVoicemailSearch

> [**VoicemailsSearchResponse**](VoicemailsSearchResponse) PostVoicemailSearch (VoicemailSearchRequest body)


Search voicemails

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostVoicemailSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SearchApi();
            var body = new VoicemailSearchRequest(); // VoicemailSearchRequest | Search request options

            try
            { 
                // Search voicemails
                VoicemailsSearchResponse result = apiInstance.PostVoicemailSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostVoicemailSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailSearchRequest**](VoicemailSearchRequest)| Search request options |  |

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse)


_PureCloudPlatform.Client.V2 237.0.0_
