# IdentityProviderApi

## PureCloudPlatform.Client.V2.Api.IdentityProviderApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIdentityprovider**](#DeleteIdentityprovider) | **Delete** /api/v2/identityproviders/{providerId} | Delete Identity Provider |
| [**DeleteIdentityprovidersAdfs**](#DeleteIdentityprovidersAdfs) | **Delete** /api/v2/identityproviders/adfs | Delete ADFS Identity Provider |
| [**DeleteIdentityprovidersCic**](#DeleteIdentityprovidersCic) | **Delete** /api/v2/identityproviders/cic | Delete Customer Interaction Center (CIC) Identity Provider |
| [**DeleteIdentityprovidersGeneric**](#DeleteIdentityprovidersGeneric) | **Delete** /api/v2/identityproviders/generic | Delete Generic SAML Identity Provider |
| [**DeleteIdentityprovidersGsuite**](#DeleteIdentityprovidersGsuite) | **Delete** /api/v2/identityproviders/gsuite | Delete G Suite Identity Provider |
| [**DeleteIdentityprovidersIdentitynow**](#DeleteIdentityprovidersIdentitynow) | **Delete** /api/v2/identityproviders/identitynow | Delete IdentityNow Provider |
| [**DeleteIdentityprovidersOkta**](#DeleteIdentityprovidersOkta) | **Delete** /api/v2/identityproviders/okta | Delete Okta Identity Provider |
| [**DeleteIdentityprovidersOnelogin**](#DeleteIdentityprovidersOnelogin) | **Delete** /api/v2/identityproviders/onelogin | Delete OneLogin Identity Provider |
| [**DeleteIdentityprovidersPing**](#DeleteIdentityprovidersPing) | **Delete** /api/v2/identityproviders/ping | Delete Ping Identity Provider |
| [**DeleteIdentityprovidersPurecloud**](#DeleteIdentityprovidersPurecloud) | **Delete** /api/v2/identityproviders/purecloud | Delete PureCloud Identity Provider |
| [**DeleteIdentityprovidersPureengage**](#DeleteIdentityprovidersPureengage) | **Delete** /api/v2/identityproviders/pureengage | Delete PureEngage Identity Provider |
| [**DeleteIdentityprovidersSalesforce**](#DeleteIdentityprovidersSalesforce) | **Delete** /api/v2/identityproviders/salesforce | Delete Salesforce Identity Provider |
| [**GetIdentityprovider**](#GetIdentityprovider) | **Get** /api/v2/identityproviders/{providerId} | Get Identity Provider |
| [**GetIdentityproviders**](#GetIdentityproviders) | **Get** /api/v2/identityproviders | The list of identity providers |
| [**GetIdentityprovidersAdfs**](#GetIdentityprovidersAdfs) | **Get** /api/v2/identityproviders/adfs | Get ADFS Identity Provider |
| [**GetIdentityprovidersCic**](#GetIdentityprovidersCic) | **Get** /api/v2/identityproviders/cic | Get Customer Interaction Center (CIC) Identity Provider |
| [**GetIdentityprovidersGeneric**](#GetIdentityprovidersGeneric) | **Get** /api/v2/identityproviders/generic | Get Generic SAML Identity Provider |
| [**GetIdentityprovidersGsuite**](#GetIdentityprovidersGsuite) | **Get** /api/v2/identityproviders/gsuite | Get G Suite Identity Provider |
| [**GetIdentityprovidersIdentitynow**](#GetIdentityprovidersIdentitynow) | **Get** /api/v2/identityproviders/identitynow | Get IdentityNow Provider |
| [**GetIdentityprovidersOkta**](#GetIdentityprovidersOkta) | **Get** /api/v2/identityproviders/okta | Get Okta Identity Provider |
| [**GetIdentityprovidersOnelogin**](#GetIdentityprovidersOnelogin) | **Get** /api/v2/identityproviders/onelogin | Get OneLogin Identity Provider |
| [**GetIdentityprovidersPing**](#GetIdentityprovidersPing) | **Get** /api/v2/identityproviders/ping | Get Ping Identity Provider |
| [**GetIdentityprovidersPurecloud**](#GetIdentityprovidersPurecloud) | **Get** /api/v2/identityproviders/purecloud | Get PureCloud Identity Provider |
| [**GetIdentityprovidersPureengage**](#GetIdentityprovidersPureengage) | **Get** /api/v2/identityproviders/pureengage | Get PureEngage Identity Provider |
| [**GetIdentityprovidersSalesforce**](#GetIdentityprovidersSalesforce) | **Get** /api/v2/identityproviders/salesforce | Get Salesforce Identity Provider |
| [**PostIdentityproviders**](#PostIdentityproviders) | **Post** /api/v2/identityproviders | Create Identity Provider |
| [**PutIdentityprovider**](#PutIdentityprovider) | **Put** /api/v2/identityproviders/{providerId} | Update Identity Provider |
| [**PutIdentityprovidersAdfs**](#PutIdentityprovidersAdfs) | **Put** /api/v2/identityproviders/adfs | Update/Create ADFS Identity Provider |
| [**PutIdentityprovidersCic**](#PutIdentityprovidersCic) | **Put** /api/v2/identityproviders/cic | Update/Create Customer Interaction Center (CIC) Identity Provider |
| [**PutIdentityprovidersGeneric**](#PutIdentityprovidersGeneric) | **Put** /api/v2/identityproviders/generic | Update/Create Generic SAML Identity Provider |
| [**PutIdentityprovidersGsuite**](#PutIdentityprovidersGsuite) | **Put** /api/v2/identityproviders/gsuite | Update/Create G Suite Identity Provider |
| [**PutIdentityprovidersIdentitynow**](#PutIdentityprovidersIdentitynow) | **Put** /api/v2/identityproviders/identitynow | Update/Create IdentityNow Provider |
| [**PutIdentityprovidersOkta**](#PutIdentityprovidersOkta) | **Put** /api/v2/identityproviders/okta | Update/Create Okta Identity Provider |
| [**PutIdentityprovidersOnelogin**](#PutIdentityprovidersOnelogin) | **Put** /api/v2/identityproviders/onelogin | Update/Create OneLogin Identity Provider |
| [**PutIdentityprovidersPing**](#PutIdentityprovidersPing) | **Put** /api/v2/identityproviders/ping | Update/Create Ping Identity Provider |
| [**PutIdentityprovidersPurecloud**](#PutIdentityprovidersPurecloud) | **Put** /api/v2/identityproviders/purecloud | Update/Create PureCloud Identity Provider |
| [**PutIdentityprovidersPureengage**](#PutIdentityprovidersPureengage) | **Put** /api/v2/identityproviders/pureengage | Update/Create PureEngage Identity Provider |
| [**PutIdentityprovidersSalesforce**](#PutIdentityprovidersSalesforce) | **Put** /api/v2/identityproviders/salesforce | Update/Create Salesforce Identity Provider |



## DeleteIdentityprovider

> void DeleteIdentityprovider (string providerId)


Delete Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityproviderExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var providerId = providerId_example;  // string | Provider ID

            try
            { 
                // Delete Identity Provider
                apiInstance.DeleteIdentityprovider(providerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovider: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **providerId** | **string**| Provider ID |  |

### Return type

void (empty response body)


## DeleteIdentityprovidersAdfs

> **Object** DeleteIdentityprovidersAdfs ()


Delete ADFS Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersAdfsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete ADFS Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersAdfs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersAdfs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersCic

> **Object** DeleteIdentityprovidersCic ()


Delete Customer Interaction Center (CIC) Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersCicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Customer Interaction Center (CIC) Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersCic();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersCic: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersGeneric

> **Object** DeleteIdentityprovidersGeneric ()


Delete Generic SAML Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersGenericExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Generic SAML Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersGeneric();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersGeneric: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersGsuite

> **Object** DeleteIdentityprovidersGsuite ()


Delete G Suite Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersGsuiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete G Suite Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersGsuite();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersGsuite: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersIdentitynow

> **Object** DeleteIdentityprovidersIdentitynow ()


Delete IdentityNow Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersIdentitynowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete IdentityNow Provider
                Object result = apiInstance.DeleteIdentityprovidersIdentitynow();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersIdentitynow: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersOkta

> **Object** DeleteIdentityprovidersOkta ()


Delete Okta Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersOktaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Okta Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersOkta();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersOkta: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersOnelogin

> **Object** DeleteIdentityprovidersOnelogin ()


Delete OneLogin Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersOneloginExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete OneLogin Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersOnelogin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersOnelogin: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersPing

> **Object** DeleteIdentityprovidersPing ()


Delete Ping Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersPingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Ping Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersPing();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersPing: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersPurecloud

> **Object** DeleteIdentityprovidersPurecloud ()


Delete PureCloud Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersPurecloudExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete PureCloud Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersPurecloud();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersPurecloud: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersPureengage

> **Object** DeleteIdentityprovidersPureengage ()


Delete PureEngage Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersPureengageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete PureEngage Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersPureengage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersPureengage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteIdentityprovidersSalesforce

> **Object** DeleteIdentityprovidersSalesforce ()


Delete Salesforce Identity Provider

Requires ANY permissions: 

* sso:provider:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIdentityprovidersSalesforceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Salesforce Identity Provider
                Object result = apiInstance.DeleteIdentityprovidersSalesforce();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityprovidersSalesforce: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## GetIdentityprovider

> [**CustomProvider**](CustomProvider) GetIdentityprovider (string providerId)


Get Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityproviderExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var providerId = providerId_example;  // string | Provider ID

            try
            { 
                // Get Identity Provider
                CustomProvider result = apiInstance.GetIdentityprovider(providerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovider: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **providerId** | **string**| Provider ID |  |

### Return type

[**CustomProvider**](CustomProvider)


## GetIdentityproviders

> [**IdentityProviderEntityListing**](IdentityProviderEntityListing) GetIdentityproviders ()


The list of identity providers

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // The list of identity providers
                IdentityProviderEntityListing result = apiInstance.GetIdentityproviders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityproviders: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**IdentityProviderEntityListing**](IdentityProviderEntityListing)


## GetIdentityprovidersAdfs

> [**ADFS**](ADFS) GetIdentityprovidersAdfs ()


Get ADFS Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersAdfsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get ADFS Identity Provider
                ADFS result = apiInstance.GetIdentityprovidersAdfs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersAdfs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ADFS**](ADFS)


## GetIdentityprovidersCic

> [**CustomerInteractionCenter**](CustomerInteractionCenter) GetIdentityprovidersCic ()


Get Customer Interaction Center (CIC) Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersCicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get Customer Interaction Center (CIC) Identity Provider
                CustomerInteractionCenter result = apiInstance.GetIdentityprovidersCic();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersCic: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CustomerInteractionCenter**](CustomerInteractionCenter)


## GetIdentityprovidersGeneric

> [**GenericSAML**](GenericSAML) GetIdentityprovidersGeneric ()


Get Generic SAML Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersGenericExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get Generic SAML Identity Provider
                GenericSAML result = apiInstance.GetIdentityprovidersGeneric();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersGeneric: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GenericSAML**](GenericSAML)


## GetIdentityprovidersGsuite

> [**GSuite**](GSuite) GetIdentityprovidersGsuite ()


Get G Suite Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersGsuiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get G Suite Identity Provider
                GSuite result = apiInstance.GetIdentityprovidersGsuite();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersGsuite: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GSuite**](GSuite)


## GetIdentityprovidersIdentitynow

> [**IdentityNow**](IdentityNow) GetIdentityprovidersIdentitynow ()


Get IdentityNow Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersIdentitynowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get IdentityNow Provider
                IdentityNow result = apiInstance.GetIdentityprovidersIdentitynow();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersIdentitynow: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**IdentityNow**](IdentityNow)


## GetIdentityprovidersOkta

> [**Okta**](Okta) GetIdentityprovidersOkta ()


Get Okta Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersOktaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get Okta Identity Provider
                Okta result = apiInstance.GetIdentityprovidersOkta();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersOkta: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**Okta**](Okta)


## GetIdentityprovidersOnelogin

> [**OneLogin**](OneLogin) GetIdentityprovidersOnelogin ()


Get OneLogin Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersOneloginExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get OneLogin Identity Provider
                OneLogin result = apiInstance.GetIdentityprovidersOnelogin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersOnelogin: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OneLogin**](OneLogin)


## GetIdentityprovidersPing

> [**PingIdentity**](PingIdentity) GetIdentityprovidersPing ()


Get Ping Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersPingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get Ping Identity Provider
                PingIdentity result = apiInstance.GetIdentityprovidersPing();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersPing: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**PingIdentity**](PingIdentity)


## GetIdentityprovidersPurecloud

> [**PureCloudPlatform.Client.V2.Model.PureCloud**](PureCloudPlatform.Client.V2.Model.PureCloud) GetIdentityprovidersPurecloud ()


Get PureCloud Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersPurecloudExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get PureCloud Identity Provider
                PureCloudPlatform.Client.V2.Model.PureCloud result = apiInstance.GetIdentityprovidersPurecloud();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersPurecloud: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**PureCloudPlatform.Client.V2.Model.PureCloud**](PureCloudPlatform.Client.V2.Model.PureCloud)


## GetIdentityprovidersPureengage

> [**PureEngage**](PureEngage) GetIdentityprovidersPureengage ()


Get PureEngage Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersPureengageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get PureEngage Identity Provider
                PureEngage result = apiInstance.GetIdentityprovidersPureengage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersPureengage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**PureEngage**](PureEngage)


## GetIdentityprovidersSalesforce

> [**Salesforce**](Salesforce) GetIdentityprovidersSalesforce ()


Get Salesforce Identity Provider

Requires ANY permissions: 

* sso:provider:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIdentityprovidersSalesforceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Get Salesforce Identity Provider
                Salesforce result = apiInstance.GetIdentityprovidersSalesforce();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityprovidersSalesforce: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**Salesforce**](Salesforce)


## PostIdentityproviders

> [**CustomProvider**](CustomProvider) PostIdentityproviders (CustomProvider body)


Create Identity Provider

Requires ANY permissions: 

* sso:provider:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIdentityprovidersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new CustomProvider(); // CustomProvider | Provider

            try
            { 
                // Create Identity Provider
                CustomProvider result = apiInstance.PostIdentityproviders(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PostIdentityproviders: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CustomProvider**](CustomProvider)| Provider |  |

### Return type

[**CustomProvider**](CustomProvider)


## PutIdentityprovider

> [**CustomProvider**](CustomProvider) PutIdentityprovider (string providerId, CustomProvider body)


Update Identity Provider

Requires ANY permissions: 

* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityproviderExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var providerId = providerId_example;  // string | Provider ID
            var body = new CustomProvider(); // CustomProvider | Provider

            try
            { 
                // Update Identity Provider
                CustomProvider result = apiInstance.PutIdentityprovider(providerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovider: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **providerId** | **string**| Provider ID |  |
| **body** | [**CustomProvider**](CustomProvider)| Provider |  |

### Return type

[**CustomProvider**](CustomProvider)


## PutIdentityprovidersAdfs

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersAdfs (ADFS body)


Update/Create ADFS Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersAdfsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new ADFS(); // ADFS | Provider

            try
            { 
                // Update/Create ADFS Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersAdfs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersAdfs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ADFS**](ADFS)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersCic

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersCic (CustomerInteractionCenter body)


Update/Create Customer Interaction Center (CIC) Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersCicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new CustomerInteractionCenter(); // CustomerInteractionCenter | Provider

            try
            { 
                // Update/Create Customer Interaction Center (CIC) Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersCic(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersCic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CustomerInteractionCenter**](CustomerInteractionCenter)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersGeneric

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersGeneric (GenericSAML body)


Update/Create Generic SAML Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersGenericExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new GenericSAML(); // GenericSAML | Provider

            try
            { 
                // Update/Create Generic SAML Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersGeneric(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersGeneric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GenericSAML**](GenericSAML)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersGsuite

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersGsuite (GSuite body)


Update/Create G Suite Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersGsuiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new GSuite(); // GSuite | Provider

            try
            { 
                // Update/Create G Suite Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersGsuite(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersGsuite: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GSuite**](GSuite)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersIdentitynow

> [**IdentityNow**](IdentityNow) PutIdentityprovidersIdentitynow (IdentityNow body)


Update/Create IdentityNow Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersIdentitynowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new IdentityNow(); // IdentityNow | Provider

            try
            { 
                // Update/Create IdentityNow Provider
                IdentityNow result = apiInstance.PutIdentityprovidersIdentitynow(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersIdentitynow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IdentityNow**](IdentityNow)| Provider |  |

### Return type

[**IdentityNow**](IdentityNow)


## PutIdentityprovidersOkta

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersOkta (Okta body)


Update/Create Okta Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersOktaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new Okta(); // Okta | Provider

            try
            { 
                // Update/Create Okta Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersOkta(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersOkta: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Okta**](Okta)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersOnelogin

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersOnelogin (OneLogin body)


Update/Create OneLogin Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersOneloginExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new OneLogin(); // OneLogin | Provider

            try
            { 
                // Update/Create OneLogin Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersOnelogin(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersOnelogin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OneLogin**](OneLogin)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersPing

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersPing (PingIdentity body)


Update/Create Ping Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersPingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new PingIdentity(); // PingIdentity | Provider

            try
            { 
                // Update/Create Ping Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersPing(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersPing: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PingIdentity**](PingIdentity)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersPurecloud

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersPurecloud (PureCloud body)


Update/Create PureCloud Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersPurecloudExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new PureCloud(); // PureCloud | Provider

            try
            { 
                // Update/Create PureCloud Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersPurecloud(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersPurecloud: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureCloud**](PureCloud)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersPureengage

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersPureengage (PureEngage body)


Update/Create PureEngage Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersPureengageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new PureEngage(); // PureEngage | Provider

            try
            { 
                // Update/Create PureEngage Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersPureengage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersPureengage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureEngage**](PureEngage)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


## PutIdentityprovidersSalesforce

> [**IdentityProvider**](IdentityProvider) PutIdentityprovidersSalesforce (Salesforce body)


Update/Create Salesforce Identity Provider

Requires ANY permissions: 

* sso:provider:add
* sso:provider:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIdentityprovidersSalesforceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IdentityProviderApi();
            var body = new Salesforce(); // Salesforce | Provider

            try
            { 
                // Update/Create Salesforce Identity Provider
                IdentityProvider result = apiInstance.PutIdentityprovidersSalesforce(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutIdentityprovidersSalesforce: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Salesforce**](Salesforce)| Provider |  |

### Return type

[**IdentityProvider**](IdentityProvider)


_PureCloudPlatform.Client.V2 249.0.0_
