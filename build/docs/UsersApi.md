---
title: UsersApi
---
## PureCloudPlatform.Client.V2.Api.UsersApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAuthorizationSubjectDivisionRole**](UsersApi.html#deleteauthorizationsubjectdivisionrole) | **DELETE** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Delete a grant of a role in a division |
| [**DeleteUser**](UsersApi.html#deleteuser) | **DELETE** /api/v2/users/{userId} | Delete user |
| [**DeleteUserExternalidAuthorityNameExternalKey**](UsersApi.html#deleteuserexternalidauthoritynameexternalkey) | **DELETE** /api/v2/users/{userId}/externalid/{authorityName}/{externalKey} | Delete the external identifier for user. |
| [**DeleteUserRoles**](UsersApi.html#deleteuserroles) | **DELETE** /api/v2/users/{userId}/roles | Removes all the roles from the user. |
| [**DeleteUserRoutinglanguage**](UsersApi.html#deleteuserroutinglanguage) | **DELETE** /api/v2/users/{userId}/routinglanguages/{languageId} | Remove routing language from user |
| [**DeleteUserRoutingskill**](UsersApi.html#deleteuserroutingskill) | **DELETE** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**DeleteUserStationAssociatedstation**](UsersApi.html#deleteuserstationassociatedstation) | **DELETE** /api/v2/users/{userId}/station/associatedstation | Clear associated station |
| [**DeleteUserStationDefaultstation**](UsersApi.html#deleteuserstationdefaultstation) | **DELETE** /api/v2/users/{userId}/station/defaultstation | Clear default station |
| [**GetAuthorizationDivisionspermittedMe**](UsersApi.html#getauthorizationdivisionspermittedme) | **GET** /api/v2/authorization/divisionspermitted/me | Returns whether or not current user can perform the specified action(s). |
| [**GetAuthorizationDivisionspermittedSubjectId**](UsersApi.html#getauthorizationdivisionspermittedsubjectid) | **GET** /api/v2/authorization/divisionspermitted/{subjectId} | Returns whether or not specified user can perform the specified action(s). |
| [**GetAuthorizationSubject**](UsersApi.html#getauthorizationsubject) | **GET** /api/v2/authorization/subjects/{subjectId} | Returns a listing of roles and permissions for a user. |
| [**GetAuthorizationSubjectsMe**](UsersApi.html#getauthorizationsubjectsme) | **GET** /api/v2/authorization/subjects/me | Returns a listing of roles and permissions for the currently authenticated user. |
| [**GetFieldconfig**](UsersApi.html#getfieldconfig) | **GET** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetProfilesUsers**](UsersApi.html#getprofilesusers) | **GET** /api/v2/profiles/users | Get a user profile listing |
| [**GetUser**](UsersApi.html#getuser) | **GET** /api/v2/users/{userId} | Get user. |
| [**GetUserAdjacents**](UsersApi.html#getuseradjacents) | **GET** /api/v2/users/{userId}/adjacents | Get adjacents |
| [**GetUserCallforwarding**](UsersApi.html#getusercallforwarding) | **GET** /api/v2/users/{userId}/callforwarding | Get a user&#39;s CallForwarding |
| [**GetUserDirectreports**](UsersApi.html#getuserdirectreports) | **GET** /api/v2/users/{userId}/directreports | Get direct reports |
| [**GetUserExternalid**](UsersApi.html#getuserexternalid) | **GET** /api/v2/users/{userId}/externalid | Get the external identifiers for a user. |
| [**GetUserExternalidAuthorityName**](UsersApi.html#getuserexternalidauthorityname) | **GET** /api/v2/users/{userId}/externalid/{authorityName} | Get the external identifier of user for an authority. |
| [**GetUserFavorites**](UsersApi.html#getuserfavorites) | **GET** /api/v2/users/{userId}/favorites | Get favorites |
| [**GetUserGeolocation**](UsersApi.html#getusergeolocation) | **GET** /api/v2/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**GetUserOutofoffice**](UsersApi.html#getuseroutofoffice) | **GET** /api/v2/users/{userId}/outofoffice | Get a OutOfOffice |
| [**GetUserProfile**](UsersApi.html#getuserprofile) | **GET** /api/v2/users/{userId}/profile | Get user profile |
| [**GetUserProfileskills**](UsersApi.html#getuserprofileskills) | **GET** /api/v2/users/{userId}/profileskills | List profile skills for a user |
| [**GetUserQueues**](UsersApi.html#getuserqueues) | **GET** /api/v2/users/{userId}/queues | Get queues for user |
| [**GetUserRoles**](UsersApi.html#getuserroles) | **GET** /api/v2/users/{userId}/roles | Returns a listing of roles and permissions for a user. |
| [**GetUserRoutinglanguages**](UsersApi.html#getuserroutinglanguages) | **GET** /api/v2/users/{userId}/routinglanguages | List routing language for user |
| [**GetUserRoutingskills**](UsersApi.html#getuserroutingskills) | **GET** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**GetUserRoutingstatus**](UsersApi.html#getuserroutingstatus) | **GET** /api/v2/users/{userId}/routingstatus | Fetch the routing status of a user |
| [**GetUserStation**](UsersApi.html#getuserstation) | **GET** /api/v2/users/{userId}/station | Get station information for user |
| [**GetUserSuperiors**](UsersApi.html#getusersuperiors) | **GET** /api/v2/users/{userId}/superiors | Get superiors |
| [**GetUserTrustors**](UsersApi.html#getusertrustors) | **GET** /api/v2/users/{userId}/trustors | List the organizations that have authorized/trusted the user. |
| [**GetUsers**](UsersApi.html#getusers) | **GET** /api/v2/users | Get the list of available users. |
| [**GetUsersExternalidAuthorityNameExternalKey**](UsersApi.html#getusersexternalidauthoritynameexternalkey) | **GET** /api/v2/users/externalid/{authorityName}/{externalKey} | Get the user associated with external identifier. |
| [**GetUsersMe**](UsersApi.html#getusersme) | **GET** /api/v2/users/me | Get current user details. |
| [**GetUsersSearch**](UsersApi.html#getuserssearch) | **GET** /api/v2/users/search | Search users using the q64 value returned from a previous search |
| [**PatchUser**](UsersApi.html#patchuser) | **PATCH** /api/v2/users/{userId} | Update user |
| [**PatchUserCallforwarding**](UsersApi.html#patchusercallforwarding) | **PATCH** /api/v2/users/{userId}/callforwarding | Patch a user&#39;s CallForwarding |
| [**PatchUserGeolocation**](UsersApi.html#patchusergeolocation) | **PATCH** /api/v2/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
| [**PatchUserQueue**](UsersApi.html#patchuserqueue) | **PATCH** /api/v2/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**PatchUserQueues**](UsersApi.html#patchuserqueues) | **PATCH** /api/v2/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**PatchUserRoutinglanguage**](UsersApi.html#patchuserroutinglanguage) | **PATCH** /api/v2/users/{userId}/routinglanguages/{languageId} | Update routing language proficiency or state. |
| [**PatchUserRoutinglanguagesBulk**](UsersApi.html#patchuserroutinglanguagesbulk) | **PATCH** /api/v2/users/{userId}/routinglanguages/bulk | Add bulk routing language to user. Max limit 50 languages |
| [**PatchUserRoutingskillsBulk**](UsersApi.html#patchuserroutingskillsbulk) | **PATCH** /api/v2/users/{userId}/routingskills/bulk | Bulk add routing skills to user |
| [**PatchUsersBulk**](UsersApi.html#patchusersbulk) | **PATCH** /api/v2/users/bulk | Update bulk acd autoanswer on users |
| [**PostAnalyticsUsersAggregatesQuery**](UsersApi.html#postanalyticsusersaggregatesquery) | **POST** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostAnalyticsUsersDetailsQuery**](UsersApi.html#postanalyticsusersdetailsquery) | **POST** /api/v2/analytics/users/details/query | Query for user details |
| [**PostAnalyticsUsersObservationsQuery**](UsersApi.html#postanalyticsusersobservationsquery) | **POST** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PostAuthorizationSubjectDivisionRole**](UsersApi.html#postauthorizationsubjectdivisionrole) | **POST** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Make a grant of a role in a division |
| [**PostUserExternalid**](UsersApi.html#postuserexternalid) | **POST** /api/v2/users/{userId}/externalid | Create mapping between external identifier and user. Limit 100 per entity. |
| [**PostUserInvite**](UsersApi.html#postuserinvite) | **POST** /api/v2/users/{userId}/invite | Send an activation email to the user |
| [**PostUserPassword**](UsersApi.html#postuserpassword) | **POST** /api/v2/users/{userId}/password | Change a users password |
| [**PostUserRoutinglanguages**](UsersApi.html#postuserroutinglanguages) | **POST** /api/v2/users/{userId}/routinglanguages | Add routing language to user |
| [**PostUserRoutingskills**](UsersApi.html#postuserroutingskills) | **POST** /api/v2/users/{userId}/routingskills | Add routing skill to user |
| [**PostUsers**](UsersApi.html#postusers) | **POST** /api/v2/users | Create user |
| [**PostUsersMePassword**](UsersApi.html#postusersmepassword) | **POST** /api/v2/users/me/password | Change your password |
| [**PostUsersSearch**](UsersApi.html#postuserssearch) | **POST** /api/v2/users/search | Search users |
| [**PutUserCallforwarding**](UsersApi.html#putusercallforwarding) | **PUT** /api/v2/users/{userId}/callforwarding | Update a user&#39;s CallForwarding |
| [**PutUserOutofoffice**](UsersApi.html#putuseroutofoffice) | **PUT** /api/v2/users/{userId}/outofoffice | Update an OutOfOffice |
| [**PutUserProfileskills**](UsersApi.html#putuserprofileskills) | **PUT** /api/v2/users/{userId}/profileskills | Update profile skills for a user |
| [**PutUserRoles**](UsersApi.html#putuserroles) | **PUT** /api/v2/users/{userId}/roles | Sets the user&#39;s roles |
| [**PutUserRoutingskill**](UsersApi.html#putuserroutingskill) | **PUT** /api/v2/users/{userId}/routingskills/{skillId} | Update routing skill proficiency or state. |
| [**PutUserRoutingskillsBulk**](UsersApi.html#putuserroutingskillsbulk) | **PUT** /api/v2/users/{userId}/routingskills/bulk | Replace all routing skills assigned to a user |
| [**PutUserRoutingstatus**](UsersApi.html#putuserroutingstatus) | **PUT** /api/v2/users/{userId}/routingstatus | Update the routing status of a user |
| [**PutUserStationAssociatedstationStationId**](UsersApi.html#putuserstationassociatedstationstationid) | **PUT** /api/v2/users/{userId}/station/associatedstation/{stationId} | Set associated station |
| [**PutUserStationDefaultstationStationId**](UsersApi.html#putuserstationdefaultstationstationid) | **PUT** /api/v2/users/{userId}/station/defaultstation/{stationId} | Set default station |
{: class="table table-striped"}

<a name="deleteauthorizationsubjectdivisionrole"></a>

## void DeleteAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId)



Delete a grant of a role in a division



Requires ANY permissions: 

* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAuthorizationSubjectDivisionRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var divisionId = divisionId_example;  // string | the id of the division of the grant
            var roleId = roleId_example;  // string | the id of the role of the grant

            try
            { 
                // Delete a grant of a role in a division
                apiInstance.DeleteAuthorizationSubjectDivisionRole(subjectId, divisionId, roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteAuthorizationSubjectDivisionRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **divisionId** | **string**| the id of the division of the grant |  |
| **roleId** | **string**| the id of the role of the grant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuser"></a>

## [**Empty**](Empty.html) DeleteUser (string userId)



Delete user



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
    public class DeleteUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete user
                Empty result = apiInstance.DeleteUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deleteuserexternalidauthoritynameexternalkey"></a>

## void DeleteUserExternalidAuthorityNameExternalKey (string userId, string authorityName, string externalKey)



Delete the external identifier for user.



Requires ANY permissions: 

* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserExternalidAuthorityNameExternalKeyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var authorityName = authorityName_example;  // string | Authority Name
            var externalKey = externalKey_example;  // string | External Key

            try
            { 
                // Delete the external identifier for user.
                apiInstance.DeleteUserExternalidAuthorityNameExternalKey(userId, authorityName, externalKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserExternalidAuthorityNameExternalKey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **authorityName** | **string**| Authority Name |  |
| **externalKey** | **string**| External Key |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserroles"></a>

## void DeleteUserRoles (string userId)



Removes all the roles from the user.



Requires ANY permissions: 

* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Removes all the roles from the user.
                apiInstance.DeleteUserRoles(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserroutinglanguage"></a>

## void DeleteUserRoutinglanguage (string userId, string languageId)



Remove routing language from user



Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRoutinglanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var languageId = languageId_example;  // string | languageId

            try
            { 
                // Remove routing language from user
                apiInstance.DeleteUserRoutinglanguage(userId, languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **languageId** | **string**| languageId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserroutingskill"></a>

## void DeleteUserRoutingskill (string userId, string skillId)



Remove routing skill from user



Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRoutingskillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | skillId

            try
            { 
                // Remove routing skill from user
                apiInstance.DeleteUserRoutingskill(userId, skillId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserRoutingskill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserstationassociatedstation"></a>

## void DeleteUserStationAssociatedstation (string userId)



Clear associated station



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserStationAssociatedstationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Clear associated station
                apiInstance.DeleteUserStationAssociatedstation(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserStationAssociatedstation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserstationdefaultstation"></a>

## void DeleteUserStationDefaultstation (string userId)



Clear default station



Requires ANY permissions: 

* telephony:plugin:all
* telephony:phone:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserStationDefaultstationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Clear default station
                apiInstance.DeleteUserStationDefaultstation(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserStationDefaultstation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getauthorizationdivisionspermittedme"></a>

## [**List&lt;AuthzDivision&gt;**](AuthzDivision.html) GetAuthorizationDivisionspermittedMe (string permission, string name = null)



Returns whether or not current user can perform the specified action(s).



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionspermittedMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var name = name_example;  // string | Search term to filter by division name (optional) 

            try
            { 
                // Returns whether or not current user can perform the specified action(s).
                List&lt;AuthzDivision&gt; result = apiInstance.GetAuthorizationDivisionspermittedMe(permission, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationDivisionspermittedMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **name** | **string**| Search term to filter by division name | [optional]  |
{: class="table table-striped"}

### Return type

[**List<AuthzDivision>**](AuthzDivision.html)

<a name="getauthorizationdivisionspermittedsubjectid"></a>

## [**List&lt;AuthzDivision&gt;**](AuthzDivision.html) GetAuthorizationDivisionspermittedSubjectId (string subjectId, string permission, string name = null)



Returns whether or not specified user can perform the specified action(s).



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionspermittedSubjectIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var name = name_example;  // string | Search term to filter by division name (optional) 

            try
            { 
                // Returns whether or not specified user can perform the specified action(s).
                List&lt;AuthzDivision&gt; result = apiInstance.GetAuthorizationDivisionspermittedSubjectId(subjectId, permission, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationDivisionspermittedSubjectId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **name** | **string**| Search term to filter by division name | [optional]  |
{: class="table table-striped"}

### Return type

[**List<AuthzDivision>**](AuthzDivision.html)

<a name="getauthorizationsubject"></a>

## [**AuthzSubject**](AuthzSubject.html) GetAuthorizationSubject (string subjectId)



Returns a listing of roles and permissions for a user.



Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationSubjectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)

            try
            { 
                // Returns a listing of roles and permissions for a user.
                AuthzSubject result = apiInstance.GetAuthorizationSubject(subjectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationSubject: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
{: class="table table-striped"}

### Return type

[**AuthzSubject**](AuthzSubject.html)

<a name="getauthorizationsubjectsme"></a>

## [**AuthzSubject**](AuthzSubject.html) GetAuthorizationSubjectsMe ()



Returns a listing of roles and permissions for the currently authenticated user.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationSubjectsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            { 
                // Returns a listing of roles and permissions for the currently authenticated user.
                AuthzSubject result = apiInstance.GetAuthorizationSubjectsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationSubjectsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**AuthzSubject**](AuthzSubject.html)

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)



Fetch field config for an entity type



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFieldconfigExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var type = type_example;  // string | Field type

            try
            { 
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type | <br />**Values**: person, group, org, externalContact |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getprofilesusers"></a>

## [**UserProfileEntityListing**](UserProfileEntityListing.html) GetProfilesUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jid = null, string sortOrder = null, List<string> expand = null)



Get a user profile listing



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetProfilesUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jid = new List<string>(); // List<string> | jid (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get a user profile listing
                UserProfileEntityListing result = apiInstance.GetProfilesUsers(pageSize, pageNumber, id, jid, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetProfilesUsers: " + e.Message );
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **jid** | [**List<string>**](string.html)| jid | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization |
{: class="table table-striped"}

### Return type

[**UserProfileEntityListing**](UserProfileEntityListing.html)

<a name="getuser"></a>

## [**User**](User.html) GetUser (string userId, List<string> expand = null, string state = null)



Get user.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var state = state_example;  // string | Search for a user with this state (optional)  (default to active)

            try
            { 
                // Get user.
                User result = apiInstance.GetUser(userId, expand, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
| **state** | **string**| Search for a user with this state | [optional] [default to active]<br />**Values**: active, deleted |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="getuseradjacents"></a>

## [**Adjacents**](Adjacents.html) GetUserAdjacents (string userId, List<string> expand = null)



Get adjacents



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserAdjacentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get adjacents
                Adjacents result = apiInstance.GetUserAdjacents(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserAdjacents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**Adjacents**](Adjacents.html)

<a name="getusercallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) GetUserCallforwarding (string userId)



Get a user's CallForwarding



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserCallforwardingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get a user's CallForwarding
                CallForwarding result = apiInstance.GetUserCallforwarding(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserCallforwarding: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.html)

<a name="getuserdirectreports"></a>

## [**List&lt;User&gt;**](User.html) GetUserDirectreports (string userId, List<string> expand = null)



Get direct reports



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserDirectreportsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get direct reports
                List&lt;User&gt; result = apiInstance.GetUserDirectreports(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDirectreports: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getuserexternalid"></a>

## [**List&lt;UserExternalIdentifier&gt;**](UserExternalIdentifier.html) GetUserExternalid (string userId)



Get the external identifiers for a user.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserExternalidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get the external identifiers for a user.
                List&lt;UserExternalIdentifier&gt; result = apiInstance.GetUserExternalid(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserExternalid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**List<UserExternalIdentifier>**](UserExternalIdentifier.html)

<a name="getuserexternalidauthorityname"></a>

## [**UserExternalIdentifier**](UserExternalIdentifier.html) GetUserExternalidAuthorityName (string userId, string authorityName)



Get the external identifier of user for an authority.

Authority name and external key are case sensitive.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserExternalidAuthorityNameExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var authorityName = authorityName_example;  // string | Authority Name

            try
            { 
                // Get the external identifier of user for an authority.
                UserExternalIdentifier result = apiInstance.GetUserExternalidAuthorityName(userId, authorityName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserExternalidAuthorityName: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **authorityName** | **string**| Authority Name |  |
{: class="table table-striped"}

### Return type

[**UserExternalIdentifier**](UserExternalIdentifier.html)

<a name="getuserfavorites"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUserFavorites (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)



Get favorites



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserFavoritesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get favorites
                UserEntityListing result = apiInstance.GetUserFavorites(userId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserFavorites: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getusergeolocation"></a>

## [**Geolocation**](Geolocation.html) GetUserGeolocation (string userId, string clientId)



Get a user's Geolocation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserGeolocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id

            try
            { 
                // Get a user's Geolocation
                Geolocation result = apiInstance.GetUserGeolocation(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGeolocation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

<a name="getuseroutofoffice"></a>

## [**OutOfOffice**](OutOfOffice.html) GetUserOutofoffice (string userId)



Get a OutOfOffice



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserOutofofficeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get a OutOfOffice
                OutOfOffice result = apiInstance.GetUserOutofoffice(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserOutofoffice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**OutOfOffice**](OutOfOffice.html)

<a name="getuserprofile"></a>

## [**UserProfile**](UserProfile.html) GetUserProfile (string userId, List<string> expand = null)



Get user profile



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserProfileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | userId
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get user profile
                UserProfile result = apiInstance.GetUserProfile(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**UserProfile**](UserProfile.html)

<a name="getuserprofileskills"></a>

## **List&lt;string&gt;** GetUserProfileskills (string userId)



List profile skills for a user



Requires ANY permissions: 

* directory:userProfile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserProfileskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // List profile skills for a user
                List&lt;string&gt; result = apiInstance.GetUserProfileskills(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfileskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="getuserqueues"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) GetUserQueues (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, List<string> divisionId = null)



Get queues for user



Requires ANY permissions: 

* routing:queue:view
* routing:queue:join

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var joined = true;  // bool? | Is joined to the queue (optional)  (default to true)
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Get queues for user
                UserQueueEntityListing result = apiInstance.GetUserQueues(userId, pageSize, pageNumber, joined, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **joined** | **bool?**| Is joined to the queue | [optional] [default to true] |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="getuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetUserRoles (string userId)



Returns a listing of roles and permissions for a user.



Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="getuserroutinglanguages"></a>

## [**UserLanguageEntityListing**](UserLanguageEntityListing.html) GetUserRoutinglanguages (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)



List routing language for user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserRoutinglanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // List routing language for user
                UserLanguageEntityListing result = apiInstance.GetUserRoutinglanguages(userId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**UserLanguageEntityListing**](UserLanguageEntityListing.html)

<a name="getuserroutingskills"></a>

## [**UserSkillEntityListing**](UserSkillEntityListing.html) GetUserRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)



List routing skills for user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserRoutingskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // List routing skills for user
                UserSkillEntityListing result = apiInstance.GetUserRoutingskills(userId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRoutingskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing.html)

<a name="getuserroutingstatus"></a>

## [**RoutingStatus**](RoutingStatus.html) GetUserRoutingstatus (string userId)



Fetch the routing status of a user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserRoutingstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Fetch the routing status of a user
                RoutingStatus result = apiInstance.GetUserRoutingstatus(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRoutingstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**RoutingStatus**](RoutingStatus.html)

<a name="getuserstation"></a>

## [**UserStations**](UserStations.html) GetUserStation (string userId)



Get station information for user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserStationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get station information for user
                UserStations result = apiInstance.GetUserStation(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserStation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserStations**](UserStations.html)

<a name="getusersuperiors"></a>

## [**List&lt;User&gt;**](User.html) GetUserSuperiors (string userId, List<string> expand = null)



Get superiors



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserSuperiorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get superiors
                List&lt;User&gt; result = apiInstance.GetUserSuperiors(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSuperiors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getusertrustors"></a>

## [**TrustorEntityListing**](TrustorEntityListing.html) GetUserTrustors (string userId, int? pageSize = null, int? pageNumber = null)



List the organizations that have authorized/trusted the user.



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
    public class GetUserTrustorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // List the organizations that have authorized/trusted the user.
                TrustorEntityListing result = apiInstance.GetUserTrustors(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTrustors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrustorEntityListing**](TrustorEntityListing.html)

<a name="getusers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null, List<string> expand = null, string state = null)



Get the list of available users.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | A list of user IDs to fetch by bulk (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var state = state_example;  // string | Only list users of this state (optional)  (default to active)

            try
            { 
                // Get the list of available users.
                UserEntityListing result = apiInstance.GetUsers(pageSize, pageNumber, id, jabberId, sortOrder, expand, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
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
| **id** | [**List<string>**](string.html)| A list of user IDs to fetch by bulk | [optional]  |
| **jabberId** | [**List<string>**](string.html)| A list of jabberIds to fetch by bulk (cannot be used with the \&quot;id\&quot; parameter) | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
| **state** | **string**| Only list users of this state | [optional] [default to active]<br />**Values**: active, inactive, deleted, any |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getusersexternalidauthoritynameexternalkey"></a>

## [**User**](User.html) GetUsersExternalidAuthorityNameExternalKey (string authorityName, string externalKey, List<string> expand = null)



Get the user associated with external identifier.

Authority name and external key are case sensitive.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersExternalidAuthorityNameExternalKeyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var authorityName = authorityName_example;  // string | Authority Name
            var externalKey = externalKey_example;  // string | External Key
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get the user associated with external identifier.
                User result = apiInstance.GetUsersExternalidAuthorityNameExternalKey(authorityName, externalKey, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersExternalidAuthorityNameExternalKey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **authorityName** | **string**| Authority Name |  |
| **externalKey** | **string**| External Key |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="getusersme"></a>

## [**UserMe**](UserMe.html) GetUsersMe (List<string> expand = null)



Get current user details.

This request is not valid when using the Client Credentials OAuth grant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get current user details.
                UserMe result = apiInstance.GetUsersMe(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, authorization.unusedRoles, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, date, geolocationsettings, organization, presencedefinitions, locationdefinitions, orgauthorization, orgproducts, favorites, superiors, directreports, adjacents, routingskills, routinglanguages, fieldconfigs, token, trustors |
{: class="table table-striped"}

### Return type

[**UserMe**](UserMe.html)

<a name="getuserssearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetUsersSearch (string q64, List<string> expand = null)



Search users using the q64 value returned from a previous search



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search users using the q64 value returned from a previous search
                UsersSearchResponse result = apiInstance.GetUsersSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="patchuser"></a>

## [**User**](User.html) PatchUser (string userId, UpdateUser body)



Update user



Requires ANY permissions: 

* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UpdateUser(); // UpdateUser | User

            try
            { 
                // Update user
                User result = apiInstance.PatchUser(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UpdateUser**](UpdateUser.html)| User |  |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="patchusercallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) PatchUserCallforwarding (string userId, CallForwarding body)



Patch a user's CallForwarding



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserCallforwardingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new CallForwarding(); // CallForwarding | Call forwarding

            try
            { 
                // Patch a user's CallForwarding
                CallForwarding result = apiInstance.PatchUserCallforwarding(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserCallforwarding: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.html)| Call forwarding |  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.html)

<a name="patchusergeolocation"></a>

## [**Geolocation**](Geolocation.html) PatchUserGeolocation (string userId, string clientId, Geolocation body)



Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserGeolocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id
            var body = new Geolocation(); // Geolocation | Geolocation

            try
            { 
                // Patch a user's Geolocation
                Geolocation result = apiInstance.PatchUserGeolocation(userId, clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserGeolocation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation.html)| Geolocation |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

<a name="patchuserqueue"></a>

## [**UserQueue**](UserQueue.html) PatchUserQueue (string queueId, string userId, UserQueue body)



Join or unjoin a queue for a user



Requires ANY permissions: 

* routing:queue:join

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var queueId = queueId_example;  // string | Queue ID
            var userId = userId_example;  // string | User ID
            var body = new UserQueue(); // UserQueue | Queue Member

            try
            { 
                // Join or unjoin a queue for a user
                UserQueue result = apiInstance.PatchUserQueue(queueId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **userId** | **string**| User ID |  |
| **body** | [**UserQueue**](UserQueue.html)| Queue Member |  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.html)

<a name="patchuserqueues"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) PatchUserQueues (string userId, List<UserQueue> body, List<string> divisionId = null)



Join or unjoin a set of queues for a user



Requires ANY permissions: 

* routing:queue:join

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserQueue>(); // List<UserQueue> | User Queues
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Join or unjoin a set of queues for a user
                UserQueueEntityListing result = apiInstance.PatchUserQueues(userId, body, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserQueue>**](UserQueue.html)| User Queues |  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="patchuserroutinglanguage"></a>

## [**UserRoutingLanguage**](UserRoutingLanguage.html) PatchUserRoutinglanguage (string userId, string languageId, UserRoutingLanguage body)



Update routing language proficiency or state.



Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutinglanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var languageId = languageId_example;  // string | languageId
            var body = new UserRoutingLanguage(); // UserRoutingLanguage | Language

            try
            { 
                // Update routing language proficiency or state.
                UserRoutingLanguage result = apiInstance.PatchUserRoutinglanguage(userId, languageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **languageId** | **string**| languageId |  |
| **body** | [**UserRoutingLanguage**](UserRoutingLanguage.html)| Language |  |
{: class="table table-striped"}

### Return type

[**UserRoutingLanguage**](UserRoutingLanguage.html)

<a name="patchuserroutinglanguagesbulk"></a>

## [**UserLanguageEntityListing**](UserLanguageEntityListing.html) PatchUserRoutinglanguagesBulk (string userId, List<UserRoutingLanguagePost> body)



Add bulk routing language to user. Max limit 50 languages



Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutinglanguagesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingLanguagePost>(); // List<UserRoutingLanguagePost> | Language

            try
            { 
                // Add bulk routing language to user. Max limit 50 languages
                UserLanguageEntityListing result = apiInstance.PatchUserRoutinglanguagesBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserRoutinglanguagesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingLanguagePost>**](UserRoutingLanguagePost.html)| Language |  |
{: class="table table-striped"}

### Return type

[**UserLanguageEntityListing**](UserLanguageEntityListing.html)

<a name="patchuserroutingskillsbulk"></a>

## [**UserSkillEntityListing**](UserSkillEntityListing.html) PatchUserRoutingskillsBulk (string userId, List<UserRoutingSkillPost> body)



Bulk add routing skills to user



Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutingskillsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingSkillPost>(); // List<UserRoutingSkillPost> | Skill

            try
            { 
                // Bulk add routing skills to user
                UserSkillEntityListing result = apiInstance.PatchUserRoutingskillsBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserRoutingskillsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingSkillPost>**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing.html)

<a name="patchusersbulk"></a>

## [**UserEntityListing**](UserEntityListing.html) PatchUsersBulk (List<PatchUser> body)



Update bulk acd autoanswer on users



Requires ANY permissions: 

* directory:user:add
* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUsersBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new List<PatchUser>(); // List<PatchUser> | Users

            try
            { 
                // Update bulk acd autoanswer on users
                UserEntityListing result = apiInstance.PatchUsersBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUsersBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<PatchUser>**](PatchUser.html)| Users |  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="postanalyticsusersaggregatesquery"></a>

## [**UserAggregateQueryResponse**](UserAggregateQueryResponse.html) PostAnalyticsUsersAggregatesQuery (UserAggregationQuery body)



Query for user aggregates



Requires ANY permissions: 

* analytics:userAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserAggregationQuery(); // UserAggregationQuery | query

            try
            { 
                // Query for user aggregates
                UserAggregateQueryResponse result = apiInstance.PostAnalyticsUsersAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserAggregationQuery**](UserAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**UserAggregateQueryResponse**](UserAggregateQueryResponse.html)

<a name="postanalyticsusersdetailsquery"></a>

## [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html) PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)



Query for user details



Requires ANY permissions: 

* analytics:userObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersDetailsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserDetailsQuery(); // UserDetailsQuery | query

            try
            { 
                // Query for user details
                AnalyticsUserDetailsQueryResponse result = apiInstance.PostAnalyticsUsersDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersDetailsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDetailsQuery**](UserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html)

<a name="postanalyticsusersobservationsquery"></a>

## [**UserObservationQueryResponse**](UserObservationQueryResponse.html) PostAnalyticsUsersObservationsQuery (UserObservationQuery body)



Query for user observations



Requires ANY permissions: 

* analytics:userObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserObservationQuery(); // UserObservationQuery | query

            try
            { 
                // Query for user observations
                UserObservationQueryResponse result = apiInstance.PostAnalyticsUsersObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserObservationQuery**](UserObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**UserObservationQueryResponse**](UserObservationQueryResponse.html)

<a name="postauthorizationsubjectdivisionrole"></a>

## void PostAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId, string subjectType = null)



Make a grant of a role in a division



Requires ANY permissions: 

* authorization:grant:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationSubjectDivisionRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var divisionId = divisionId_example;  // string | the id of the division to which to make the grant
            var roleId = roleId_example;  // string | the id of the role to grant
            var subjectType = subjectType_example;  // string | what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional)  (default to PC_USER)

            try
            { 
                // Make a grant of a role in a division
                apiInstance.PostAuthorizationSubjectDivisionRole(subjectId, divisionId, roleId, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAuthorizationSubjectDivisionRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **divisionId** | **string**| the id of the division to which to make the grant |  |
| **roleId** | **string**| the id of the role to grant |  |
| **subjectType** | **string**| what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) | [optional] [default to PC_USER] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postuserexternalid"></a>

## [**List&lt;UserExternalIdentifier&gt;**](UserExternalIdentifier.html) PostUserExternalid (string userId, UserExternalIdentifier body)



Create mapping between external identifier and user. Limit 100 per entity.

Authority Name and External key are case sensitive.

Requires ANY permissions: 

* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserExternalidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserExternalIdentifier(); // UserExternalIdentifier | 

            try
            { 
                // Create mapping between external identifier and user. Limit 100 per entity.
                List&lt;UserExternalIdentifier&gt; result = apiInstance.PostUserExternalid(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserExternalid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserExternalIdentifier**](UserExternalIdentifier.html)|  |  |
{: class="table table-striped"}

### Return type

[**List<UserExternalIdentifier>**](UserExternalIdentifier.html)

<a name="postuserinvite"></a>

## void PostUserInvite (string userId, bool? force = null)



Send an activation email to the user



Requires ANY permissions: 

* directory:user:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserInviteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var force = true;  // bool? | Resend the invitation even if one is already outstanding (optional)  (default to false)

            try
            { 
                // Send an activation email to the user
                apiInstance.PostUserInvite(userId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **force** | **bool?**| Resend the invitation even if one is already outstanding | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postuserpassword"></a>

## void PostUserPassword (string userId, ChangePasswordRequest body)



Change a users password



Requires ANY permissions: 

* directory:user:setPassword

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserPasswordExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new ChangePasswordRequest(); // ChangePasswordRequest | Password

            try
            { 
                // Change a users password
                apiInstance.PostUserPassword(userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**ChangePasswordRequest**](ChangePasswordRequest.html)| Password |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postuserroutinglanguages"></a>

## [**UserRoutingLanguage**](UserRoutingLanguage.html) PostUserRoutinglanguages (string userId, UserRoutingLanguagePost body)



Add routing language to user



Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserRoutinglanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserRoutingLanguagePost(); // UserRoutingLanguagePost | Language

            try
            { 
                // Add routing language to user
                UserRoutingLanguage result = apiInstance.PostUserRoutinglanguages(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingLanguagePost**](UserRoutingLanguagePost.html)| Language |  |
{: class="table table-striped"}

### Return type

[**UserRoutingLanguage**](UserRoutingLanguage.html)

<a name="postuserroutingskills"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PostUserRoutingskills (string userId, UserRoutingSkillPost body)



Add routing skill to user



Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserRoutingskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserRoutingSkillPost(); // UserRoutingSkillPost | Skill

            try
            { 
                // Add routing skill to user
                UserRoutingSkill result = apiInstance.PostUserRoutingskills(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserRoutingskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingSkillPost**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="postusers"></a>

## [**User**](User.html) PostUsers (CreateUser body)



Create user



Requires ANY permissions: 

* directory:user:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new CreateUser(); // CreateUser | User

            try
            { 
                // Create user
                User result = apiInstance.PostUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateUser**](CreateUser.html)| User |  |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="postusersmepassword"></a>

## void PostUsersMePassword (ChangeMyPasswordRequest body)



Change your password



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersMePasswordExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new ChangeMyPasswordRequest(); // ChangeMyPasswordRequest | Password

            try
            { 
                // Change your password
                apiInstance.PostUsersMePassword(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersMePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChangeMyPasswordRequest**](ChangeMyPasswordRequest.html)| Password |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postuserssearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearch (UserSearchRequest body)



Search users



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users
                UsersSearchResponse result = apiInstance.PostUsersSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="putusercallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) PutUserCallforwarding (string userId, CallForwarding body)



Update a user's CallForwarding



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserCallforwardingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new CallForwarding(); // CallForwarding | Call forwarding

            try
            { 
                // Update a user's CallForwarding
                CallForwarding result = apiInstance.PutUserCallforwarding(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserCallforwarding: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.html)| Call forwarding |  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.html)

<a name="putuseroutofoffice"></a>

## [**OutOfOffice**](OutOfOffice.html) PutUserOutofoffice (string userId, OutOfOffice body)



Update an OutOfOffice



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserOutofofficeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new OutOfOffice(); // OutOfOffice | The updated OutOffOffice

            try
            { 
                // Update an OutOfOffice
                OutOfOffice result = apiInstance.PutUserOutofoffice(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserOutofoffice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**OutOfOffice**](OutOfOffice.html)| The updated OutOffOffice |  |
{: class="table table-striped"}

### Return type

[**OutOfOffice**](OutOfOffice.html)

<a name="putuserprofileskills"></a>

## **List&lt;string&gt;** PutUserProfileskills (string userId, List<string> body)



Update profile skills for a user



Requires ANY permissions: 

* directory:userProfile:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserProfileskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> | Skills

            try
            { 
                // Update profile skills for a user
                List&lt;string&gt; result = apiInstance.PutUserProfileskills(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserProfileskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**| Skills |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserRoles (string userId, List<string> body)



Sets the user's roles



Requires ANY permissions: 

* authorization:grant:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> | List of roles

            try
            { 
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserRoles(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putuserroutingskill"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body)



Update routing skill proficiency or state.



Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRoutingskillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | skillId
            var body = new UserRoutingSkill(); // UserRoutingSkill | Skill

            try
            { 
                // Update routing skill proficiency or state.
                UserRoutingSkill result = apiInstance.PutUserRoutingskill(userId, skillId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserRoutingskill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="putuserroutingskillsbulk"></a>

## [**UserSkillEntityListing**](UserSkillEntityListing.html) PutUserRoutingskillsBulk (string userId, List<UserRoutingSkillPost> body)



Replace all routing skills assigned to a user



Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRoutingskillsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingSkillPost>(); // List<UserRoutingSkillPost> | Skill

            try
            { 
                // Replace all routing skills assigned to a user
                UserSkillEntityListing result = apiInstance.PutUserRoutingskillsBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserRoutingskillsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingSkillPost>**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing.html)

<a name="putuserroutingstatus"></a>

## [**RoutingStatus**](RoutingStatus.html) PutUserRoutingstatus (string userId, RoutingStatus body)



Update the routing status of a user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRoutingstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new RoutingStatus(); // RoutingStatus | Routing Status

            try
            { 
                // Update the routing status of a user
                RoutingStatus result = apiInstance.PutUserRoutingstatus(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserRoutingstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**RoutingStatus**](RoutingStatus.html)| Routing Status |  |
{: class="table table-striped"}

### Return type

[**RoutingStatus**](RoutingStatus.html)

<a name="putuserstationassociatedstationstationid"></a>

## void PutUserStationAssociatedstationStationId (string userId, string stationId)



Set associated station



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserStationAssociatedstationStationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var stationId = stationId_example;  // string | stationId

            try
            { 
                // Set associated station
                apiInstance.PutUserStationAssociatedstationStationId(userId, stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserStationAssociatedstationStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **stationId** | **string**| stationId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putuserstationdefaultstationstationid"></a>

## void PutUserStationDefaultstationStationId (string userId, string stationId)



Set default station



Requires ANY permissions: 

* telephony:plugin:all
* telephony:phone:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserStationDefaultstationStationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var stationId = stationId_example;  // string | stationId

            try
            { 
                // Set default station
                apiInstance.PutUserStationDefaultstationStationId(userId, stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserStationDefaultstationStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **stationId** | **string**| stationId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

