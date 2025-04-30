# TeamsApi

## PureCloudPlatform.Client.V2.Api.TeamsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTeam**](#DeleteTeam) | **Delete** /api/v2/teams/{teamId} | Delete team |
| [**DeleteTeamMembers**](#DeleteTeamMembers) | **Delete** /api/v2/teams/{teamId}/members | Delete team members |
| [**GetTeam**](#GetTeam) | **Get** /api/v2/teams/{teamId} | Get team |
| [**GetTeamMembers**](#GetTeamMembers) | **Get** /api/v2/teams/{teamId}/members | Get team membership |
| [**GetTeams**](#GetTeams) | **Get** /api/v2/teams | Get Team listing |
| [**PatchTeam**](#PatchTeam) | **Patch** /api/v2/teams/{teamId} | Update team |
| [**PostAnalyticsTeamsActivityQuery**](#PostAnalyticsTeamsActivityQuery) | **Post** /api/v2/analytics/teams/activity/query | Query for team activity observations |
| [**PostTeamMembers**](#PostTeamMembers) | **Post** /api/v2/teams/{teamId}/members | Add team members |
| [**PostTeams**](#PostTeams) | **Post** /api/v2/teams | Create a team |
| [**PostTeamsSearch**](#PostTeamsSearch) | **Post** /api/v2/teams/search | Search resources. |



## DeleteTeam

> void DeleteTeam (string teamId)


Delete team

Requires ANY permissions: 

* groups:team:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTeamExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID

            try
            { 
                // Delete team
                apiInstance.DeleteTeam(teamId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |

### Return type

void (empty response body)


## DeleteTeamMembers

> void DeleteTeamMembers (string teamId, string id)


Delete team members

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
    public class DeleteTeamMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID
            var id = id_example;  // string | Comma separated list of member ids to remove

            try
            { 
                // Delete team members
                apiInstance.DeleteTeamMembers(teamId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteTeamMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |
| **id** | **string**| Comma separated list of member ids to remove |  |

### Return type

void (empty response body)


## GetTeam

> [**Team**](Team) GetTeam (string teamId, string expand = null)


Get team

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
    public class GetTeamExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID
            var expand = expand_example;  // string | Expand the division name (optional) 

            try
            { 
                // Get team
                Team result = apiInstance.GetTeam(teamId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |
| **expand** | **string**| Expand the division name | [optional] <br />**Values**: entities.division |

### Return type

[**Team**](Team)


## GetTeamMembers

> [**TeamMemberEntityListing**](TeamMemberEntityListing) GetTeamMembers (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null)


Get team membership

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
    public class GetTeamMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var before = before_example;  // string | The cursor that points to the previous item in the complete list of teams (optional) 
            var after = after_example;  // string | The cursor that points to the next item in the complete list of teams (optional) 
            var expand = expand_example;  // string | Expand the name on each user (optional) 

            try
            { 
                // Get team membership
                TeamMemberEntityListing result = apiInstance.GetTeamMembers(teamId, pageSize, before, after, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **before** | **string**| The cursor that points to the previous item in the complete list of teams | [optional]  |
| **after** | **string**| The cursor that points to the next item in the complete list of teams | [optional]  |
| **expand** | **string**| Expand the name on each user | [optional] <br />**Values**: entities |

### Return type

[**TeamMemberEntityListing**](TeamMemberEntityListing)


## GetTeams

> [**TeamEntityListing**](TeamEntityListing) GetTeams (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null)


Get Team listing

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
    public class GetTeamsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Return only teams whose names start with this value (case-insensitive matching) (optional) 
            var after = after_example;  // string | The cursor that points to the next item in the complete list of teams (optional) 
            var before = before_example;  // string | The cursor that points to the previous item in the complete list of teams (optional) 
            var expand = expand_example;  // string | Expand the name on each user (optional) 

            try
            { 
                // Get Team listing
                TeamEntityListing result = apiInstance.GetTeams(pageSize, name, after, before, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Return only teams whose names start with this value (case-insensitive matching) | [optional]  |
| **after** | **string**| The cursor that points to the next item in the complete list of teams | [optional]  |
| **before** | **string**| The cursor that points to the previous item in the complete list of teams | [optional]  |
| **expand** | **string**| Expand the name on each user | [optional] <br />**Values**: entities.division |

### Return type

[**TeamEntityListing**](TeamEntityListing)


## PatchTeam

> [**Team**](Team) PatchTeam (string teamId, Team body)


Update team

Requires ANY permissions: 

* groups:team:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTeamExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID
            var body = new Team(); // Team | Team

            try
            { 
                // Update team
                Team result = apiInstance.PatchTeam(teamId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PatchTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |
| **body** | [**Team**](Team)| Team |  |

### Return type

[**Team**](Team)


## PostAnalyticsTeamsActivityQuery

> [**TeamActivityResponse**](TeamActivityResponse) PostAnalyticsTeamsActivityQuery (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)


Query for team activity observations

Requires ANY permissions: 

* analytics:teamObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTeamsActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var body = new TeamActivityQuery(); // TeamActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for team activity observations
                TeamActivityResponse result = apiInstance.PostAnalyticsTeamsActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostAnalyticsTeamsActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TeamActivityQuery**](TeamActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**TeamActivityResponse**](TeamActivityResponse)


## PostTeamMembers

> [**TeamMemberAddListingResponse**](TeamMemberAddListingResponse) PostTeamMembers (string teamId, TeamMembers body)


Add team members

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
    public class PostTeamMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | Team ID
            var body = new TeamMembers(); // TeamMembers | TeamMembers

            try
            { 
                // Add team members
                TeamMemberAddListingResponse result = apiInstance.PostTeamMembers(teamId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostTeamMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| Team ID |  |
| **body** | [**TeamMembers**](TeamMembers)| TeamMembers |  |

### Return type

[**TeamMemberAddListingResponse**](TeamMemberAddListingResponse)


## PostTeams

> [**Team**](Team) PostTeams (Team body)


Create a team

Requires ANY permissions: 

* groups:team:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTeamsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TeamsApi();
            var body = new Team(); // Team | Team

            try
            { 
                // Create a team
                Team result = apiInstance.PostTeams(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Team**](Team)| Team |  |

### Return type

[**Team**](Team)


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

            var apiInstance = new TeamsApi();
            var body = new TeamSearchRequest(); // TeamSearchRequest | Search request options

            try
            { 
                // Search resources.
                TeamsSearchResponse result = apiInstance.PostTeamsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostTeamsSearch: " + e.Message );
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


_PureCloudPlatform.Client.V2 232.0.0_
