# MessagingApi

## PureCloudPlatform.Client.V2.Api.MessagingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessagingSetting**](#DeleteMessagingSetting) | **Delete** /api/v2/messaging/settings/{messageSettingId} | Delete a messaging setting |
| [**DeleteMessagingSettingsDefault**](#DeleteMessagingSettingsDefault) | **Delete** /api/v2/messaging/settings/default | Delete the organization&#39;s default setting, a global default will be applied to integrations without settings |
| [**DeleteMessagingSupportedcontentSupportedContentId**](#DeleteMessagingSupportedcontentSupportedContentId) | **Delete** /api/v2/messaging/supportedcontent/{supportedContentId} | Delete a supported content profile |
| [**GetMessagingSetting**](#GetMessagingSetting) | **Get** /api/v2/messaging/settings/{messageSettingId} | Get a messaging setting |
| [**GetMessagingSettings**](#GetMessagingSettings) | **Get** /api/v2/messaging/settings | Get a list of messaging settings |
| [**GetMessagingSettingsDefault**](#GetMessagingSettingsDefault) | **Get** /api/v2/messaging/settings/default | Get the organization&#39;s default settings that will be used as the default when creating an integration. |
| [**GetMessagingSupportedcontent**](#GetMessagingSupportedcontent) | **Get** /api/v2/messaging/supportedcontent | Get a list of Supported Content profiles |
| [**GetMessagingSupportedcontentSupportedContentId**](#GetMessagingSupportedcontentSupportedContentId) | **Get** /api/v2/messaging/supportedcontent/{supportedContentId} | Get a supported content profile |
| [**PatchMessagingSetting**](#PatchMessagingSetting) | **Patch** /api/v2/messaging/settings/{messageSettingId} | Update a messaging setting |
| [**PatchMessagingSupportedcontentSupportedContentId**](#PatchMessagingSupportedcontentSupportedContentId) | **Patch** /api/v2/messaging/supportedcontent/{supportedContentId} | Update a supported content profile |
| [**PostMessagingSettings**](#PostMessagingSettings) | **Post** /api/v2/messaging/settings | Create a messaging setting |
| [**PostMessagingSupportedcontent**](#PostMessagingSupportedcontent) | **Post** /api/v2/messaging/supportedcontent | Create a Supported Content profile |
| [**PutMessagingSettingsDefault**](#PutMessagingSettingsDefault) | **Put** /api/v2/messaging/settings/default | Set the organization&#39;s default settings that may be applied to an integration when it is created. |
{: class="table table-striped"}


## DeleteMessagingSetting

> void DeleteMessagingSetting (string messageSettingId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a messaging setting

Requires ALL permissions: 

* messaging:setting:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var messageSettingId = messageSettingId_example;  // string | Message Settings ID

            try
            { 
                // Delete a messaging setting
                apiInstance.DeleteMessagingSetting(messageSettingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Settings ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)


## DeleteMessagingSettingsDefault

> void DeleteMessagingSettingsDefault ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete the organization's default setting, a global default will be applied to integrations without settings

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.

Requires ALL permissions: 

* messaging:setting:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();

            try
            { 
                // Delete the organization's default setting, a global default will be applied to integrations without settings
                apiInstance.DeleteMessagingSettingsDefault();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)


## DeleteMessagingSupportedcontentSupportedContentId

> void DeleteMessagingSupportedcontentSupportedContentId (string supportedContentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a supported content profile

Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement

Requires ALL permissions: 

* messaging:supportedContent:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Delete a supported content profile
                apiInstance.DeleteMessagingSupportedcontentSupportedContentId(supportedContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)


## GetMessagingSetting

> [**MessagingSetting**](MessagingSetting) GetMessagingSetting (string messageSettingId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a messaging setting

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var messageSettingId = messageSettingId_example;  // string | Message Settings ID

            try
            { 
                // Get a messaging setting
                MessagingSetting result = apiInstance.GetMessagingSetting(messageSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Settings ID |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting)


## GetMessagingSettings

> [**MessagingConfigListing**](MessagingConfigListing) GetMessagingSettings (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of messaging settings

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of messaging settings
                MessagingConfigListing result = apiInstance.GetMessagingSettings(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingConfigListing**](MessagingConfigListing)


## GetMessagingSettingsDefault

> [**MessagingSetting**](MessagingSetting) GetMessagingSettingsDefault ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the organization's default settings that will be used as the default when creating an integration.

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();

            try
            { 
                // Get the organization's default settings that will be used as the default when creating an integration.
                MessagingSetting result = apiInstance.GetMessagingSettingsDefault();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**MessagingSetting**](MessagingSetting)


## GetMessagingSupportedcontent

> [**SupportedContentListing**](SupportedContentListing) GetMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of Supported Content profiles

Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement

Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Supported Content profiles
                SupportedContentListing result = apiInstance.GetMessagingSupportedcontent(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSupportedcontent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SupportedContentListing**](SupportedContentListing)


## GetMessagingSupportedcontentSupportedContentId

> [**SupportedContent**](SupportedContent) GetMessagingSupportedcontentSupportedContentId (string supportedContentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a supported content profile

Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement

Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Get a supported content profile
                SupportedContent result = apiInstance.GetMessagingSupportedcontentSupportedContentId(supportedContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent)


## PatchMessagingSetting

> [**MessagingSetting**](MessagingSetting) PatchMessagingSetting (string messageSettingId, MessagingSettingRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update a messaging setting

Requires ALL permissions: 

* messaging:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var messageSettingId = messageSettingId_example;  // string | Message Settings ID
            var body = new MessagingSettingRequest(); // MessagingSettingRequest | MessagingSetting

            try
            { 
                // Update a messaging setting
                MessagingSetting result = apiInstance.PatchMessagingSetting(messageSettingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PatchMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Settings ID |  |
| **body** | [**MessagingSettingRequest**](MessagingSettingRequest)| MessagingSetting |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting)


## PatchMessagingSupportedcontentSupportedContentId

> [**SupportedContent**](SupportedContent) PatchMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update a supported content profile

Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement

Requires ALL permissions: 

* messaging:supportedContent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Update a supported content profile
                SupportedContent result = apiInstance.PatchMessagingSupportedcontentSupportedContentId(supportedContentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PatchMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
| **body** | [**SupportedContent**](SupportedContent)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent)


## PostMessagingSettings

> [**MessagingSetting**](MessagingSetting) PostMessagingSettings (MessagingSettingRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a messaging setting

Requires ANY permissions: 

* messaging:setting:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var body = new MessagingSettingRequest(); // MessagingSettingRequest | MessagingSetting

            try
            { 
                // Create a messaging setting
                MessagingSetting result = apiInstance.PostMessagingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingSettingRequest**](MessagingSettingRequest)| MessagingSetting |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting)


## PostMessagingSupportedcontent

> [**SupportedContent**](SupportedContent) PostMessagingSupportedcontent (SupportedContent body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a Supported Content profile

Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement

Requires ANY permissions: 

* messaging:supportedContent:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Create a Supported Content profile
                SupportedContent result = apiInstance.PostMessagingSupportedcontent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingSupportedcontent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SupportedContent**](SupportedContent)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent)


## PutMessagingSettingsDefault

> [**MessagingSetting**](MessagingSetting) PutMessagingSettingsDefault (MessagingSettingDefaultRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Set the organization's default settings that may be applied to an integration when it is created.

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.

Requires ALL permissions: 

* messaging:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var body = new MessagingSettingDefaultRequest(); // MessagingSettingDefaultRequest | Messaging Setting ID

            try
            { 
                // Set the organization's default settings that may be applied to an integration when it is created.
                MessagingSetting result = apiInstance.PutMessagingSettingsDefault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PutMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingSettingDefaultRequest**](MessagingSettingDefaultRequest)| Messaging Setting ID |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting)


_PureCloudPlatform.Client.V2 214.0.0_
