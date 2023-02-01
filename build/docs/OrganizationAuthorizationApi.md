---
title: OrganizationAuthorizationApi
---
## PureCloudPlatform.Client.V2.Api.OrganizationAuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustee) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrusteeCloneduser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteecloneduser) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers/{trusteeUserId} | Deletes cloned user |
| [**DeleteOrgauthorizationTrusteeGroup**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteegroup) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId} | Delete Trustee Group |
| [**DeleteOrgauthorizationTrusteeGroupRoles**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteegrouproles) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Delete Trustee Group Roles |
| [**DeleteOrgauthorizationTrusteeUser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteeuser) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**DeleteOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrusteeuserroles) | **DELETE** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Delete Trustee User Roles |
| [**DeleteOrgauthorizationTrustor**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustor) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrustorCloneduser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustorcloneduser) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Delete Cloned User |
| [**DeleteOrgauthorizationTrustorGroup**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustorgroup) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Delete Trustee Group |
| [**DeleteOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#deleteorgauthorizationtrustoruser) | **DELETE** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**GetOrgauthorizationPairing**](OrganizationAuthorizationApi.html#getorgauthorizationpairing) | **GET** /api/v2/orgauthorization/pairings/{pairingId} | Get Pairing Info |
| [**GetOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#getorgauthorizationtrustee) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrusteeClonedusers**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeclonedusers) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers | The list of cloned users from the trustee organization (i.e. users with a native user record). |
| [**GetOrgauthorizationTrusteeGroup**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteegroup) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId} | Get Trustee Group |
| [**GetOrgauthorizationTrusteeGroupRoles**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteegrouproles) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Get Trustee Group Roles |
| [**GetOrgauthorizationTrusteeGroups**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteegroups) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups | The list of trustee groups for this organization (i.e. groups granted access to this organization). |
| [**GetOrgauthorizationTrusteeUser**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeuser) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeuserroles) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Get Trustee User Roles |
| [**GetOrgauthorizationTrusteeUsers**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteeusers) | **GET** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | The list of trustee users for this organization (i.e. users granted access to this organization). |
| [**GetOrgauthorizationTrustees**](OrganizationAuthorizationApi.html#getorgauthorizationtrustees) | **GET** /api/v2/orgauthorization/trustees | The list of trustees for this organization (i.e. organizations granted access to this organization). |
| [**GetOrgauthorizationTrusteesDefault**](OrganizationAuthorizationApi.html#getorgauthorizationtrusteesdefault) | **GET** /api/v2/orgauthorization/trustees/default | Get organization authorization trust with Customer Care, if one exists. |
| [**GetOrgauthorizationTrustor**](OrganizationAuthorizationApi.html#getorgauthorizationtrustor) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrustorCloneduser**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorcloneduser) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Get Cloned User |
| [**GetOrgauthorizationTrustorClonedusers**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorclonedusers) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers | The list of cloned users in the trustor organization (i.e. users with a native user record). |
| [**GetOrgauthorizationTrustorGroup**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorgroup) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Get Trustee Group |
| [**GetOrgauthorizationTrustorGroups**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorgroups) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups | The list of groups in the trustor organization (i.e. groups granted access). |
| [**GetOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#getorgauthorizationtrustoruser) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrustorUsers**](OrganizationAuthorizationApi.html#getorgauthorizationtrustorusers) | **GET** /api/v2/orgauthorization/trustors/{trustorOrgId}/users | The list of users in the trustor organization (i.e. users granted access). |
| [**GetOrgauthorizationTrustors**](OrganizationAuthorizationApi.html#getorgauthorizationtrustors) | **GET** /api/v2/orgauthorization/trustors | The list of organizations that have authorized/trusted your organization. |
| [**PostOrgauthorizationPairings**](OrganizationAuthorizationApi.html#postorgauthorizationpairings) | **POST** /api/v2/orgauthorization/pairings | A pairing id is created by the trustee and given to the trustor to create a trust. |
| [**PostOrgauthorizationTrusteeGroups**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteegroups) | **POST** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups | Add a group to the trust. |
| [**PostOrgauthorizationTrusteeUsers**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteeusers) | **POST** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | Add a user to the trust. |
| [**PostOrgauthorizationTrustees**](OrganizationAuthorizationApi.html#postorgauthorizationtrustees) | **POST** /api/v2/orgauthorization/trustees | Create a new organization authorization trust. This is required to grant other organizations access to your organization. |
| [**PostOrgauthorizationTrusteesAudits**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteesaudits) | **POST** /api/v2/orgauthorization/trustees/audits | Get Org Trustee Audits |
| [**PostOrgauthorizationTrusteesDefault**](OrganizationAuthorizationApi.html#postorgauthorizationtrusteesdefault) | **POST** /api/v2/orgauthorization/trustees/default | Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. |
| [**PostOrgauthorizationTrustorAudits**](OrganizationAuthorizationApi.html#postorgauthorizationtrustoraudits) | **POST** /api/v2/orgauthorization/trustor/audits | Get Org Trustor Audits |
| [**PutOrgauthorizationTrustee**](OrganizationAuthorizationApi.html#putorgauthorizationtrustee) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Update Org Trust |
| [**PutOrgauthorizationTrusteeGroupRoledivisions**](OrganizationAuthorizationApi.html#putorgauthorizationtrusteegrouproledivisions) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roledivisions | Update Trustee Group Roles |
| [**PutOrgauthorizationTrusteeGroupRoles**](OrganizationAuthorizationApi.html#putorgauthorizationtrusteegrouproles) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Update Trustee Group Roles |
| [**PutOrgauthorizationTrusteeUserRoledivisions**](OrganizationAuthorizationApi.html#putorgauthorizationtrusteeuserroledivisions) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roledivisions | Update Trustee User Roles |
| [**PutOrgauthorizationTrusteeUserRoles**](OrganizationAuthorizationApi.html#putorgauthorizationtrusteeuserroles) | **PUT** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Update Trustee User Roles |
| [**PutOrgauthorizationTrustorCloneduser**](OrganizationAuthorizationApi.html#putorgauthorizationtrustorcloneduser) | **PUT** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Creates a clone of the trustee user in the trustor org. |
| [**PutOrgauthorizationTrustorGroup**](OrganizationAuthorizationApi.html#putorgauthorizationtrustorgroup) | **PUT** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Add a Trustee Group to the trust. |
| [**PutOrgauthorizationTrustorUser**](OrganizationAuthorizationApi.html#putorgauthorizationtrustoruser) | **PUT** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Add a Trustee user to the trust. |
{: class="table table-striped"}

<a name="deleteorgauthorizationtrustee"></a>

## void DeleteOrgauthorizationTrustee (string trusteeOrgId)



Delete Org Trust



Requires ANY permissions: 

* authorization:orgTrustee:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteecloneduser"></a>

## void DeleteOrgauthorizationTrusteeCloneduser (string trusteeOrgId, string trusteeUserId)



Deletes cloned user



Requires ANY permissions: 

* directory:user:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeCloneduserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Id of the cloned user to delete

            try
            { 
                // Deletes cloned user
                apiInstance.DeleteOrgauthorizationTrusteeCloneduser(trusteeOrgId, trusteeUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrusteeCloneduser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Id of the cloned user to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteegroup"></a>

## void DeleteOrgauthorizationTrusteeGroup (string trusteeOrgId, string trusteeGroupId)



Delete Trustee Group



Requires ANY permissions: 

* authorization:orgTrusteeGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id

            try
            { 
                // Delete Trustee Group
                apiInstance.DeleteOrgauthorizationTrusteeGroup(trusteeOrgId, trusteeGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrusteeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteegrouproles"></a>

## void DeleteOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId)



Delete Trustee Group Roles



Requires ANY permissions: 

* authorization:orgTrusteeGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrusteeGroupRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id

            try
            { 
                // Delete Trustee Group Roles
                apiInstance.DeleteOrgauthorizationTrusteeGroupRoles(trusteeOrgId, trusteeGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrusteeGroupRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrusteeuser"></a>

## void DeleteOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)



Delete Trustee User



Requires ANY permissions: 

* authorization:orgTrusteeUser:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrusteeUser:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustor:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrustorcloneduser"></a>

## void DeleteOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)



Delete Cloned User



Requires ANY permissions: 

* authorization:orgTrusteeUser:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrustorCloneduserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id

            try
            { 
                // Delete Cloned User
                apiInstance.DeleteOrgauthorizationTrustorCloneduser(trustorOrgId, trusteeUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustorCloneduser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrustorgroup"></a>

## void DeleteOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)



Delete Trustee Group



Requires ANY permissions: 

* authorization:orgTrusteeGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrgauthorizationTrustorGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trustorGroupId = trustorGroupId_example;  // string | Trustor Group Id

            try
            { 
                // Delete Trustee Group
                apiInstance.DeleteOrgauthorizationTrustorGroup(trustorOrgId, trustorGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustorGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trustorGroupId** | **string**| Trustor Group Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorgauthorizationtrustoruser"></a>

## void DeleteOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)



Delete Trustee User



Requires ANY permissions: 

* authorization:orgTrusteeUser:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustee:view
* authorization:orgTrustor:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustee:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="getorgauthorizationtrusteeclonedusers"></a>

## [**ClonedUserEntityListing**](ClonedUserEntityListing.html) GetOrgauthorizationTrusteeClonedusers (string trusteeOrgId)



The list of cloned users from the trustee organization (i.e. users with a native user record).

There can be no more than 5 cloned users per organization, so results are represented as simple list and not paged



Requires ANY permissions: 

* directory:user:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeClonedusersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id

            try
            { 
                // The list of cloned users from the trustee organization (i.e. users with a native user record).
                ClonedUserEntityListing result = apiInstance.GetOrgauthorizationTrusteeClonedusers(trusteeOrgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeClonedusers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
{: class="table table-striped"}

### Return type

[**ClonedUserEntityListing**](ClonedUserEntityListing.html)

<a name="getorgauthorizationtrusteegroup"></a>

## [**TrustGroup**](TrustGroup.html) GetOrgauthorizationTrusteeGroup (string trusteeOrgId, string trusteeGroupId)



Get Trustee Group



Requires ANY permissions: 

* authorization:orgTrusteeGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id

            try
            { 
                // Get Trustee Group
                TrustGroup result = apiInstance.GetOrgauthorizationTrusteeGroup(trusteeOrgId, trusteeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
{: class="table table-striped"}

### Return type

[**TrustGroup**](TrustGroup.html)

<a name="getorgauthorizationtrusteegrouproles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId)



Get Trustee Group Roles



Requires ANY permissions: 

* authorization:orgTrusteeGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeGroupRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id

            try
            { 
                // Get Trustee Group Roles
                UserAuthorization result = apiInstance.GetOrgauthorizationTrusteeGroupRoles(trusteeOrgId, trusteeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeGroupRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="getorgauthorizationtrusteegroups"></a>

## [**TrustGroupEntityListing**](TrustGroupEntityListing.html) GetOrgauthorizationTrusteeGroups (string trusteeOrgId, int? pageSize = null, int? pageNumber = null)



The list of trustee groups for this organization (i.e. groups granted access to this organization).



Requires ANY permissions: 

* authorization:orgTrusteeGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteeGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // The list of trustee groups for this organization (i.e. groups granted access to this organization).
                TrustGroupEntityListing result = apiInstance.GetOrgauthorizationTrusteeGroups(trusteeOrgId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteeGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustGroupEntityListing**](TrustGroupEntityListing.html)

<a name="getorgauthorizationtrusteeuser"></a>

## [**TrustUser**](TrustUser.html) GetOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)



Get Trustee User



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustee:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustEntityListing**](TrustEntityListing.html)

<a name="getorgauthorizationtrusteesdefault"></a>

## [**Trustee**](Trustee.html) GetOrgauthorizationTrusteesDefault ()



Get organization authorization trust with Customer Care, if one exists.



Requires ANY permissions: 

* authorization:orgTrustee:view
* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrusteesDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();

            try
            { 
                // Get organization authorization trust with Customer Care, if one exists.
                Trustee result = apiInstance.GetOrgauthorizationTrusteesDefault();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteesDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**Trustee**](Trustee.html)

<a name="getorgauthorizationtrustor"></a>

## [**Trustor**](Trustor.html) GetOrgauthorizationTrustor (string trustorOrgId)



Get Org Trust



Requires ANY permissions: 

* authorization:orgTrustor:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
{: class="table table-striped"}

### Return type

[**Trustor**](Trustor.html)

<a name="getorgauthorizationtrustorcloneduser"></a>

## [**ClonedUser**](ClonedUser.html) GetOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)



Get Cloned User



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorCloneduserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id

            try
            { 
                // Get Cloned User
                ClonedUser result = apiInstance.GetOrgauthorizationTrustorCloneduser(trustorOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorCloneduser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**ClonedUser**](ClonedUser.html)

<a name="getorgauthorizationtrustorclonedusers"></a>

## [**ClonedUserEntityListing**](ClonedUserEntityListing.html) GetOrgauthorizationTrustorClonedusers (string trustorOrgId)



The list of cloned users in the trustor organization (i.e. users with a native user record).



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorClonedusersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id

            try
            { 
                // The list of cloned users in the trustor organization (i.e. users with a native user record).
                ClonedUserEntityListing result = apiInstance.GetOrgauthorizationTrustorClonedusers(trustorOrgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorClonedusers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
{: class="table table-striped"}

### Return type

[**ClonedUserEntityListing**](ClonedUserEntityListing.html)

<a name="getorgauthorizationtrustorgroup"></a>

## [**TrustGroup**](TrustGroup.html) GetOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)



Get Trustee Group



Requires ANY permissions: 

* authorization:orgTrusteeGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trustorGroupId = trustorGroupId_example;  // string | Trustor Group Id

            try
            { 
                // Get Trustee Group
                TrustGroup result = apiInstance.GetOrgauthorizationTrustorGroup(trustorOrgId, trustorGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trustorGroupId** | **string**| Trustor Group Id |  |
{: class="table table-striped"}

### Return type

[**TrustGroup**](TrustGroup.html)

<a name="getorgauthorizationtrustorgroups"></a>

## [**TrustGroupEntityListing**](TrustGroupEntityListing.html) GetOrgauthorizationTrustorGroups (string trustorOrgId, int? pageSize = null, int? pageNumber = null)



The list of groups in the trustor organization (i.e. groups granted access).



Requires ANY permissions: 

* authorization:orgTrusteeGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrgauthorizationTrustorGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustee Organization Id
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // The list of groups in the trustor organization (i.e. groups granted access).
                TrustGroupEntityListing result = apiInstance.GetOrgauthorizationTrustorGroups(trustorOrgId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrustorGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustee Organization Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustGroupEntityListing**](TrustGroupEntityListing.html)

<a name="getorgauthorizationtrustoruser"></a>

## [**TrustUser**](TrustUser.html) GetOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)



Get Trustee User



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrusteeUser:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustor:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* authorization:orgTrustee:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustRequestCreate**](TrustRequestCreate.html)| Pairing Info |  |
{: class="table table-striped"}

### Return type

[**TrustRequest**](TrustRequest.html)

<a name="postorgauthorizationtrusteegroups"></a>

## [**TrustGroup**](TrustGroup.html) PostOrgauthorizationTrusteeGroups (string trusteeOrgId, TrustMemberCreate body)



Add a group to the trust.



Requires ANY permissions: 

* authorization:orgTrusteeGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrusteeGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var body = new TrustMemberCreate(); // TrustMemberCreate | Trust

            try
            { 
                // Add a group to the trust.
                TrustGroup result = apiInstance.PostOrgauthorizationTrusteeGroups(trusteeOrgId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteeGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **body** | [**TrustMemberCreate**](TrustMemberCreate.html)| Trust |  |
{: class="table table-striped"}

### Return type

[**TrustGroup**](TrustGroup.html)

<a name="postorgauthorizationtrusteeusers"></a>

## [**TrustUser**](TrustUser.html) PostOrgauthorizationTrusteeUsers (string trusteeOrgId, TrustMemberCreate body)



Add a user to the trust.



Requires ANY permissions: 

* authorization:orgTrusteeUser:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var body = new TrustMemberCreate(); // TrustMemberCreate | Trust

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **body** | [**TrustMemberCreate**](TrustMemberCreate.html)| Trust |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

<a name="postorgauthorizationtrustees"></a>

## [**Trustee**](Trustee.html) PostOrgauthorizationTrustees (TrustCreate body)



Create a new organization authorization trust. This is required to grant other organizations access to your organization.



Requires ALL permissions: 

* authorization:orgTrustee:add
* authorization:orgTrusteeUser:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustCreate**](TrustCreate.html)| Trust |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="postorgauthorizationtrusteesaudits"></a>

## **Object** PostOrgauthorizationTrusteesAudits (TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)



Get Org Trustee Audits



Requires ANY permissions: 

* authorization:audit:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var body = new TrusteeAuditQueryRequest(); // TrusteeAuditQueryRequest | Values to scope the request.
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "timestamp")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "descending")

            try
            { 
                // Get Org Trustee Audits
                Object result = apiInstance.PostOrgauthorizationTrusteesAudits(body, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteesAudits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrusteeAuditQueryRequest**](TrusteeAuditQueryRequest.html)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "timestamp"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "descending"] |
{: class="table table-striped"}

### Return type

**Object**

<a name="postorgauthorizationtrusteesdefault"></a>

## [**Trustee**](Trustee.html) PostOrgauthorizationTrusteesDefault (bool? assignDefaultRole = null, bool? autoExpire = null)



Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.



Requires ALL permissions: 

* authorization:orgTrustee:add
* authorization:orgTrusteeUser:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOrgauthorizationTrusteesDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var assignDefaultRole = true;  // bool? | Assign Admin role to default pairing with Customer Care (optional) 
            var autoExpire = true;  // bool? | Automatically expire pairing after 30 days (optional) 

            try
            { 
                // Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
                Trustee result = apiInstance.PostOrgauthorizationTrusteesDefault(assignDefaultRole, autoExpire);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteesDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignDefaultRole** | **bool?**| Assign Admin role to default pairing with Customer Care | [optional]  |
| **autoExpire** | **bool?**| Automatically expire pairing after 30 days | [optional]  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="postorgauthorizationtrustoraudits"></a>

## **Object** PostOrgauthorizationTrustorAudits (TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)



Get Org Trustor Audits



Requires ANY permissions: 

* authorization:audit:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var body = new TrustorAuditQueryRequest(); // TrustorAuditQueryRequest | Values to scope the request.
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "timestamp")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "descending")

            try
            { 
                // Get Org Trustor Audits
                Object result = apiInstance.PostOrgauthorizationTrustorAudits(body, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrustorAudits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrustorAuditQueryRequest**](TrustorAuditQueryRequest.html)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "timestamp"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "descending"] |
{: class="table table-striped"}

### Return type

**Object**

<a name="putorgauthorizationtrustee"></a>

## [**Trustee**](Trustee.html) PutOrgauthorizationTrustee (string trusteeOrgId, TrustUpdate body)



Update Org Trust



Requires ANY permissions: 

* authorization:orgTrustee:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var body = new TrustUpdate(); // TrustUpdate | Client

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **body** | [**TrustUpdate**](TrustUpdate.html)| Client |  |
{: class="table table-striped"}

### Return type

[**Trustee**](Trustee.html)

<a name="putorgauthorizationtrusteegrouproledivisions"></a>

## [**UserAuthorization**](UserAuthorization.html) PutOrgauthorizationTrusteeGroupRoledivisions (string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)



Update Trustee Group Roles



Requires ANY permissions: 

* authorization:orgTrusteeGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrusteeGroupRoledivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Set of roles with corresponding divisions to apply

            try
            { 
                // Update Trustee Group Roles
                UserAuthorization result = apiInstance.PutOrgauthorizationTrusteeGroupRoledivisions(trusteeOrgId, trusteeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrusteeGroupRoledivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Set of roles with corresponding divisions to apply |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putorgauthorizationtrusteegrouproles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId, List<string> body)



Update Trustee Group Roles



Requires ANY permissions: 

* authorization:orgTrusteeGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrusteeGroupRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeGroupId = trusteeGroupId_example;  // string | Trustee Group Id
            var body = new List<string>(); // List<string> | List of roles

            try
            { 
                // Update Trustee Group Roles
                UserAuthorization result = apiInstance.PutOrgauthorizationTrusteeGroupRoles(trusteeOrgId, trusteeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrusteeGroupRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeGroupId** | **string**| Trustee Group Id |  |
| **body** | [**List<string>**](string.html)| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putorgauthorizationtrusteeuserroledivisions"></a>

## [**UserAuthorization**](UserAuthorization.html) PutOrgauthorizationTrusteeUserRoledivisions (string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)



Update Trustee User Roles



Requires ANY permissions: 

* authorization:orgTrusteeUser:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrusteeUserRoledivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Set of roles with corresponding divisions to apply

            try
            { 
                // Update Trustee User Roles
                UserAuthorization result = apiInstance.PutOrgauthorizationTrusteeUserRoledivisions(trusteeOrgId, trusteeUserId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrusteeUserRoledivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Set of roles with corresponding divisions to apply |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putorgauthorizationtrusteeuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId, List<string> body)



Update Trustee User Roles



Requires ANY permissions: 

* authorization:orgTrusteeUser:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trusteeOrgId = trusteeOrgId_example;  // string | Trustee Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id
            var body = new List<string>(); // List<string> | List of roles

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trusteeOrgId** | **string**| Trustee Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
| **body** | [**List<string>**](string.html)| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putorgauthorizationtrustorcloneduser"></a>

## [**ClonedUser**](ClonedUser.html) PutOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)



Creates a clone of the trustee user in the trustor org.



Requires ALL permissions: 

* authorization:orgTrusteeUser:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrustorCloneduserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trusteeUserId = trusteeUserId_example;  // string | Trustee User Id

            try
            { 
                // Creates a clone of the trustee user in the trustor org.
                ClonedUser result = apiInstance.PutOrgauthorizationTrustorCloneduser(trustorOrgId, trusteeUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrustorCloneduser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**ClonedUser**](ClonedUser.html)

<a name="putorgauthorizationtrustorgroup"></a>

## [**TrustGroup**](TrustGroup.html) PutOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)



Add a Trustee Group to the trust.



Requires ALL permissions: 

* authorization:orgTrusteeGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrgauthorizationTrustorGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationAuthorizationApi();
            var trustorOrgId = trustorOrgId_example;  // string | Trustor Organization Id
            var trustorGroupId = trustorGroupId_example;  // string | Trustor Group Id

            try
            { 
                // Add a Trustee Group to the trust.
                TrustGroup result = apiInstance.PutOrgauthorizationTrustorGroup(trustorOrgId, trustorGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PutOrgauthorizationTrustorGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trustorGroupId** | **string**| Trustor Group Id |  |
{: class="table table-striped"}

### Return type

[**TrustGroup**](TrustGroup.html)

<a name="putorgauthorizationtrustoruser"></a>

## [**TrustUser**](TrustUser.html) PutOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)



Add a Trustee user to the trust.



Requires ALL permissions: 

* authorization:orgTrusteeUser:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| Trustor Organization Id |  |
| **trusteeUserId** | **string**| Trustee User Id |  |
{: class="table table-striped"}

### Return type

[**TrustUser**](TrustUser.html)

