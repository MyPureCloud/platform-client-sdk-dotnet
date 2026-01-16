# SettingsApi

## PureCloudPlatform.Client.V2.Api.SettingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmailsSettingsThreading**](#DeleteEmailsSettingsThreading) | **Delete** /api/v2/emails/settings/threading | Reset email threading settings to default |
| [**DeleteExternalcontactsSettings**](#DeleteExternalcontactsSettings) | **Delete** /api/v2/externalcontacts/settings | Delete settings |
| [**DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings**](#DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Delete** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Delete agent auto answer settings |
| [**GetEmailsSettings**](#GetEmailsSettings) | **Get** /api/v2/emails/settings | Get email Contact Center settings |
| [**GetEmailsSettingsThreading**](#GetEmailsSettingsThreading) | **Get** /api/v2/emails/settings/threading | Get email threading settings |
| [**GetExternalcontactsSettings**](#GetExternalcontactsSettings) | **Get** /api/v2/externalcontacts/settings | Get settings |
| [**GetSettingsExecutiondata**](#GetSettingsExecutiondata) | **Get** /api/v2/settings/executiondata | Get the execution history enabled setting. |
| [**GetUsersAgentuiAgentsAutoanswerAgentIdSettings**](#GetUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Get** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Get agent auto answer settings |
| [**PatchEmailsSettings**](#PatchEmailsSettings) | **Patch** /api/v2/emails/settings | Patch email Contact Center settings |
| [**PatchEmailsSettingsThreading**](#PatchEmailsSettingsThreading) | **Patch** /api/v2/emails/settings/threading | Patch email threading settings |
| [**PatchSettingsExecutiondata**](#PatchSettingsExecutiondata) | **Patch** /api/v2/settings/executiondata | Edit the execution history on off setting. |
| [**PatchUsersAgentuiAgentsAutoanswerAgentIdSettings**](#PatchUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Patch** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Update agent auto answer settings |
| [**PutExternalcontactsSettings**](#PutExternalcontactsSettings) | **Put** /api/v2/externalcontacts/settings | Set settings |
| [**PutUsersAgentuiAgentsAutoanswerAgentIdSettings**](#PutUsersAgentuiAgentsAutoanswerAgentIdSettings) | **Put** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Set agent auto answer settings |



## DeleteEmailsSettingsThreading

> void DeleteEmailsSettingsThreading ()


Reset email threading settings to default

Requires ANY permissions: 

* conversation:emailThreadingSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteEmailsSettingsThreadingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Reset email threading settings to default
                apiInstance.DeleteEmailsSettingsThreading();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteEmailsSettingsThreading: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteExternalcontactsSettings

> [**UpdatedSettingsResponse**](UpdatedSettingsResponse) DeleteExternalcontactsSettings ()


Delete settings

Requires ANY permissions: 

* externalContacts:settings:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Delete settings
                UpdatedSettingsResponse result = apiInstance.DeleteExternalcontactsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteExternalcontactsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**UpdatedSettingsResponse**](UpdatedSettingsResponse)


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

            var apiInstance = new SettingsApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to

            try
            { 
                // Delete agent auto answer settings
                apiInstance.DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
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


## GetEmailsSettings

> [**EmailSettings**](EmailSettings) GetEmailsSettings ()


Get email Contact Center settings

Requires ANY permissions: 

* conversation:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmailsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Get email Contact Center settings
                EmailSettings result = apiInstance.GetEmailsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetEmailsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailSettings**](EmailSettings)


## GetEmailsSettingsThreading

> [**EmailThreadingSettings**](EmailThreadingSettings) GetEmailsSettingsThreading ()


Get email threading settings

Requires ANY permissions: 

* conversation:emailThreadingSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmailsSettingsThreadingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Get email threading settings
                EmailThreadingSettings result = apiInstance.GetEmailsSettingsThreading();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetEmailsSettingsThreading: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailThreadingSettings**](EmailThreadingSettings)


## GetExternalcontactsSettings

> [**ExternalContactsSettings**](ExternalContactsSettings) GetExternalcontactsSettings ()


Get settings

Requires ANY permissions: 

* externalContacts:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Get settings
                ExternalContactsSettings result = apiInstance.GetExternalcontactsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetExternalcontactsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ExternalContactsSettings**](ExternalContactsSettings)


## GetSettingsExecutiondata

> [**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse) GetSettingsExecutiondata ()


Get the execution history enabled setting.

Get the execution history enabled setting.

Requires ANY permissions: 

* settings:executiondata:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSettingsExecutiondataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();

            try
            { 
                // Get the execution history enabled setting.
                ExecutionDataGlobalSettingsResponse result = apiInstance.GetSettingsExecutiondata();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSettingsExecutiondata: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse)


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

            var apiInstance = new SettingsApi();
            var agentId = agentId_example;  // string | The agent to apply the auto answer settings to

            try
            { 
                // Get agent auto answer settings
                AutoAnswerSettings result = apiInstance.GetUsersAgentuiAgentsAutoanswerAgentIdSettings(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
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


## PatchEmailsSettings

> [**EmailSettings**](EmailSettings) PatchEmailsSettings (EmailSettings body = null)


Patch email Contact Center settings

Requires ANY permissions: 

* conversation:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchEmailsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();
            var body = new EmailSettings(); // EmailSettings |  (optional) 

            try
            { 
                // Patch email Contact Center settings
                EmailSettings result = apiInstance.PatchEmailsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.PatchEmailsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmailSettings**](EmailSettings)|  | [optional]  |

### Return type

[**EmailSettings**](EmailSettings)


## PatchEmailsSettingsThreading

> [**EmailThreadingSettings**](EmailThreadingSettings) PatchEmailsSettingsThreading (EmailThreadingSettings body = null)


Patch email threading settings

Requires ANY permissions: 

* conversation:emailThreadingSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchEmailsSettingsThreadingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();
            var body = new EmailThreadingSettings(); // EmailThreadingSettings |  (optional) 

            try
            { 
                // Patch email threading settings
                EmailThreadingSettings result = apiInstance.PatchEmailsSettingsThreading(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.PatchEmailsSettingsThreading: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmailThreadingSettings**](EmailThreadingSettings)|  | [optional]  |

### Return type

[**EmailThreadingSettings**](EmailThreadingSettings)


## PatchSettingsExecutiondata

> [**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse) PatchSettingsExecutiondata (ExecutionDataSettingsRequest body)


Edit the execution history on off setting.

Edit the execution history on off setting.

Requires ANY permissions: 

* settings:executiondata:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSettingsExecutiondataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();
            var body = new ExecutionDataSettingsRequest(); // ExecutionDataSettingsRequest | New Execution Data Setting

            try
            { 
                // Edit the execution history on off setting.
                ExecutionDataGlobalSettingsResponse result = apiInstance.PatchSettingsExecutiondata(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.PatchSettingsExecutiondata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExecutionDataSettingsRequest**](ExecutionDataSettingsRequest)| New Execution Data Setting |  |

### Return type

[**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse)


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

            var apiInstance = new SettingsApi();
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
                Debug.Print("Exception when calling SettingsApi.PatchUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
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


## PutExternalcontactsSettings

> [**UpdatedSettingsResponse**](UpdatedSettingsResponse) PutExternalcontactsSettings (ExternalContactsSettings body = null)


Set settings

Requires ANY permissions: 

* externalContacts:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SettingsApi();
            var body = new ExternalContactsSettings(); // ExternalContactsSettings |  (optional) 

            try
            { 
                // Set settings
                UpdatedSettingsResponse result = apiInstance.PutExternalcontactsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.PutExternalcontactsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalContactsSettings**](ExternalContactsSettings)|  | [optional]  |

### Return type

[**UpdatedSettingsResponse**](UpdatedSettingsResponse)


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

            var apiInstance = new SettingsApi();
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
                Debug.Print("Exception when calling SettingsApi.PutUsersAgentuiAgentsAutoanswerAgentIdSettings: " + e.Message );
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


_PureCloudPlatform.Client.V2 254.0.0_
