---
title: SettingsApi
---
## PureCloudPlatform.Client.V2.Api.SettingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings**](SettingsApi.html#deleteusersagentuiagentsautoansweragentidsettings) | **Delete** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Delete agent auto answer settings |
| [**GetEmailsSettings**](SettingsApi.html#getemailssettings) | **Get** /api/v2/emails/settings | Get email Contact Center settings |
| [**GetSettingsExecutiondata**](SettingsApi.html#getsettingsexecutiondata) | **Get** /api/v2/settings/executiondata | Get the execution history enabled setting. |
| [**GetUsersAgentuiAgentsAutoanswerAgentIdSettings**](SettingsApi.html#getusersagentuiagentsautoansweragentidsettings) | **Get** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Get agent auto answer settings |
| [**PatchEmailsSettings**](SettingsApi.html#patchemailssettings) | **Patch** /api/v2/emails/settings | Patch email Contact Center settings |
| [**PatchSettingsExecutiondata**](SettingsApi.html#patchsettingsexecutiondata) | **Patch** /api/v2/settings/executiondata | Edit the execution history on off setting. |
| [**PatchUsersAgentuiAgentsAutoanswerAgentIdSettings**](SettingsApi.html#patchusersagentuiagentsautoansweragentidsettings) | **Patch** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Update agent auto answer settings |
| [**PutUsersAgentuiAgentsAutoanswerAgentIdSettings**](SettingsApi.html#putusersagentuiagentsautoansweragentidsettings) | **Put** /api/v2/users/agentui/agents/autoanswer/{agentId}/settings | Set agent auto answer settings |
{: class="table table-striped"}

<a name="deleteusersagentuiagentsautoansweragentidsettings"></a>

## void DeleteUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getemailssettings"></a>

## [**EmailSettings**](EmailSettings.html) GetEmailsSettings ()



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

[**EmailSettings**](EmailSettings.html)

<a name="getsettingsexecutiondata"></a>

## [**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse.html) GetSettingsExecutiondata ()



Get the execution history enabled setting.

Get the execution history enabled setting.

GetSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

[**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse.html)

<a name="getusersagentuiagentsautoansweragentidsettings"></a>

## [**AutoAnswerSettings**](AutoAnswerSettings.html) GetUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId)



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
{: class="table table-striped"}

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings.html)

<a name="patchemailssettings"></a>

## [**EmailSettings**](EmailSettings.html) PatchEmailsSettings (EmailSettings body = null)



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
| **body** | [**EmailSettings**](EmailSettings.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailSettings**](EmailSettings.html)

<a name="patchsettingsexecutiondata"></a>

## [**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse.html) PatchSettingsExecutiondata (ExecutionDataSettingsRequest body)



Edit the execution history on off setting.

Edit the execution history on off setting.

PatchSettingsExecutiondata is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**ExecutionDataSettingsRequest**](ExecutionDataSettingsRequest.html)| New Execution Data Setting |  |
{: class="table table-striped"}

### Return type

[**ExecutionDataGlobalSettingsResponse**](ExecutionDataGlobalSettingsResponse.html)

<a name="patchusersagentuiagentsautoansweragentidsettings"></a>

## [**AutoAnswerSettings**](AutoAnswerSettings.html) PatchUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)



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
| **body** | [**AutoAnswerSettings**](AutoAnswerSettings.html)| AutoAnswerSettings |  |
{: class="table table-striped"}

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings.html)

<a name="putusersagentuiagentsautoansweragentidsettings"></a>

## [**AutoAnswerSettings**](AutoAnswerSettings.html) PutUsersAgentuiAgentsAutoanswerAgentIdSettings (string agentId, AutoAnswerSettings body)



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
| **body** | [**AutoAnswerSettings**](AutoAnswerSettings.html)| AutoAnswerSettings |  |
{: class="table table-striped"}

### Return type

[**AutoAnswerSettings**](AutoAnswerSettings.html)

