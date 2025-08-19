# AgentUIApi

## PureCloudPlatform.Client.V2.Api.AgentUIApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings**](#DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Delete** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Delete agent auto answer settings |
| [**GetUsersAgentuiAgentsAutoanswerAgentIdSettings**](#GetUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Get** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Get agent auto answer settings |
| [**PatchUsersAgentuiAgentsAutoanswerAgentIdSettings**](#PatchUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Patch** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Update agent auto answer settings |
| [**PutUsersAgentuiAgentsAutoanswerAgentIdSettings**](#PutUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Put** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Set agent auto answer settings |



## DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings

> void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)


Delete agent auto answer settings

Requires ANY permissions: 

* agentUI:agents:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentUIApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to

            try
            { 
                // Delete agent auto answer settings
                apiInstance.DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentUIApi.DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent to apply the auto answer settings to |  |

### Return type

void (empty response body)


## GetUsersAgentuiAgentsAutoanswerAgentIdSettings

> [**AutoAnswerSettings**](AutoAnswerSettings) GetUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)


Get agent auto answer settings

Requires ANY permissions: 

* agentUI:agents:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersAgentuiAgentsAutoanswerAgentIdSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentUIApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to

            try
            { 
                // Get agent auto answer settings
                AutoAnswerSettings result = apiInstance.GetUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentUIApi.GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent to apply the auto answer settings to |  |

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings)


## PatchUsersAgentuiAgentsAutoanswerAgentIdSettings

> [**AutoAnswerSettings**](AutoAnswerSettings) PatchUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)


Update agent auto answer settings

Requires ANY permissions: 

* agentUI:agents:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentUIApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to
            var body = new AutoAnswerSettings(); // AutoAnswerSettings | AutoAnswerSettings

            try
            { 
                // Update agent auto answer settings
                AutoAnswerSettings result = apiInstance.PatchUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentUIApi.PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent to apply the auto answer settings to |  |
| **body** | [**AutoAnswerSettings**](AutoAnswerSettings)| AutoAnswerSettings |  |

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings)


## PutUsersAgentuiAgentsAutoanswerAgentIdSettings

> [**AutoAnswerSettings**](AutoAnswerSettings) PutUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)


Set agent auto answer settings

Requires ANY permissions: 

* agentUI:agents:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUsersAgentuiAgentsAutoanswerAgentIdSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentUIApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to
            var body = new AutoAnswerSettings(); // AutoAnswerSettings | AutoAnswerSettings

            try
            { 
                // Set agent auto answer settings
                AutoAnswerSettings result = apiInstance.PutUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentUIApi.PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent to apply the auto answer settings to |  |
| **body** | [**AutoAnswerSettings**](AutoAnswerSettings)| AutoAnswerSettings |  |

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings)


_PureCloudPlatform.Client.V2 239.1.0_
