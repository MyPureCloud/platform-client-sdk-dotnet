---
title: SettingsApi
---
## PureCloudPlatform.Client.V2.Api.SettingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetEmailsSettings**](SettingsApi.html#getemailssettings) | **Get** /api/v2/emails/settings | Get email Contact Center settings |
| [**PatchEmailsSettings**](SettingsApi.html#patchemailssettings) | **Patch** /api/v2/emails/settings | Patch email Contact Center settings |
{: class="table table-striped"}

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

