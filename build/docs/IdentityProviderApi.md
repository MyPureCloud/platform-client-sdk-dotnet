---
title: IdentityProviderApi
---
## PureCloudPlatform.Client.V2.Api.IdentityProviderApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIdentityprovidersAdfs**](IdentityProviderApi.html#deleteidentityprovidersadfs) | **DELETE** /api/v2/identityproviders/adfs | Delete ADFS Identity Provider |
| [**DeleteIdentityprovidersCic**](IdentityProviderApi.html#deleteidentityproviderscic) | **DELETE** /api/v2/identityproviders/cic | Delete Customer Interaction Center (CIC) Identity Provider |
| [**DeleteIdentityprovidersGsuite**](IdentityProviderApi.html#deleteidentityprovidersgsuite) | **DELETE** /api/v2/identityproviders/gsuite | Delete G Suite Identity Provider |
| [**DeleteIdentityprovidersIdentitynow**](IdentityProviderApi.html#deleteidentityprovidersidentitynow) | **DELETE** /api/v2/identityproviders/identitynow | Delete IdentityNow Provider |
| [**DeleteIdentityprovidersOkta**](IdentityProviderApi.html#deleteidentityprovidersokta) | **DELETE** /api/v2/identityproviders/okta | Delete Okta Identity Provider |
| [**DeleteIdentityprovidersOnelogin**](IdentityProviderApi.html#deleteidentityprovidersonelogin) | **DELETE** /api/v2/identityproviders/onelogin | Delete OneLogin Identity Provider |
| [**DeleteIdentityprovidersPing**](IdentityProviderApi.html#deleteidentityprovidersping) | **DELETE** /api/v2/identityproviders/ping | Delete Ping Identity Provider |
| [**DeleteIdentityprovidersPurecloud**](IdentityProviderApi.html#deleteidentityproviderspurecloud) | **DELETE** /api/v2/identityproviders/purecloud | Delete PureCloud Identity Provider |
| [**DeleteIdentityprovidersSalesforce**](IdentityProviderApi.html#deleteidentityproviderssalesforce) | **DELETE** /api/v2/identityproviders/salesforce | Delete Salesforce Identity Provider |
| [**GetIdentityproviders**](IdentityProviderApi.html#getidentityproviders) | **GET** /api/v2/identityproviders | The list of identity providers |
| [**GetIdentityprovidersAdfs**](IdentityProviderApi.html#getidentityprovidersadfs) | **GET** /api/v2/identityproviders/adfs | Get ADFS Identity Provider |
| [**GetIdentityprovidersCic**](IdentityProviderApi.html#getidentityproviderscic) | **GET** /api/v2/identityproviders/cic | Get Customer Interaction Center (CIC) Identity Provider |
| [**GetIdentityprovidersGsuite**](IdentityProviderApi.html#getidentityprovidersgsuite) | **GET** /api/v2/identityproviders/gsuite | Get G Suite Identity Provider |
| [**GetIdentityprovidersIdentitynow**](IdentityProviderApi.html#getidentityprovidersidentitynow) | **GET** /api/v2/identityproviders/identitynow | Get IdentityNow Provider |
| [**GetIdentityprovidersOkta**](IdentityProviderApi.html#getidentityprovidersokta) | **GET** /api/v2/identityproviders/okta | Get Okta Identity Provider |
| [**GetIdentityprovidersOnelogin**](IdentityProviderApi.html#getidentityprovidersonelogin) | **GET** /api/v2/identityproviders/onelogin | Get OneLogin Identity Provider |
| [**GetIdentityprovidersPing**](IdentityProviderApi.html#getidentityprovidersping) | **GET** /api/v2/identityproviders/ping | Get Ping Identity Provider |
| [**GetIdentityprovidersPurecloud**](IdentityProviderApi.html#getidentityproviderspurecloud) | **GET** /api/v2/identityproviders/purecloud | Get PureCloud Identity Provider |
| [**GetIdentityprovidersSalesforce**](IdentityProviderApi.html#getidentityproviderssalesforce) | **GET** /api/v2/identityproviders/salesforce | Get Salesforce Identity Provider |
| [**PutIdentityprovidersAdfs**](IdentityProviderApi.html#putidentityprovidersadfs) | **PUT** /api/v2/identityproviders/adfs | Update/Create ADFS Identity Provider |
| [**PutIdentityprovidersCic**](IdentityProviderApi.html#putidentityproviderscic) | **PUT** /api/v2/identityproviders/cic | Update/Create Customer Interaction Center (CIC) Identity Provider |
| [**PutIdentityprovidersGsuite**](IdentityProviderApi.html#putidentityprovidersgsuite) | **PUT** /api/v2/identityproviders/gsuite | Update/Create G Suite Identity Provider |
| [**PutIdentityprovidersIdentitynow**](IdentityProviderApi.html#putidentityprovidersidentitynow) | **PUT** /api/v2/identityproviders/identitynow | Update/Create IdentityNow Provider |
| [**PutIdentityprovidersOkta**](IdentityProviderApi.html#putidentityprovidersokta) | **PUT** /api/v2/identityproviders/okta | Update/Create Okta Identity Provider |
| [**PutIdentityprovidersOnelogin**](IdentityProviderApi.html#putidentityprovidersonelogin) | **PUT** /api/v2/identityproviders/onelogin | Update/Create OneLogin Identity Provider |
| [**PutIdentityprovidersPing**](IdentityProviderApi.html#putidentityprovidersping) | **PUT** /api/v2/identityproviders/ping | Update/Create Ping Identity Provider |
| [**PutIdentityprovidersPurecloud**](IdentityProviderApi.html#putidentityproviderspurecloud) | **PUT** /api/v2/identityproviders/purecloud | Update/Create PureCloud Identity Provider |
| [**PutIdentityprovidersSalesforce**](IdentityProviderApi.html#putidentityproviderssalesforce) | **PUT** /api/v2/identityproviders/salesforce | Update/Create Salesforce Identity Provider |
{: class="table table-striped"}

<a name="deleteidentityprovidersadfs"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersAdfs ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete ADFS Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersAdfs();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityproviderscic"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersCic ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Customer Interaction Center (CIC) Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersCic();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityprovidersgsuite"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersGsuite ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete G Suite Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersGsuite();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityprovidersidentitynow"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersIdentitynow ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete IdentityNow Provider
                Empty result = apiInstance.DeleteIdentityprovidersIdentitynow();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityprovidersokta"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersOkta ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Okta Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersOkta();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityprovidersonelogin"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersOnelogin ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete OneLogin Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersOnelogin();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityprovidersping"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersPing ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Ping Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersPing();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityproviderspurecloud"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersPurecloud ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete PureCloud Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersPurecloud();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteidentityproviderssalesforce"></a>

## [**Empty**](Empty.html) DeleteIdentityprovidersSalesforce ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // Delete Salesforce Identity Provider
                Empty result = apiInstance.DeleteIdentityprovidersSalesforce();
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
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="getidentityproviders"></a>

## [**OAuthProviderEntityListing**](OAuthProviderEntityListing.html) GetIdentityproviders ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();

            try
            { 
                // The list of identity providers
                OAuthProviderEntityListing result = apiInstance.GetIdentityproviders();
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
{: class="table table-striped"}

### Return type

[**OAuthProviderEntityListing**](OAuthProviderEntityListing.html)

<a name="getidentityprovidersadfs"></a>

## [**ADFS**](ADFS.html) GetIdentityprovidersAdfs ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**ADFS**](ADFS.html)

<a name="getidentityproviderscic"></a>

## [**CustomerInteractionCenter**](CustomerInteractionCenter.html) GetIdentityprovidersCic ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**CustomerInteractionCenter**](CustomerInteractionCenter.html)

<a name="getidentityprovidersgsuite"></a>

## [**GSuite**](GSuite.html) GetIdentityprovidersGsuite ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**GSuite**](GSuite.html)

<a name="getidentityprovidersidentitynow"></a>

## [**IdentityNow**](IdentityNow.html) GetIdentityprovidersIdentitynow ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**IdentityNow**](IdentityNow.html)

<a name="getidentityprovidersokta"></a>

## [**Okta**](Okta.html) GetIdentityprovidersOkta ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**Okta**](Okta.html)

<a name="getidentityprovidersonelogin"></a>

## [**OneLogin**](OneLogin.html) GetIdentityprovidersOnelogin ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**OneLogin**](OneLogin.html)

<a name="getidentityprovidersping"></a>

## [**PingIdentity**](PingIdentity.html) GetIdentityprovidersPing ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**PingIdentity**](PingIdentity.html)

<a name="getidentityproviderspurecloud"></a>

## [**PureCloudPlatform.Client.V2.Model.PureCloud**](PureCloud.html) GetIdentityprovidersPurecloud ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.PureCloud**](PureCloud.html)

<a name="getidentityproviderssalesforce"></a>

## [**Salesforce**](Salesforce.html) GetIdentityprovidersSalesforce ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**Salesforce**](Salesforce.html)

<a name="putidentityprovidersadfs"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersAdfs (ADFS body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new ADFS(); // ADFS | Provider

            try
            { 
                // Update/Create ADFS Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersAdfs(body);
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
| **body** | [**ADFS**](ADFS.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityproviderscic"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersCic (CustomerInteractionCenter body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new CustomerInteractionCenter(); // CustomerInteractionCenter | Provider

            try
            { 
                // Update/Create Customer Interaction Center (CIC) Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersCic(body);
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
| **body** | [**CustomerInteractionCenter**](CustomerInteractionCenter.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityprovidersgsuite"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersGsuite (GSuite body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new GSuite(); // GSuite | Provider

            try
            { 
                // Update/Create G Suite Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersGsuite(body);
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
| **body** | [**GSuite**](GSuite.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityprovidersidentitynow"></a>

## [**IdentityNow**](IdentityNow.html) PutIdentityprovidersIdentitynow (IdentityNow body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
| **body** | [**IdentityNow**](IdentityNow.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**IdentityNow**](IdentityNow.html)

<a name="putidentityprovidersokta"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersOkta (Okta body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new Okta(); // Okta | Provider

            try
            { 
                // Update/Create Okta Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersOkta(body);
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
| **body** | [**Okta**](Okta.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityprovidersonelogin"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersOnelogin (OneLogin body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new OneLogin(); // OneLogin | Provider

            try
            { 
                // Update/Create OneLogin Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersOnelogin(body);
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
| **body** | [**OneLogin**](OneLogin.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityprovidersping"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersPing (PingIdentity body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new PingIdentity(); // PingIdentity | Provider

            try
            { 
                // Update/Create Ping Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersPing(body);
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
| **body** | [**PingIdentity**](PingIdentity.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityproviderspurecloud"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersPurecloud (PureCloudPlatform.Client.V2.Model.PureCloud body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new PureCloudPlatform.Client.V2.Model.PureCloud(); // PureCloudPlatform.Client.V2.Model.PureCloud | Provider

            try
            { 
                // Update/Create PureCloud Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersPurecloud(body);
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
| **body** | [**PureCloudPlatform.Client.V2.Model.PureCloud**](PureCloudPlatform.Client.V2.Model.PureCloud.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="putidentityproviderssalesforce"></a>

## [**OAuthProvider**](OAuthProvider.html) PutIdentityprovidersSalesforce (Salesforce body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi();
            var body = new Salesforce(); // Salesforce | Provider

            try
            { 
                // Update/Create Salesforce Identity Provider
                OAuthProvider result = apiInstance.PutIdentityprovidersSalesforce(body);
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
| **body** | [**Salesforce**](Salesforce.html)| Provider |  |
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

