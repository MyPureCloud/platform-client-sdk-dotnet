# EmailsApi

## PureCloudPlatform.Client.V2.Api.EmailsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmailsSettingsThreading**](#DeleteEmailsSettingsThreading) | **Delete** /api/v2/emails/settings/threading | Reset email threading settings to default |
| [**GetEmailsSettings**](#GetEmailsSettings) | **Get** /api/v2/emails/settings | Get email Contact Center settings |
| [**GetEmailsSettingsThreading**](#GetEmailsSettingsThreading) | **Get** /api/v2/emails/settings/threading | Get email threading settings |
| [**PatchEmailsSettings**](#PatchEmailsSettings) | **Patch** /api/v2/emails/settings | Patch email Contact Center settings |
| [**PatchEmailsSettingsThreading**](#PatchEmailsSettingsThreading) | **Patch** /api/v2/emails/settings/threading | Patch email threading settings |



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

            var apiInstance = new EmailsApi();

            try
            { 
                // Reset email threading settings to default
                apiInstance.DeleteEmailsSettingsThreading();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.DeleteEmailsSettingsThreading: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

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

            var apiInstance = new EmailsApi();

            try
            { 
                // Get email Contact Center settings
                EmailSettings result = apiInstance.GetEmailsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetEmailsSettings: " + e.Message );
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

            var apiInstance = new EmailsApi();

            try
            { 
                // Get email threading settings
                EmailThreadingSettings result = apiInstance.GetEmailsSettingsThreading();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetEmailsSettingsThreading: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailThreadingSettings**](EmailThreadingSettings)


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

            var apiInstance = new EmailsApi();
            var body = new EmailSettings(); // EmailSettings |  (optional) 

            try
            { 
                // Patch email Contact Center settings
                EmailSettings result = apiInstance.PatchEmailsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.PatchEmailsSettings: " + e.Message );
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

            var apiInstance = new EmailsApi();
            var body = new EmailThreadingSettings(); // EmailThreadingSettings |  (optional) 

            try
            { 
                // Patch email threading settings
                EmailThreadingSettings result = apiInstance.PatchEmailsSettingsThreading(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.PatchEmailsSettingsThreading: " + e.Message );
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


_PureCloudPlatform.Client.V2 252.0.0_
