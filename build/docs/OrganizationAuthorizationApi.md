---
title: OrganizationAuthorizationApi
---
## PureCloudPlatform.Client.V2.Api.OrganizationAuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustee) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrusteeUser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteeuser) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**DeleteOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteeuserroles) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Delete Trustee User Roles |
| [**DeleteOrgauthorizationTrustor**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustor) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustoruser) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**GetOrgauthorizationPairing**](OrganizationAuthorizationApi.html#getorgauthorizationpairing) | **GET** /api/v2/orgauthorization/pairings/{pairingId} | Get Pairing Info |
| [**GetOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#getorgauthorizationtrustee) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrusteeUser**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeuser) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeuserroles) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Get Trustee User Roles |
| [**GetOrgauthorizationTrusteeUsers**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeusers) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | The list of trustee users for this organization (i.e. users granted access to this organization). |
| [**GetOrgauthorizationTrustees**](OrganizationAuthorizationApi.html#getorgauthorizationtrustees) | **GET** /api/v2/orgauthorization/trustees | The list of trustees for this organization (i.e. organizations granted access to this organization). |
| [**GetOrgauthorizationTrustor**](OrganizationAuthorizationApi.html#getorgauthorizationtrustor) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#getorgauthorizationtrustoruser) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrustorUsers**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorusers) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/users | The list of users in the trustor organization (i.e. users granted access). |
| [**GetOrgauthorizationTrustors**](OrganizationAuthorizationApi.html#getorgauthorizationtrustors) | **GET** /api/v2/orgauthorization/trustors | The list of organizations that have authorized/trusted your organization. |
| [**PostOrgauthorizationPairings**](OrganizationAuthorizationApi.html#postorgauthorizationpairings) | **POST** /api/v2/orgauthorization/pairings | A pairing id is created by the trustee and given to the trustor to create a trust. |
| [**PostOrgauthorizationTrusteeUsers**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteeusers) | **POST** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | Add a user to the trust. |
| [**PostOrgauthorizationTrustees**](OrganizationAuthorizationApi.html#postorgauthorizationtrustees) | **POST** /api/v2/orgauthorization/trustees | Create a new organization authorization trust. This is required to grant other organizations access to your organization. |
| [**PostOrgauthorizationTrusteesAudits**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteesaudits) | **POST** /api/v2/orgauthorization/trustees/audits | Get Org Trustee Audits |
| [**PostOrgauthorizationTrustorAudits**](OrganizationAuthorizationApi.html#postorgauthorizationtrustoraudits) | **POST** /api/v2/orgauthorization/trustor/audits | Get Org Trustor Audits |
| [**PutOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#putorgauthorizationtrustee) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Update Org Trust |
| [**PutOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#putorgauthorizationtrusteeuserroles) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Update Trustee User Roles |
| [**PutOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#putorgauthorizationtrustoruser) | **PUT** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Add a Trustee user to the trust. |
{: class="table table-striped"}

<a name="deleteorgauthorizationtrustee"></a>

## void DeleteOrgauthorizationTrustee (string trusteeOrgId)

Delete Org Trust



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            

            try
            {
                
                // Delete Org Trust
                
                apiInstance.DeleteOrgauthorizationTrustee(trusteeOrgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustee: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteeuser"></a>

## void DeleteOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)

Delete Trustee User



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Delete Trustee User
                
                apiInstance.DeleteOrgauthorizationTrusteeUser(trusteeOrgId, trusteeUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrusteeUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteeuserroles"></a>

## void DeleteOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId)

Delete Trustee User Roles



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Delete Trustee User Roles
                
                apiInstance.DeleteOrgauthorizationTrusteeUserRoles(trusteeOrgId, trusteeUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrusteeUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrustor"></a>

## void DeleteOrgauthorizationTrustor (string trustorOrgId)

Delete Org Trust



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrustorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            
            
            

            try
            {
                
                // Delete Org Trust
                
                apiInstance.DeleteOrgauthorizationTrustor(trustorOrgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustor: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrustoruser"></a>

## void DeleteOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)

Delete Trustee User



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrustorUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Delete Trustee User
                
                apiInstance.DeleteOrgauthorizationTrustorUser(trustorOrgId, trusteeUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustorUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getorgauthorizationpairing"></a>

## [**TrustRequest**](TrustRequest.html) GetOrgauthorizationPairing (string pairingId)

Get Pairing Info



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationPairingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var pairingId = pairingId_example;  // string | Pairing Id
            
            
            

            try
            {
                
                // Get Pairing Info
                
                TrustRequest result = apiInstance.GetOrgauthorizationPairing(pairingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationPairing: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pairingId** | **string**| Pairing Id |  |
{: class="table table-striped"}

### Return type

[**TrustRequest**](TrustRequest.html)

<a name="getorgauthorizationtrustee"></a>

## [**Trustee**](Trustee.html) GetOrgauthorizationTrustee (string trusteeOrgId)

Get Org Trust



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            

            try
            {
                
                // Get Org Trust
                
                Trustee result = apiInstance.GetOrgauthorizationTrustee(trusteeOrgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustee: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="getorgauthorizationtrusteeuser"></a>

## [**TrustUser**](TrustUser.html) GetOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)

Get Trustee User



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Get Trustee User
                
                TrustUser result = apiInstance.GetOrgauthorizationTrusteeUser(trusteeOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

<a name="getorgauthorizationtrusteeuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId)

Get Trustee User Roles



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Get Trustee User Roles
                
                UserAuthorization result = apiInstance.GetOrgauthorizationTrusteeUserRoles(trusteeOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="getorgauthorizationtrusteeusers"></a>

## [**TrustUserEntityListing**](TrustUserEntityListing.html) GetOrgauthorizationTrusteeUsers (string trusteeOrgId, int? pageSize = null, int? pageNumber = null)

The list of trustee users for this organization (i.e. users granted access to this organization).



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // The list of trustee users for this organization (i.e. users granted access to this organization).
                
                TrustUserEntityListing result = apiInstance.GetOrgauthorizationTrusteeUsers(trusteeOrgId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustUserEntityListing**](TrustUserEntityListing.html)

<a name="getorgauthorizationtrustees"></a>

## [**TrustEntityListing**](TrustEntityListing.html) GetOrgauthorizationTrustees (int? pageSize = null, int? pageNumber = null)

The list of trustees for this organization (i.e. organizations granted access to this organization).



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // The list of trustees for this organization (i.e. organizations granted access to this organization).
                
                TrustEntityListing result = apiInstance.GetOrgauthorizationTrustees(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustees: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustEntityListing**](TrustEntityListing.html)

<a name="getorgauthorizationtrustor"></a>

## [**Trustor**](Trustor.html) GetOrgauthorizationTrustor (string trustorOrgId)

Get Org Trust



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            
            
            

            try
            {
                
                // Get Org Trust
                
                Trustor result = apiInstance.GetOrgauthorizationTrustor(trustorOrgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustor: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
{: class="table table-striped"}

### Return type

[**Trustor**](Trustor.html)

<a name="getorgauthorizationtrustoruser"></a>

## [**TrustUser**](TrustUser.html) GetOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)

Get Trustee User



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Get Trustee User
                
                TrustUser result = apiInstance.GetOrgauthorizationTrustorUser(trustorOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

<a name="getorgauthorizationtrustorusers"></a>

## [**TrustUserEntityListing**](TrustUserEntityListing.html) GetOrgauthorizationTrustorUsers (string trustorOrgId, int? pageSize = null, int? pageNumber = null)

The list of users in the trustor organization (i.e. users granted access).



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // The list of users in the trustor organization (i.e. users granted access).
                
                TrustUserEntityListing result = apiInstance.GetOrgauthorizationTrustorUsers(trustorOrgId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustee Organization Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustUserEntityListing**](TrustUserEntityListing.html)

<a name="getorgauthorizationtrustors"></a>

## [**TrustorEntityListing**](TrustorEntityListing.html) GetOrgauthorizationTrustors (int? pageSize = null, int? pageNumber = null)

The list of organizations that have authorized/trusted your organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // The list of organizations that have authorized/trusted your organization.
                
                TrustorEntityListing result = apiInstance.GetOrgauthorizationTrustors(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustors: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustorEntityListing**](TrustorEntityListing.html)

<a name="postorgauthorizationpairings"></a>

## [**TrustRequest**](TrustRequest.html) PostOrgauthorizationPairings (TrustRequestCreate body)

A pairing id is created by the trustee and given to the trustor to create a trust.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationPairingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            
            var body = new TrustRequestCreate(); // TrustRequestCreate | Pairing Info
            
            

            try
            {
                
                // A pairing id is created by the trustee and given to the trustor to create a trust.
                
                TrustRequest result = apiInstance.PostOrgauthorizationPairings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationPairings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustRequestCreate**](TrustRequestCreate.html)| Pairing Info |  |
{: class="table table-striped"}

### Return type

[**TrustRequest**](TrustRequest.html)

<a name="postorgauthorizationtrusteeusers"></a>

## [**TrustUser**](TrustUser.html) PostOrgauthorizationTrusteeUsers (string trusteeOrgId, TrustUserCreate body)

Add a user to the trust.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrusteeUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            
            var body = new TrustUserCreate(); // TrustUserCreate | Trust
            
            

            try
            {
                
                // Add a user to the trust.
                
                TrustUser result = apiInstance.PostOrgauthorizationTrusteeUsers(trusteeOrgId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteeUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **body** | [**TrustUserCreate**](TrustUserCreate.html)| Trust |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

<a name="postorgauthorizationtrustees"></a>

## [**Trustee**](Trustee.html) PostOrgauthorizationTrustees (TrustCreate body)

Create a new organization authorization trust. This is required to grant other organizations access to your organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrusteesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            
            var body = new TrustCreate(); // TrustCreate | Trust
            
            

            try
            {
                
                // Create a new organization authorization trust. This is required to grant other organizations access to your organization.
                
                Trustee result = apiInstance.PostOrgauthorizationTrustees(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrustees: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustCreate**](TrustCreate.html)| Trust |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="postorgauthorizationtrusteesaudits"></a>

## [**AuditQueryResponse**](AuditQueryResponse.html) PostOrgauthorizationTrusteesAudits (TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)

Get Org Trustee Audits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrusteesAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            
            var body = new TrusteeAuditQueryRequest(); // TrusteeAuditQueryRequest | Values to scope the request.
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to descending)
            
            
            

            try
            {
                
                // Get Org Trustee Audits
                
                AuditQueryResponse result = apiInstance.PostOrgauthorizationTrusteesAudits(body, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteesAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrusteeAuditQueryRequest**](TrusteeAuditQueryRequest.html)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp] |
| **sortOrder** | **string**| Sort order | [optional] [default to descending] |
{: class="table table-striped"}

### Return type

[**AuditQueryResponse**](AuditQueryResponse.html)

<a name="postorgauthorizationtrustoraudits"></a>

## [**AuditQueryResponse**](AuditQueryResponse.html) PostOrgauthorizationTrustorAudits (TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)

Get Org Trustor Audits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrustorAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            
            var body = new TrustorAuditQueryRequest(); // TrustorAuditQueryRequest | Values to scope the request.
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to descending)
            
            
            

            try
            {
                
                // Get Org Trustor Audits
                
                AuditQueryResponse result = apiInstance.PostOrgauthorizationTrustorAudits(body, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrustorAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustorAuditQueryRequest**](TrustorAuditQueryRequest.html)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp] |
| **sortOrder** | **string**| Sort order | [optional] [default to descending] |
{: class="table table-striped"}

### Return type

[**AuditQueryResponse**](AuditQueryResponse.html)

<a name="putorgauthorizationtrustee"></a>

## [**Trustee**](Trustee.html) PutOrgauthorizationTrustee (string trusteeOrgId, Trustee body)

Update Org Trust



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrusteeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            
            var body = new Trustee(); // Trustee | Client
            
            

            try
            {
                
                // Update Org Trust
                
                Trustee result = apiInstance.PutOrgauthorizationTrustee(trusteeOrgId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrustee: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **body** | [**Trustee**](Trustee.html)| Client |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="putorgauthorizationtrusteeuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId, List<string> body)

Update Trustee User Roles



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrusteeUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            
            
            var body = ;  // List<string> | List of roles
            
            
            

            try
            {
                
                // Update Trustee User Roles
                
                UserAuthorization result = apiInstance.PutOrgauthorizationTrusteeUserRoles(trusteeOrgId, trusteeUserId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrusteeUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
| **body** | **List<string>**| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putorgauthorizationtrustoruser"></a>

## [**TrustUser**](TrustUser.html) PutOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)

Add a Trustee user to the trust.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrustorUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationAuthorizationApi();
            
            
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            
            
            
            
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            
            
            

            try
            {
                
                // Add a Trustee user to the trust.
                
                TrustUser result = apiInstance.PutOrgauthorizationTrustorUser(trustorOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrustorUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

