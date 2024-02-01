---
title: SearchApi
---
## PureCloudPlatform.Client.V2.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDocumentationGknSearch**](SearchApi.html#getdocumentationgknsearch) | **Get** /api/v2/documentation/gkn/search | Search gkn documentation using the q64 value returned from a previous search |
| [**GetDocumentationSearch**](SearchApi.html#getdocumentationsearch) | **Get** /api/v2/documentation/search | Search documentation using the q64 value returned from a previous search |
| [**GetGroupsSearch**](SearchApi.html#getgroupssearch) | **Get** /api/v2/groups/search | Search groups using the q64 value returned from a previous search |
| [**GetLocationsSearch**](SearchApi.html#getlocationssearch) | **Get** /api/v2/locations/search | Search locations using the q64 value returned from a previous search |
| [**GetSearch**](SearchApi.html#getsearch) | **Get** /api/v2/search | Search using the q64 value returned from a previous search. |
| [**GetSearchSuggest**](SearchApi.html#getsearchsuggest) | **Get** /api/v2/search/suggest | Suggest resources using the q64 value returned from a previous suggest query. |
| [**GetUsersSearch**](SearchApi.html#getuserssearch) | **Get** /api/v2/users/search | Search users using the q64 value returned from a previous search |
| [**GetVoicemailSearch**](SearchApi.html#getvoicemailsearch) | **Get** /api/v2/voicemail/search | Search voicemails using the q64 value returned from a previous search |
| [**PostAnalyticsConversationsTranscriptsQuery**](SearchApi.html#postanalyticsconversationstranscriptsquery) | **Post** /api/v2/analytics/conversations/transcripts/query | Search resources. |
| [**PostConversationsParticipantsAttributesSearch**](SearchApi.html#postconversationsparticipantsattributessearch) | **Post** /api/v2/conversations/participants/attributes/search | Search conversations |
| [**PostDocumentationAllSearch**](SearchApi.html#postdocumentationallsearch) | **Post** /api/v2/documentation/all/search | Search all documents |
| [**PostDocumentationGknSearch**](SearchApi.html#postdocumentationgknsearch) | **Post** /api/v2/documentation/gkn/search | Search gkn documentation |
| [**PostDocumentationSearch**](SearchApi.html#postdocumentationsearch) | **Post** /api/v2/documentation/search | Search documentation |
| [**PostGroupsSearch**](SearchApi.html#postgroupssearch) | **Post** /api/v2/groups/search | Search groups |
| [**PostKnowledgeKnowledgebaseSearch**](SearchApi.html#postknowledgeknowledgebasesearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search | Search Documents |
| [**PostLocationsSearch**](SearchApi.html#postlocationssearch) | **Post** /api/v2/locations/search | Search locations |
| [**PostSearch**](SearchApi.html#postsearch) | **Post** /api/v2/search | Search resources. |
| [**PostSearchSuggest**](SearchApi.html#postsearchsuggest) | **Post** /api/v2/search/suggest | Suggest resources. |
| [**PostSpeechandtextanalyticsTranscriptsSearch**](SearchApi.html#postspeechandtextanalyticstranscriptssearch) | **Post** /api/v2/speechandtextanalytics/transcripts/search | Search resources. |
| [**PostTeamsSearch**](SearchApi.html#postteamssearch) | **Post** /api/v2/teams/search | Search resources. |
| [**PostUsersSearch**](SearchApi.html#postuserssearch) | **Post** /api/v2/users/search | Search users |
| [**PostUsersSearchConversationTarget**](SearchApi.html#postuserssearchconversationtarget) | **Post** /api/v2/users/search/conversation/target | Search users as conversation targets |
| [**PostUsersSearchQueuemembersManage**](SearchApi.html#postuserssearchqueuemembersmanage) | **Post** /api/v2/users/search/queuemembers/manage | Search manage queue member |
| [**PostUsersSearchTeamsAssign**](SearchApi.html#postuserssearchteamsassign) | **Post** /api/v2/users/search/teams/assign | Search users assigned to teams |
| [**PostVoicemailSearch**](SearchApi.html#postvoicemailsearch) | **Post** /api/v2/voicemail/search | Search voicemails |
{: class="table table-striped"}

<a name="getdocumentationgknsearch"></a>

## [**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse.html) GetDocumentationGknSearch (string q64)



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
{: class="table table-striped"}

### Return type

[**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse.html)

<a name="getdocumentationsearch"></a>

## [**DocumentationSearchResponse**](DocumentationSearchResponse.html) GetDocumentationSearch (string q64)



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
{: class="table table-striped"}

### Return type

[**DocumentationSearchResponse**](DocumentationSearchResponse.html)

<a name="getgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetGroupsSearch (string q64, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="getlocationssearch"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) GetLocationsSearch (string q64, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Provides more details about a specified resource | [optional] <br />**Values**: images, addressVerificationDetails |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="getsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch (string q64, List<string> expand = null, bool? profile = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, dateLastLogin, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, images, addressVerificationDetails |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsearchsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearchSuggest (string q64, List<string> expand = null, bool? profile = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, dateLastLogin, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, images, addressVerificationDetails |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getuserssearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetUsersSearch (string q64, List<string> expand = null, string integrationPresenceSource = null)



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
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
| **integrationPresenceSource** | **string**| integrationPresenceSource | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="getvoicemailsearch"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) GetVoicemailSearch (string q64, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

<a name="postanalyticsconversationstranscriptsquery"></a>

## [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html) PostAnalyticsConversationsTranscriptsQuery (TranscriptConversationDetailSearchRequest body)



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
| **body** | [**TranscriptConversationDetailSearchRequest**](TranscriptConversationDetailSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html)

<a name="postconversationsparticipantsattributessearch"></a>

## [**JsonCursorSearchResponse**](JsonCursorSearchResponse.html) PostConversationsParticipantsAttributesSearch (ConversationParticipantSearchRequest body)



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
| **body** | [**ConversationParticipantSearchRequest**](ConversationParticipantSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**JsonCursorSearchResponse**](JsonCursorSearchResponse.html)

<a name="postdocumentationallsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostDocumentationAllSearch (DocumentationV2SearchRequest body)



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
| **body** | [**DocumentationV2SearchRequest**](DocumentationV2SearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postdocumentationgknsearch"></a>

## [**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse.html) PostDocumentationGknSearch (GKNDocumentationSearchRequest body)



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
| **body** | [**GKNDocumentationSearchRequest**](GKNDocumentationSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**GKNDocumentationSearchResponse**](GKNDocumentationSearchResponse.html)

<a name="postdocumentationsearch"></a>

## [**DocumentationSearchResponse**](DocumentationSearchResponse.html) PostDocumentationSearch (DocumentationSearchRequest body)



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
| **body** | [**DocumentationSearchRequest**](DocumentationSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**DocumentationSearchResponse**](DocumentationSearchResponse.html)

<a name="postgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostGroupsSearch (GroupSearchRequest body)



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
| **body** | [**GroupSearchRequest**](GroupSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="postknowledgeknowledgebasesearch"></a>

## [**KnowledgeSearchResponse**](KnowledgeSearchResponse.html) PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **body** | [**KnowledgeSearchRequest**](KnowledgeSearchRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeSearchResponse**](KnowledgeSearchResponse.html)

<a name="postlocationssearch"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) PostLocationsSearch (LocationSearchRequest body)



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
| **body** | [**LocationSearchRequest**](LocationSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="postsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch (SearchRequest body, bool? profile = null)



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
| **body** | [**SearchRequest**](SearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearchsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearchSuggest (SuggestSearchRequest body, bool? profile = null)



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
| **body** | [**SuggestSearchRequest**](SuggestSearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postspeechandtextanalyticstranscriptssearch"></a>

## [**JsonSearchResponse**](JsonSearchResponse.html) PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)



Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view
* recording:recording:view

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
| **body** | [**TranscriptSearchRequest**](TranscriptSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**JsonSearchResponse**](JsonSearchResponse.html)

<a name="postteamssearch"></a>

## [**TeamsSearchResponse**](TeamsSearchResponse.html) PostTeamsSearch (TeamSearchRequest body)



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
| **body** | [**TeamSearchRequest**](TeamSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**TeamsSearchResponse**](TeamsSearchResponse.html)

<a name="postuserssearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearch (UserSearchRequest body)



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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postuserssearchconversationtarget"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchConversationTarget (UserSearchRequest body)



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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postuserssearchqueuemembersmanage"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchQueuemembersManage (UserSearchRequest body)



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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postuserssearchteamsassign"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchTeamsAssign (UserSearchRequest body)



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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postvoicemailsearch"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) PostVoicemailSearch (VoicemailSearchRequest body)



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
| **body** | [**VoicemailSearchRequest**](VoicemailSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

