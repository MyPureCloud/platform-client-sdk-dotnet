---
title: ChatApi
---
## PureCloudPlatform.Client.V2.Api.ChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetChatSettings**](ChatApi.html#getchatsettings) | **GET** /api/v2/chat/settings | Get Chat Settings. |
| [**GetChatsSettings**](ChatApi.html#getchatssettings) | **GET** /api/v2/chats/settings | Get Chat Settings. |
| [**PatchChatSettings**](ChatApi.html#patchchatsettings) | **PATCH** /api/v2/chat/settings | Patch Chat Settings. |
| [**PatchChatsSettings**](ChatApi.html#patchchatssettings) | **PATCH** /api/v2/chats/settings | Patch Chat Settings. |
| [**PutChatSettings**](ChatApi.html#putchatsettings) | **PUT** /api/v2/chat/settings | Update Chat Settings. |
| [**PutChatsSettings**](ChatApi.html#putchatssettings) | **PUT** /api/v2/chats/settings | Update Chat Settings. |
{: class="table table-striped"}

<a name="getchatsettings"></a>

## [**ChatSettings**](ChatSettings.html) GetChatSettings ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get Chat Settings.

This route is deprecated, please use /chats/settings instead



Requires ANY permissions: 

* chat:setting:view
* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();

            try
            { 
                // Get Chat Settings.
                ChatSettings result = apiInstance.GetChatSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**ChatSettings**](ChatSettings.html)

<a name="getchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) GetChatsSettings ()



Get Chat Settings.



Requires ANY permissions: 

* chat:setting:view
* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();

            try
            { 
                // Get Chat Settings.
                ChatSettings result = apiInstance.GetChatsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**ChatSettings**](ChatSettings.html)

<a name="patchchatsettings"></a>

## [**ChatSettings**](ChatSettings.html) PatchChatSettings (ChatSettings body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Patch Chat Settings.

This route is deprecated, please use /chats/settings instead



Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Patch Chat Settings.
                ChatSettings result = apiInstance.PatchChatSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

<a name="patchchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) PatchChatsSettings (ChatSettings body)



Patch Chat Settings.



Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Patch Chat Settings.
                ChatSettings result = apiInstance.PatchChatsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

<a name="putchatsettings"></a>

## [**ChatSettings**](ChatSettings.html) PutChatSettings (ChatSettings body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update Chat Settings.

This route is deprecated, please use /chats/settings instead



Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutChatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Update Chat Settings.
                ChatSettings result = apiInstance.PutChatSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PutChatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

<a name="putchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) PutChatsSettings (ChatSettings body)



Update Chat Settings.



Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Update Chat Settings.
                ChatSettings result = apiInstance.PutChatsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PutChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

