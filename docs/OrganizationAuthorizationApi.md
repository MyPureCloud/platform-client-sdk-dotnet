# OrganizationAuthorizationApi

## PureCloudPlatform.Client.V2.Api.OrganizationAuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOrgauthorizationTrustee**](#DeleteOrgauthorizationTrustee) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrusteeCloneduser**](#DeleteOrgauthorizationTrusteeCloneduser) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers/{trusteeUserId} | Deletes cloned user |
| [**DeleteOrgauthorizationTrusteeGroup**](#DeleteOrgauthorizationTrusteeGroup) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId} | Delete Trustee Group |
| [**DeleteOrgauthorizationTrusteeGroupRoles**](#DeleteOrgauthorizationTrusteeGroupRoles) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Delete Trustee Group Roles |
| [**DeleteOrgauthorizationTrusteeUser**](#DeleteOrgauthorizationTrusteeUser) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**DeleteOrgauthorizationTrusteeUserRoles**](#DeleteOrgauthorizationTrusteeUserRoles) | **Delete** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Delete Trustee User Roles |
| [**DeleteOrgauthorizationTrustees**](#DeleteOrgauthorizationTrustees) | **Delete** /api/v2/orgauthorization/trustees | Delete Bulk Org Trustees |
| [**DeleteOrgauthorizationTrustor**](#DeleteOrgauthorizationTrustor) | **Delete** /api/v2/orgauthorization/trustors/{trustorOrgId} | Delete Org Trust |
| [**DeleteOrgauthorizationTrustorCloneduser**](#DeleteOrgauthorizationTrustorCloneduser) | **Delete** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Delete Cloned User |
| [**DeleteOrgauthorizationTrustorGroup**](#DeleteOrgauthorizationTrustorGroup) | **Delete** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Delete Trustee Group |
| [**DeleteOrgauthorizationTrustorUser**](#DeleteOrgauthorizationTrustorUser) | **Delete** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Delete Trustee User |
| [**DeleteOrgauthorizationTrustors**](#DeleteOrgauthorizationTrustors) | **Delete** /api/v2/orgauthorization/trustors | Delete Bulk Org Trustors |
| [**GetOrgauthorizationPairing**](#GetOrgauthorizationPairing) | **Get** /api/v2/orgauthorization/pairings/{pairingId} | Get Pairing Info |
| [**GetOrgauthorizationTrustee**](#GetOrgauthorizationTrustee) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrusteeClonedusers**](#GetOrgauthorizationTrusteeClonedusers) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/clonedusers | The list of cloned users from the trustee organization (i.e. users with a native user record). |
| [**GetOrgauthorizationTrusteeGroup**](#GetOrgauthorizationTrusteeGroup) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId} | Get Trustee Group |
| [**GetOrgauthorizationTrusteeGroupRoles**](#GetOrgauthorizationTrusteeGroupRoles) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Get Trustee Group Roles |
| [**GetOrgauthorizationTrusteeGroups**](#GetOrgauthorizationTrusteeGroups) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups | The list of trustee groups for this organization (i.e. groups granted access to this organization). |
| [**GetOrgauthorizationTrusteeUser**](#GetOrgauthorizationTrusteeUser) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrusteeUserRoles**](#GetOrgauthorizationTrusteeUserRoles) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Get Trustee User Roles |
| [**GetOrgauthorizationTrusteeUsers**](#GetOrgauthorizationTrusteeUsers) | **Get** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | The list of trustee users for this organization (i.e. users granted access to this organization). |
| [**GetOrgauthorizationTrustees**](#GetOrgauthorizationTrustees) | **Get** /api/v2/orgauthorization/trustees | The list of trustees for this organization (i.e. organizations granted access to this organization). |
| [**GetOrgauthorizationTrusteesCare**](#GetOrgauthorizationTrusteesCare) | **Get** /api/v2/orgauthorization/trustees/care | Get Customer Care organization ids. |
| [**GetOrgauthorizationTrusteesDefault**](#GetOrgauthorizationTrusteesDefault) | **Get** /api/v2/orgauthorization/trustees/default | Get organization authorization trust with Customer Care, if one exists. |
| [**GetOrgauthorizationTrustor**](#GetOrgauthorizationTrustor) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId} | Get Org Trust |
| [**GetOrgauthorizationTrustorCloneduser**](#GetOrgauthorizationTrustorCloneduser) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Get Cloned User |
| [**GetOrgauthorizationTrustorClonedusers**](#GetOrgauthorizationTrustorClonedusers) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers | The list of cloned users in the trustor organization (i.e. users with a native user record). |
| [**GetOrgauthorizationTrustorGroup**](#GetOrgauthorizationTrustorGroup) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Get Trustee Group |
| [**GetOrgauthorizationTrustorGroups**](#GetOrgauthorizationTrustorGroups) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups | The list of groups in the trustor organization (i.e. groups granted access). |
| [**GetOrgauthorizationTrustorUser**](#GetOrgauthorizationTrustorUser) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Get Trustee User |
| [**GetOrgauthorizationTrustorUsers**](#GetOrgauthorizationTrustorUsers) | **Get** /api/v2/orgauthorization/trustors/{trustorOrgId}/users | The list of users in the trustor organization (i.e. users granted access). |
| [**GetOrgauthorizationTrustors**](#GetOrgauthorizationTrustors) | **Get** /api/v2/orgauthorization/trustors | The list of organizations that have authorized/trusted your organization. |
| [**PostOrgauthorizationPairings**](#PostOrgauthorizationPairings) | **Post** /api/v2/orgauthorization/pairings | A pairing id is created by the trustee and given to the trustor to create a trust. |
| [**PostOrgauthorizationTrusteeGroups**](#PostOrgauthorizationTrusteeGroups) | **Post** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups | Add a group to the trust. |
| [**PostOrgauthorizationTrusteeUsers**](#PostOrgauthorizationTrusteeUsers) | **Post** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users | Add a user to the trust. |
| [**PostOrgauthorizationTrustees**](#PostOrgauthorizationTrustees) | **Post** /api/v2/orgauthorization/trustees | Create a new organization authorization trust. This is required to grant other organizations access to your organization. |
| [**PostOrgauthorizationTrusteesAudits**](#PostOrgauthorizationTrusteesAudits) | **Post** /api/v2/orgauthorization/trustees/audits | Get Org Trustee Audits |
| [**PostOrgauthorizationTrusteesCare**](#PostOrgauthorizationTrusteesCare) | **Post** /api/v2/orgauthorization/trustees/care | Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. |
| [**PostOrgauthorizationTrusteesDefault**](#PostOrgauthorizationTrusteesDefault) | **Post** /api/v2/orgauthorization/trustees/default | Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization. |
| [**PostOrgauthorizationTrustorAudits**](#PostOrgauthorizationTrustorAudits) | **Post** /api/v2/orgauthorization/trustor/audits | Get Org Trustor Audits |
| [**PutOrgauthorizationTrustee**](#PutOrgauthorizationTrustee) | **Put** /api/v2/orgauthorization/trustees/{trusteeOrgId} | Update Org Trust |
| [**PutOrgauthorizationTrusteeGroupRoledivisions**](#PutOrgauthorizationTrusteeGroupRoledivisions) | **Put** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roledivisions | Update Trustee Group Roles |
| [**PutOrgauthorizationTrusteeGroupRoles**](#PutOrgauthorizationTrusteeGroupRoles) | **Put** /api/v2/orgauthorization/trustees/{trusteeOrgId}/groups/{trusteeGroupId}/roles | Update Trustee Group Roles |
| [**PutOrgauthorizationTrusteeUserRoledivisions**](#PutOrgauthorizationTrusteeUserRoledivisions) | **Put** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roledivisions | Update Trustee User Roles |
| [**PutOrgauthorizationTrusteeUserRoles**](#PutOrgauthorizationTrusteeUserRoles) | **Put** /api/v2/orgauthorization/trustees/{trusteeOrgId}/users/{trusteeUserId}/roles | Update Trustee User Roles |
| [**PutOrgauthorizationTrustorCloneduser**](#PutOrgauthorizationTrustorCloneduser) | **Put** /api/v2/orgauthorization/trustors/{trustorOrgId}/clonedusers/{trusteeUserId} | Creates a clone of the trustee user in the trustor org. |
| [**PutOrgauthorizationTrustorGroup**](#PutOrgauthorizationTrustorGroup) | **Put** /api/v2/orgauthorization/trustors/{trustorOrgId}/groups/{trustorGroupId} | Add a Trustee Group to the trust. |
| [**PutOrgauthorizationTrustorUser**](#PutOrgauthorizationTrustorUser) | **Put** /api/v2/orgauthorization/trustors/{trustorOrgId}/users/{trusteeUserId} | Add a Trustee user to the trust. |



## DeleteOrgauthorizationTrustee

> void DeleteOrgauthorizationTrustee (string trusteeOrgId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrusteeCloneduser

> void DeleteOrgauthorizationTrusteeCloneduser (string trusteeOrgId, string trusteeUserId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrusteeGroup

> void DeleteOrgauthorizationTrusteeGroup (string trusteeOrgId, string trusteeGroupId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrusteeGroupRoles

> void DeleteOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrusteeUser

> void DeleteOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrusteeUserRoles

> void DeleteOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustees

> void DeleteOrgauthorizationTrustees (List<string> id)


Delete Bulk Org Trustees

DeleteOrgauthorizationTrustees is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class DeleteOrgauthorizationTrusteesExample
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
            var id = new List<string>(); // List<string> | Comma separated list of trustee ids to remove

            try
            { 
                // Delete Bulk Org Trustees
                apiInstance.DeleteOrgauthorizationTrustees(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustees: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| Comma separated list of trustee ids to remove |  |

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustor

> void DeleteOrgauthorizationTrustor (string trustorOrgId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustorCloneduser

> void DeleteOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustorGroup

> void DeleteOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustorUser

> void DeleteOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)


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

### Return type

void (empty response body)


## DeleteOrgauthorizationTrustors

> void DeleteOrgauthorizationTrustors (List<string> id)


Delete Bulk Org Trustors

DeleteOrgauthorizationTrustors is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class DeleteOrgauthorizationTrustorsExample
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
            var id = new List<string>(); // List<string> | Comma separated list of trustor ids to remove

            try
            { 
                // Delete Bulk Org Trustors
                apiInstance.DeleteOrgauthorizationTrustors(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.DeleteOrgauthorizationTrustors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| Comma separated list of trustor ids to remove |  |

### Return type

void (empty response body)


## GetOrgauthorizationPairing

> [**TrustRequest**](TrustRequest) GetOrgauthorizationPairing (string pairingId)


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

### Return type

[**TrustRequest**](TrustRequest)


## GetOrgauthorizationTrustee

> [**Trustee**](Trustee) GetOrgauthorizationTrustee (string trusteeOrgId)


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

### Return type

[**Trustee**](Trustee)


## GetOrgauthorizationTrusteeClonedusers

> [**ClonedUserEntityListing**](ClonedUserEntityListing) GetOrgauthorizationTrusteeClonedusers (string trusteeOrgId)


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

### Return type

[**ClonedUserEntityListing**](ClonedUserEntityListing)


## GetOrgauthorizationTrusteeGroup

> [**TrustGroup**](TrustGroup) GetOrgauthorizationTrusteeGroup (string trusteeOrgId, string trusteeGroupId)


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

### Return type

[**TrustGroup**](TrustGroup)


## GetOrgauthorizationTrusteeGroupRoles

> [**UserAuthorization**](UserAuthorization) GetOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId)


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

### Return type

[**UserAuthorization**](UserAuthorization)


## GetOrgauthorizationTrusteeGroups

> [**TrustGroupEntityListing**](TrustGroupEntityListing) GetOrgauthorizationTrusteeGroups (string trusteeOrgId, int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustGroupEntityListing**](TrustGroupEntityListing)


## GetOrgauthorizationTrusteeUser

> [**TrustUser**](TrustUser) GetOrgauthorizationTrusteeUser (string trusteeOrgId, string trusteeUserId)


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

### Return type

[**TrustUser**](TrustUser)


## GetOrgauthorizationTrusteeUserRoles

> [**UserAuthorization**](UserAuthorization) GetOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId)


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

### Return type

[**UserAuthorization**](UserAuthorization)


## GetOrgauthorizationTrusteeUsers

> [**TrustUserEntityListing**](TrustUserEntityListing) GetOrgauthorizationTrusteeUsers (string trusteeOrgId, int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustUserEntityListing**](TrustUserEntityListing)


## GetOrgauthorizationTrustees

> [**TrustEntityListing**](TrustEntityListing) GetOrgauthorizationTrustees (int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustEntityListing**](TrustEntityListing)


## GetOrgauthorizationTrusteesCare

> [**TrusteeReferenceList**](TrusteeReferenceList) GetOrgauthorizationTrusteesCare ()


Get Customer Care organization ids.

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
    public class GetOrgauthorizationTrusteesCareExample
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
                // Get Customer Care organization ids.
                TrusteeReferenceList result = apiInstance.GetOrgauthorizationTrusteesCare();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.GetOrgauthorizationTrusteesCare: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TrusteeReferenceList**](TrusteeReferenceList)


## GetOrgauthorizationTrusteesDefault

> [**Trustee**](Trustee) GetOrgauthorizationTrusteesDefault ()


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

[**Trustee**](Trustee)


## GetOrgauthorizationTrustor

> [**Trustor**](Trustor) GetOrgauthorizationTrustor (string trustorOrgId)


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

### Return type

[**Trustor**](Trustor)


## GetOrgauthorizationTrustorCloneduser

> [**ClonedUser**](ClonedUser) GetOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)


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

### Return type

[**ClonedUser**](ClonedUser)


## GetOrgauthorizationTrustorClonedusers

> [**ClonedUserEntityListing**](ClonedUserEntityListing) GetOrgauthorizationTrustorClonedusers (string trustorOrgId)


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

### Return type

[**ClonedUserEntityListing**](ClonedUserEntityListing)


## GetOrgauthorizationTrustorGroup

> [**TrustGroup**](TrustGroup) GetOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)


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

### Return type

[**TrustGroup**](TrustGroup)


## GetOrgauthorizationTrustorGroups

> [**TrustGroupEntityListing**](TrustGroupEntityListing) GetOrgauthorizationTrustorGroups (string trustorOrgId, int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustGroupEntityListing**](TrustGroupEntityListing)


## GetOrgauthorizationTrustorUser

> [**TrustUser**](TrustUser) GetOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)


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

### Return type

[**TrustUser**](TrustUser)


## GetOrgauthorizationTrustorUsers

> [**TrustUserEntityListing**](TrustUserEntityListing) GetOrgauthorizationTrustorUsers (string trustorOrgId, int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustUserEntityListing**](TrustUserEntityListing)


## GetOrgauthorizationTrustors

> [**TrustorEntityListing**](TrustorEntityListing) GetOrgauthorizationTrustors (int? pageSize = null, int? pageNumber = null)


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

### Return type

[**TrustorEntityListing**](TrustorEntityListing)


## PostOrgauthorizationPairings

> [**TrustRequest**](TrustRequest) PostOrgauthorizationPairings (TrustRequestCreate body)


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
| **body** | [**TrustRequestCreate**](TrustRequestCreate)| Pairing Info |  |

### Return type

[**TrustRequest**](TrustRequest)


## PostOrgauthorizationTrusteeGroups

> [**TrustGroup**](TrustGroup) PostOrgauthorizationTrusteeGroups (string trusteeOrgId, TrustMemberCreate body)


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
| **body** | [**TrustMemberCreate**](TrustMemberCreate)| Trust |  |

### Return type

[**TrustGroup**](TrustGroup)


## PostOrgauthorizationTrusteeUsers

> [**TrustUser**](TrustUser) PostOrgauthorizationTrusteeUsers (string trusteeOrgId, TrustMemberCreate body)


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
| **body** | [**TrustMemberCreate**](TrustMemberCreate)| Trust |  |

### Return type

[**TrustUser**](TrustUser)


## PostOrgauthorizationTrustees

> [**Trustee**](Trustee) PostOrgauthorizationTrustees (TrustCreate body)


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
| **body** | [**TrustCreate**](TrustCreate)| Trust |  |

### Return type

[**Trustee**](Trustee)


## PostOrgauthorizationTrusteesAudits

> **Object** PostOrgauthorizationTrusteesAudits (TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)


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
| **body** | [**TrusteeAuditQueryRequest**](TrusteeAuditQueryRequest)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "timestamp"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "descending"] |

### Return type

**Object**


## PostOrgauthorizationTrusteesCare

> [**TrustEntityListing**](TrustEntityListing) PostOrgauthorizationTrusteesCare (bool? assignDefaultRole = null, bool? autoExpire = null, bool? assignFullAccess = null, bool? allowTrustedUserAccess = null)


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
    public class PostOrgauthorizationTrusteesCareExample
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
            var assignFullAccess = true;  // bool? | Grant Customer Care full access to the organization (optional) 
            var allowTrustedUserAccess = true;  // bool? | Make Customer Care a Trusted User (optional) 

            try
            { 
                // Create a new organization authorization trust with Customer Care. This is required to grant your regional Customer Care organization access to your organization.
                TrustEntityListing result = apiInstance.PostOrgauthorizationTrusteesCare(assignDefaultRole, autoExpire, assignFullAccess, allowTrustedUserAccess);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationAuthorizationApi.PostOrgauthorizationTrusteesCare: " + e.Message );
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
| **assignFullAccess** | **bool?**| Grant Customer Care full access to the organization | [optional]  |
| **allowTrustedUserAccess** | **bool?**| Make Customer Care a Trusted User | [optional]  |

### Return type

[**TrustEntityListing**](TrustEntityListing)


## PostOrgauthorizationTrusteesDefault

> [**Trustee**](Trustee) PostOrgauthorizationTrusteesDefault (bool? assignDefaultRole = null, bool? autoExpire = null)


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

### Return type

[**Trustee**](Trustee)


## PostOrgauthorizationTrustorAudits

> **Object** PostOrgauthorizationTrustorAudits (TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)


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
| **body** | [**TrustorAuditQueryRequest**](TrustorAuditQueryRequest)| Values to scope the request. |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "timestamp"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "descending"] |

### Return type

**Object**


## PutOrgauthorizationTrustee

> [**Trustee**](Trustee) PutOrgauthorizationTrustee (string trusteeOrgId, TrustUpdate body)


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
| **body** | [**TrustUpdate**](TrustUpdate)| Client |  |

### Return type

[**Trustee**](Trustee)


## PutOrgauthorizationTrusteeGroupRoledivisions

> [**UserAuthorization**](UserAuthorization) PutOrgauthorizationTrusteeGroupRoledivisions (string trusteeOrgId, string trusteeGroupId, RoleDivisionGrants body)


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
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants)| Set of roles with corresponding divisions to apply |  |

### Return type

[**UserAuthorization**](UserAuthorization)


## PutOrgauthorizationTrusteeGroupRoles

> [**UserAuthorization**](UserAuthorization) PutOrgauthorizationTrusteeGroupRoles (string trusteeOrgId, string trusteeGroupId, List<string> body)


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
| **body** | [**List<string>**](string)| List of roles |  |

### Return type

[**UserAuthorization**](UserAuthorization)


## PutOrgauthorizationTrusteeUserRoledivisions

> [**UserAuthorization**](UserAuthorization) PutOrgauthorizationTrusteeUserRoledivisions (string trusteeOrgId, string trusteeUserId, RoleDivisionGrants body)


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
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants)| Set of roles with corresponding divisions to apply |  |

### Return type

[**UserAuthorization**](UserAuthorization)


## PutOrgauthorizationTrusteeUserRoles

> [**UserAuthorization**](UserAuthorization) PutOrgauthorizationTrusteeUserRoles (string trusteeOrgId, string trusteeUserId, List<string> body)


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
| **body** | [**List<string>**](string)| List of roles |  |

### Return type

[**UserAuthorization**](UserAuthorization)


## PutOrgauthorizationTrustorCloneduser

> [**ClonedUser**](ClonedUser) PutOrgauthorizationTrustorCloneduser (string trustorOrgId, string trusteeUserId)


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

### Return type

[**ClonedUser**](ClonedUser)


## PutOrgauthorizationTrustorGroup

> [**TrustGroup**](TrustGroup) PutOrgauthorizationTrustorGroup (string trustorOrgId, string trustorGroupId)


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

### Return type

[**TrustGroup**](TrustGroup)


## PutOrgauthorizationTrustorUser

> [**TrustUser**](TrustUser) PutOrgauthorizationTrustorUser (string trustorOrgId, string trusteeUserId)


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

### Return type

[**TrustUser**](TrustUser)


_PureCloudPlatform.Client.V2 252.0.0_
