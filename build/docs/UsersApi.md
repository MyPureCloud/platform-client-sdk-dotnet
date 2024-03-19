---
title: UsersApi
---
## PureCloudPlatform.Client.V2.Api.UsersApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsUsersDetailsJob**](UsersApi.html#deleteanalyticsusersdetailsjob) | **Delete** /api/v2/analytics/users/details/jobs/{jobId} | Delete/cancel an async request |
| [**DeleteAuthorizationSubjectDivisionRole**](UsersApi.html#deleteauthorizationsubjectdivisionrole) | **Delete** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Delete a grant of a role in a division |
| [**DeleteRoutingUserUtilization**](UsersApi.html#deleteroutinguserutilization) | **Delete** /api/v2/routing/users/{userId}/utilization | Delete the user&#39;s max utilization settings and revert to the organization-wide default. |
| [**DeleteUser**](UsersApi.html#deleteuser) | **Delete** /api/v2/users/{userId} | Delete user |
| [**DeleteUserRoutinglanguage**](UsersApi.html#deleteuserroutinglanguage) | **Delete** /api/v2/users/{userId}/routinglanguages/{languageId} | Remove routing language from user |
| [**DeleteUserRoutingskill**](UsersApi.html#deleteuserroutingskill) | **Delete** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**DeleteUserStationAssociatedstation**](UsersApi.html#deleteuserstationassociatedstation) | **Delete** /api/v2/users/{userId}/station/associatedstation | Clear associated station |
| [**DeleteUserStationDefaultstation**](UsersApi.html#deleteuserstationdefaultstation) | **Delete** /api/v2/users/{userId}/station/defaultstation | Clear default station |
| [**DeleteUserVerifier**](UsersApi.html#deleteuserverifier) | **Delete** /api/v2/users/{userId}/verifiers/{verifierId} | Delete a verifier |
| [**GetAnalyticsUsersAggregatesJob**](UsersApi.html#getanalyticsusersaggregatesjob) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId} | Get status for async query for user aggregates |
| [**GetAnalyticsUsersAggregatesJobResults**](UsersApi.html#getanalyticsusersaggregatesjobresults) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsUsersDetailsJob**](UsersApi.html#getanalyticsusersdetailsjob) | **Get** /api/v2/analytics/users/details/jobs/{jobId} | Get status for async query for user details |
| [**GetAnalyticsUsersDetailsJobResults**](UsersApi.html#getanalyticsusersdetailsjobresults) | **Get** /api/v2/analytics/users/details/jobs/{jobId}/results | Fetch a page of results for an async query |
| [**GetAnalyticsUsersDetailsJobsAvailability**](UsersApi.html#getanalyticsusersdetailsjobsavailability) | **Get** /api/v2/analytics/users/details/jobs/availability | Lookup the datalake availability date and time |
| [**GetAuthorizationDivisionspermittedMe**](UsersApi.html#getauthorizationdivisionspermittedme) | **Get** /api/v2/authorization/divisionspermitted/me | Returns which divisions the current user has the given permission in. |
| [**GetAuthorizationDivisionspermittedPagedMe**](UsersApi.html#getauthorizationdivisionspermittedpagedme) | **Get** /api/v2/authorization/divisionspermitted/paged/me | Returns which divisions the current user has the given permission in. |
| [**GetAuthorizationDivisionspermittedPagedSubjectId**](UsersApi.html#getauthorizationdivisionspermittedpagedsubjectid) | **Get** /api/v2/authorization/divisionspermitted/paged/{subjectId} | Returns which divisions the specified user has the given permission in. |
| [**GetAuthorizationSubject**](UsersApi.html#getauthorizationsubject) | **Get** /api/v2/authorization/subjects/{subjectId} | Returns a listing of roles and permissions for a user. |
| [**GetAuthorizationSubjectsMe**](UsersApi.html#getauthorizationsubjectsme) | **Get** /api/v2/authorization/subjects/me | Returns a listing of roles and permissions for the currently authenticated user. |
| [**GetFieldconfig**](UsersApi.html#getfieldconfig) | **Get** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetProfilesUsers**](UsersApi.html#getprofilesusers) | **Get** /api/v2/profiles/users | Get a user profile listing |
| [**GetRoutingUserUtilization**](UsersApi.html#getroutinguserutilization) | **Get** /api/v2/routing/users/{userId}/utilization | Get the user&#39;s max utilization settings.  If not configured, the organization-wide default is returned. |
| [**GetUser**](UsersApi.html#getuser) | **Get** /api/v2/users/{userId} | Get user. |
| [**GetUserAdjacents**](UsersApi.html#getuseradjacents) | **Get** /api/v2/users/{userId}/adjacents | Get adjacents |
| [**GetUserCallforwarding**](UsersApi.html#getusercallforwarding) | **Get** /api/v2/users/{userId}/callforwarding | Get a user&#39;s CallForwarding |
| [**GetUserDirectreports**](UsersApi.html#getuserdirectreports) | **Get** /api/v2/users/{userId}/directreports | Get direct reports |
| [**GetUserFavorites**](UsersApi.html#getuserfavorites) | **Get** /api/v2/users/{userId}/favorites | Deprecated; will be revived with new contract |
| [**GetUserGeolocation**](UsersApi.html#getusergeolocation) | **Get** /api/v2/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**GetUserOutofoffice**](UsersApi.html#getuseroutofoffice) | **Get** /api/v2/users/{userId}/outofoffice | Get a OutOfOffice |
| [**GetUserProfile**](UsersApi.html#getuserprofile) | **Get** /api/v2/users/{userId}/profile | Get user profile |
| [**GetUserProfileskills**](UsersApi.html#getuserprofileskills) | **Get** /api/v2/users/{userId}/profileskills | List profile skills for a user |
| [**GetUserQueues**](UsersApi.html#getuserqueues) | **Get** /api/v2/users/{userId}/queues | Get queues for user |
| [**GetUserRoles**](UsersApi.html#getuserroles) | **Get** /api/v2/users/{subjectId}/roles | Returns a listing of roles and permissions for a user. |
| [**GetUserRoutinglanguages**](UsersApi.html#getuserroutinglanguages) | **Get** /api/v2/users/{userId}/routinglanguages | List routing language for user |
| [**GetUserRoutingskills**](UsersApi.html#getuserroutingskills) | **Get** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**GetUserRoutingstatus**](UsersApi.html#getuserroutingstatus) | **Get** /api/v2/users/{userId}/routingstatus | Fetch the routing status of a user |
| [**GetUserSkillgroups**](UsersApi.html#getuserskillgroups) | **Get** /api/v2/users/{userId}/skillgroups | Get skill groups for a user |
| [**GetUserState**](UsersApi.html#getuserstate) | **Get** /api/v2/users/{userId}/state | Get user state information. |
| [**GetUserStation**](UsersApi.html#getuserstation) | **Get** /api/v2/users/{userId}/station | Get station information for user |
| [**GetUserSuperiors**](UsersApi.html#getusersuperiors) | **Get** /api/v2/users/{userId}/superiors | Get superiors |
| [**GetUserTrustors**](UsersApi.html#getusertrustors) | **Get** /api/v2/users/{userId}/trustors | List the organizations that have authorized/trusted the user. |
| [**GetUserVerifiers**](UsersApi.html#getuserverifiers) | **Get** /api/v2/users/{userId}/verifiers | Get a list of verifiers |
| [**GetUsers**](UsersApi.html#getusers) | **Get** /api/v2/users | Get the list of available users. |
| [**GetUsersDevelopmentActivities**](UsersApi.html#getusersdevelopmentactivities) | **Get** /api/v2/users/development/activities | Get list of Development Activities |
| [**GetUsersDevelopmentActivitiesMe**](UsersApi.html#getusersdevelopmentactivitiesme) | **Get** /api/v2/users/development/activities/me | Get list of Development Activities for current user |
| [**GetUsersDevelopmentActivity**](UsersApi.html#getusersdevelopmentactivity) | **Get** /api/v2/users/development/activities/{activityId} | Get a Development Activity |
| [**GetUsersMe**](UsersApi.html#getusersme) | **Get** /api/v2/users/me | Get current user details. |
| [**GetUsersSearch**](UsersApi.html#getuserssearch) | **Get** /api/v2/users/search | Search users using the q64 value returned from a previous search |
| [**PatchUser**](UsersApi.html#patchuser) | **Patch** /api/v2/users/{userId} | Update user |
| [**PatchUserCallforwarding**](UsersApi.html#patchusercallforwarding) | **Patch** /api/v2/users/{userId}/callforwarding | Patch a user&#39;s CallForwarding |
| [**PatchUserGeolocation**](UsersApi.html#patchusergeolocation) | **Patch** /api/v2/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
| [**PatchUserQueue**](UsersApi.html#patchuserqueue) | **Patch** /api/v2/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**PatchUserQueues**](UsersApi.html#patchuserqueues) | **Patch** /api/v2/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**PatchUserRoutinglanguage**](UsersApi.html#patchuserroutinglanguage) | **Patch** /api/v2/users/{userId}/routinglanguages/{languageId} | Update routing language proficiency or state. |
| [**PatchUserRoutinglanguagesBulk**](UsersApi.html#patchuserroutinglanguagesbulk) | **Patch** /api/v2/users/{userId}/routinglanguages/bulk | Add bulk routing language to user. Max limit 50 languages |
| [**PatchUserRoutingskillsBulk**](UsersApi.html#patchuserroutingskillsbulk) | **Patch** /api/v2/users/{userId}/routingskills/bulk | Bulk add routing skills to user |
| [**PatchUsersBulk**](UsersApi.html#patchusersbulk) | **Patch** /api/v2/users/bulk | Update bulk acd autoanswer on users. Max 50 users can be updated at a time. |
| [**PostAnalyticsUsersActivityQuery**](UsersApi.html#postanalyticsusersactivityquery) | **Post** /api/v2/analytics/users/activity/query | Query for user activity observations |
| [**PostAnalyticsUsersAggregatesJobs**](UsersApi.html#postanalyticsusersaggregatesjobs) | **Post** /api/v2/analytics/users/aggregates/jobs | Query for user aggregates asynchronously |
| [**PostAnalyticsUsersAggregatesQuery**](UsersApi.html#postanalyticsusersaggregatesquery) | **Post** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostAnalyticsUsersDetailsJobs**](UsersApi.html#postanalyticsusersdetailsjobs) | **Post** /api/v2/analytics/users/details/jobs | Query for user details asynchronously |
| [**PostAnalyticsUsersDetailsQuery**](UsersApi.html#postanalyticsusersdetailsquery) | **Post** /api/v2/analytics/users/details/query | Query for user details |
| [**PostAnalyticsUsersObservationsQuery**](UsersApi.html#postanalyticsusersobservationsquery) | **Post** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PostAuthorizationSubjectBulkadd**](UsersApi.html#postauthorizationsubjectbulkadd) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkadd | Bulk-grant roles and divisions to a subject. |
| [**PostAuthorizationSubjectBulkremove**](UsersApi.html#postauthorizationsubjectbulkremove) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkremove | Bulk-remove grants from a subject. |
| [**PostAuthorizationSubjectBulkreplace**](UsersApi.html#postauthorizationsubjectbulkreplace) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkreplace | Replace subject&#39;s roles and divisions with the exact list supplied in the request. |
| [**PostAuthorizationSubjectDivisionRole**](UsersApi.html#postauthorizationsubjectdivisionrole) | **Post** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Make a grant of a role in a division |
| [**PostUserExternalid**](UsersApi.html#postuserexternalid) | **Post** /api/v2/users/{userId}/externalid | Create mapping between external identifier and user. Limit 100 per entity. |
| [**PostUserInvite**](UsersApi.html#postuserinvite) | **Post** /api/v2/users/{userId}/invite | Send an activation email to the user |
| [**PostUserPassword**](UsersApi.html#postuserpassword) | **Post** /api/v2/users/{userId}/password | Change a users password |
| [**PostUserRoutinglanguages**](UsersApi.html#postuserroutinglanguages) | **Post** /api/v2/users/{userId}/routinglanguages | Add routing language to user |
| [**PostUserRoutingskills**](UsersApi.html#postuserroutingskills) | **Post** /api/v2/users/{userId}/routingskills | Add routing skill to user |
| [**PostUsers**](UsersApi.html#postusers) | **Post** /api/v2/users | Create user |
| [**PostUsersDevelopmentActivitiesAggregatesQuery**](UsersApi.html#postusersdevelopmentactivitiesaggregatesquery) | **Post** /api/v2/users/development/activities/aggregates/query | Retrieve aggregated development activity data |
| [**PostUsersMePassword**](UsersApi.html#postusersmepassword) | **Post** /api/v2/users/me/password | Change your password |
| [**PostUsersSearch**](UsersApi.html#postuserssearch) | **Post** /api/v2/users/search | Search users |
| [**PostUsersSearchConversationTarget**](UsersApi.html#postuserssearchconversationtarget) | **Post** /api/v2/users/search/conversation/target | Search users as conversation targets |
| [**PostUsersSearchQueuemembersManage**](UsersApi.html#postuserssearchqueuemembersmanage) | **Post** /api/v2/users/search/queuemembers/manage | Search manage queue member |
| [**PostUsersSearchTeamsAssign**](UsersApi.html#postuserssearchteamsassign) | **Post** /api/v2/users/search/teams/assign | Search users assigned to teams |
| [**PutRoutingUserUtilization**](UsersApi.html#putroutinguserutilization) | **Put** /api/v2/routing/users/{userId}/utilization | Update the user&#39;s max utilization settings.  Include only those media types requiring custom configuration. |
| [**PutUserCallforwarding**](UsersApi.html#putusercallforwarding) | **Put** /api/v2/users/{userId}/callforwarding | Update a user&#39;s CallForwarding |
| [**PutUserOutofoffice**](UsersApi.html#putuseroutofoffice) | **Put** /api/v2/users/{userId}/outofoffice | Update an OutOfOffice |
| [**PutUserProfileskills**](UsersApi.html#putuserprofileskills) | **Put** /api/v2/users/{userId}/profileskills | Update profile skills for a user |
| [**PutUserRoles**](UsersApi.html#putuserroles) | **Put** /api/v2/users/{subjectId}/roles | Sets the user&#39;s roles |
| [**PutUserRoutingskill**](UsersApi.html#putuserroutingskill) | **Put** /api/v2/users/{userId}/routingskills/{skillId} | Update routing skill proficiency or state. |
| [**PutUserRoutingskillsBulk**](UsersApi.html#putuserroutingskillsbulk) | **Put** /api/v2/users/{userId}/routingskills/bulk | Replace all routing skills assigned to a user |
| [**PutUserRoutingstatus**](UsersApi.html#putuserroutingstatus) | **Put** /api/v2/users/{userId}/routingstatus | Update the routing status of a user |
| [**PutUserState**](UsersApi.html#putuserstate) | **Put** /api/v2/users/{userId}/state | Update user state information. |
| [**PutUserStationAssociatedstationStationId**](UsersApi.html#putuserstationassociatedstationstationid) | **Put** /api/v2/users/{userId}/station/associatedstation/{stationId} | Set associated station |
| [**PutUserStationDefaultstationStationId**](UsersApi.html#putuserstationdefaultstationstationid) | **Put** /api/v2/users/{userId}/station/defaultstation/{stationId} | Set default station |
| [**PutUserVerifier**](UsersApi.html#putuserverifier) | **Put** /api/v2/users/{userId}/verifiers/{verifierId} | Update a verifier |
{: class="table table-striped"}

<a name="deleteanalyticsusersdetailsjob"></a>

## void DeleteAnalyticsUsersDetailsJob (string jobId)



Delete/cancel an async request

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsUsersDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async request
                apiInstance.DeleteAnalyticsUsersDetailsJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteAnalyticsUsersDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteauthorizationsubjectdivisionrole"></a>

## void DeleteAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId)



Delete a grant of a role in a division

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="deleteroutinguserutilization"></a>

## void DeleteRoutingUserUtilization (string userId)



Delete the user's max utilization settings and revert to the organization-wide default.

Requires ANY permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete the user's max utilization settings and revert to the organization-wide default.
                apiInstance.DeleteRoutingUserUtilization(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteRoutingUserUtilization: " + e.Message );
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

<a name="deleteuser"></a>

## **Object** DeleteUser (string userId)



Delete user

Requires ANY permissions: 

* directory:user:delete
* directory:organization:admin

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete user
                Object result = apiInstance.DeleteUser(userId);
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

**Object**

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="deleteuserverifier"></a>

## void DeleteUserVerifier (string userId, string verifierId)



Delete a verifier

Requires ANY permissions: 

* mfa:verifier:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserVerifierExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var verifierId = verifierId_example;  // string | Verifier ID

            try
            { 
                // Delete a verifier
                apiInstance.DeleteUserVerifier(userId, verifierId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserVerifier: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **verifierId** | **string**| Verifier ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsusersaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsUsersAggregatesJob (string jobId)



Get status for async query for user aggregates

GetAnalyticsUsersAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsUsersAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for user aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsUsersAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAnalyticsUsersAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsusersaggregatesjobresults"></a>

## [**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse.html) GetAnalyticsUsersAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsUsersAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsUsersAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                UserAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsUsersAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAnalyticsUsersAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse.html)

<a name="getanalyticsusersdetailsjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsUsersDetailsJob (string jobId)



Get status for async query for user details

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for user details
                AsyncQueryStatus result = apiInstance.GetAnalyticsUsersDetailsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAnalyticsUsersDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsusersdetailsjobresults"></a>

## [**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse.html) GetAnalyticsUsersDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)



Fetch a page of results for an async query

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | The desired maximum number of results (optional) 

            try
            { 
                // Fetch a page of results for an async query
                AnalyticsUserDetailsAsyncQueryResponse result = apiInstance.GetAnalyticsUsersDetailsJobResults(jobId, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAnalyticsUsersDetailsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| The desired maximum number of results | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse.html)

<a name="getanalyticsusersdetailsjobsavailability"></a>

## [**DataAvailabilityResponse**](DataAvailabilityResponse.html) GetAnalyticsUsersDetailsJobsAvailability ()



Lookup the datalake availability date and time

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobsAvailabilityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();

            try
            { 
                // Lookup the datalake availability date and time
                DataAvailabilityResponse result = apiInstance.GetAnalyticsUsersDetailsJobsAvailability();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAnalyticsUsersDetailsJobsAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataAvailabilityResponse**](DataAvailabilityResponse.html)

<a name="getauthorizationdivisionspermittedme"></a>

## [**List&lt;AuthzDivision&gt;**](AuthzDivision.html) GetAuthorizationDivisionspermittedMe (string permission, string name = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Returns which divisions the current user has the given permission in.

This route is deprecated, use authorization/divisionspermitted/paged/me instead.

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var name = name_example;  // string | Search term to filter by division name (optional) 

            try
            { 
                // Returns which divisions the current user has the given permission in.
                List<AuthzDivision> result = apiInstance.GetAuthorizationDivisionspermittedMe(permission, name);
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

<a name="getauthorizationdivisionspermittedpagedme"></a>

## [**DivsPermittedEntityListing**](DivsPermittedEntityListing.html) GetAuthorizationDivisionspermittedPagedMe (string permission, int? pageNumber = null, int? pageSize = null)



Returns which divisions the current user has the given permission in.

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
    public class GetAuthorizationDivisionspermittedPagedMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Returns which divisions the current user has the given permission in.
                DivsPermittedEntityListing result = apiInstance.GetAuthorizationDivisionspermittedPagedMe(permission, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationDivisionspermittedPagedMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DivsPermittedEntityListing**](DivsPermittedEntityListing.html)

<a name="getauthorizationdivisionspermittedpagedsubjectid"></a>

## [**DivsPermittedEntityListing**](DivsPermittedEntityListing.html) GetAuthorizationDivisionspermittedPagedSubjectId (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Returns which divisions the specified user has the given permission in.

This route is deprecated, use authorization/divisionspermitted/paged/me instead.

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
    public class GetAuthorizationDivisionspermittedPagedSubjectIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Returns which divisions the specified user has the given permission in.
                DivsPermittedEntityListing result = apiInstance.GetAuthorizationDivisionspermittedPagedSubjectId(subjectId, permission, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAuthorizationDivisionspermittedPagedSubjectId: " + e.Message );
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
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DivsPermittedEntityListing**](DivsPermittedEntityListing.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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


### Return type

[**AuthzSubject**](AuthzSubject.html)

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

## [**UserProfileEntityListing**](UserProfileEntityListing.html) GetProfilesUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jid = null, string sortOrder = null, List<string> expand = null, string integrationPresenceSource = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a user profile listing

This api is deprecated. User /api/v2/users

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jid = new List<string>(); // List<string> | jid (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". (optional) 

            try
            { 
                // Get a user profile listing
                UserProfileEntityListing result = apiInstance.GetProfilesUsers(pageSize, pageNumber, id, jid, sortOrder, expand, integrationPresenceSource);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization |
| **integrationPresenceSource** | **string**| Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \&quot;expand\&quot;. | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
{: class="table table-striped"}

### Return type

[**UserProfileEntityListing**](UserProfileEntityListing.html)

<a name="getroutinguserutilization"></a>

## [**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse.html) GetRoutingUserUtilization (string userId)



Get the user's max utilization settings.  If not configured, the organization-wide default is returned.

Requires ANY permissions: 

* routing:utilization:manage
* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get the user's max utilization settings.  If not configured, the organization-wide default is returned.
                AgentMaxUtilizationResponse result = apiInstance.GetRoutingUserUtilization(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRoutingUserUtilization: " + e.Message );
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

[**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse.html)

<a name="getuser"></a>

## [**User**](User.html) GetUser (string userId, List<string> expand = null, string integrationPresenceSource = null, string state = null)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | Gets an integration presence for a user instead of their default. (optional) 
            var state = state_example;  // string | Search for a user with this state (optional)  (default to active)

            try
            { 
                // Get user.
                User result = apiInstance.GetUser(userId, expand, integrationPresenceSource, state);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
| **integrationPresenceSource** | **string**| Gets an integration presence for a user instead of their default. | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get direct reports
                List<User> result = apiInstance.GetUserDirectreports(userId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getuserfavorites"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUserFavorites (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated; will be revived with new contract

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Deprecated; will be revived with new contract
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
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

## [**UserProfile**](UserProfile.html) GetUserProfile (string userId, List<string> expand = null, string integrationPresenceSource = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get user profile

This api has been deprecated. Use api/v2/users instead

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | userId
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | Gets an integration presence for a user instead of their default. (optional) 

            try
            { 
                // Get user profile
                UserProfile result = apiInstance.GetUserProfile(userId, expand, integrationPresenceSource);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks |
| **integrationPresenceSource** | **string**| Gets an integration presence for a user instead of their default. | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // List profile skills for a user
                List<string> result = apiInstance.GetUserProfileskills(userId);
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
* routing:queueMember:manage

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

## [**UserAuthorization**](UserAuthorization.html) GetUserRoles (string subjectId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | User ID

            try
            { 
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserRoles(subjectId);
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
| **subjectId** | **string**| User ID |  |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="getuserskillgroups"></a>

## [**UserSkillGroupEntityListing**](UserSkillGroupEntityListing.html) GetUserSkillgroups (string userId, int? pageSize = null, string after = null, string before = null)



Get skill groups for a user

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserSkillgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var after = after_example;  // string | The cursor that points to the next page (optional) 
            var before = before_example;  // string | The cursor that points to the previous page (optional) 

            try
            { 
                // Get skill groups for a user
                UserSkillGroupEntityListing result = apiInstance.GetUserSkillgroups(userId, pageSize, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSkillgroups: " + e.Message );
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
| **after** | **string**| The cursor that points to the next page | [optional]  |
| **before** | **string**| The cursor that points to the previous page | [optional]  |
{: class="table table-striped"}

### Return type

[**UserSkillGroupEntityListing**](UserSkillGroupEntityListing.html)

<a name="getuserstate"></a>

## [**UserState**](UserState.html) GetUserState (string userId)



Get user state information.

Requires ANY permissions: 

* directory:userStateChange:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserStateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get user state information.
                UserState result = apiInstance.GetUserState(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserState: " + e.Message );
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

[**UserState**](UserState.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get superiors
                List<User> result = apiInstance.GetUserSuperiors(userId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getusertrustors"></a>

## [**TrustorEntityListing**](TrustorEntityListing.html) GetUserTrustors (string userId, int? pageSize = null, int? pageNumber = null)



List the organizations that have authorized/trusted the user.

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="getuserverifiers"></a>

## [**VerifierEntityListing**](VerifierEntityListing.html) GetUserVerifiers (string userId)



Get a list of verifiers

Requires ANY permissions: 

* mfa:verifier:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserVerifiersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get a list of verifiers
                VerifierEntityListing result = apiInstance.GetUserVerifiers(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserVerifiers: " + e.Message );
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

[**VerifierEntityListing**](VerifierEntityListing.html)

<a name="getusers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null, List<string> expand = null, string integrationPresenceSource = null, string state = null)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | A list of user IDs to fetch by bulk (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100. (optional) 
            var state = state_example;  // string | Only list users of this state (optional)  (default to active)

            try
            { 
                // Get the list of available users.
                UserEntityListing result = apiInstance.GetUsers(pageSize, pageNumber, id, jabberId, sortOrder, expand, integrationPresenceSource, state);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |
| **integrationPresenceSource** | **string**| Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \&quot;expand\&quot;. When using this parameter the maximum number of users that can be returned is 100. | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
| **state** | **string**| Only list users of this state | [optional] [default to active]<br />**Values**: active, inactive, deleted, any |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getusersdevelopmentactivities"></a>

## [**DevelopmentActivityListing**](DevelopmentActivityListing.html) GetUsersDevelopmentActivities (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, string pass = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)



Get list of Development Activities

Either moduleId or userId is required. Results are filtered based on the applicable permissions.

Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersDevelopmentActivitiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = new List<string>(); // List<string> | Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional) 
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. (optional) 
            var interval = interval_example;  // string | Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional)  (default to Any)
            var pass = pass_example;  // string | Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") activities are returned. If pass is \"Any\" or if the pass parameter is not supplied, all activities are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var types = new List<string>(); // List<string> | Specifies the activity types. (optional) 
            var statuses = new List<string>(); // List<string> | Specifies the activity statuses to filter by (optional) 
            var relationship = new List<string>(); // List<string> | Specifies how the current user relation should be interpreted, and filters the activities returned to only the activities that have the specified relationship. If a value besides Attendee is specified, it will only return Coaching Appointments. If not specified, no filtering is applied. (optional) 

            try
            { 
                // Get list of Development Activities
                DevelopmentActivityListing result = apiInstance.GetUsersDevelopmentActivities(userId, moduleId, interval, completionInterval, overdue, pass, pageSize, pageNumber, sortOrder, types, statuses, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersDevelopmentActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | [**List<string>**](string.html)| Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. | [optional]  |
| **moduleId** | **string**| Specifies the ID of the learning module. | [optional]  |
| **interval** | **string**| Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pass** | **string**| Specifies if only the failed (pass is \&quot;False\&quot;) or passed (pass is \&quot;True\&quot;) activities are returned. If pass is \&quot;Any\&quot; or if the pass parameter is not supplied, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **types** | [**List<string>**](string.html)| Specifies the activity types. | [optional] <br />**Values**: Informational, Coaching, AssessedContent, Assessment |
| **statuses** | [**List<string>**](string.html)| Specifies the activity statuses to filter by | [optional] <br />**Values**: Planned, InProgress, Completed, InvalidSchedule |
| **relationship** | [**List<string>**](string.html)| Specifies how the current user relation should be interpreted, and filters the activities returned to only the activities that have the specified relationship. If a value besides Attendee is specified, it will only return Coaching Appointments. If not specified, no filtering is applied. | [optional] <br />**Values**: Creator, Facilitator, Attendee |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityListing**](DevelopmentActivityListing.html)

<a name="getusersdevelopmentactivitiesme"></a>

## [**DevelopmentActivityListing**](DevelopmentActivityListing.html) GetUsersDevelopmentActivitiesMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, string pass = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)



Get list of Development Activities for current user

Results are filtered based on the applicable permissions.

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
    public class GetUsersDevelopmentActivitiesMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. (optional) 
            var interval = interval_example;  // string | Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional)  (default to Any)
            var pass = pass_example;  // string | Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") activities are returned. If pass is \"Any\" or if the pass parameter is not supplied, all activities are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var types = new List<string>(); // List<string> | Specifies the activity types. (optional) 
            var statuses = new List<string>(); // List<string> | Specifies the activity statuses to filter by (optional) 
            var relationship = new List<string>(); // List<string> | Specifies how the current user relation should be interpreted, and filters the activities returned to only the activities that have the specified relationship. If a value besides Attendee is specified, it will only return Coaching Appointments. If not specified, no filtering is applied. (optional) 

            try
            { 
                // Get list of Development Activities for current user
                DevelopmentActivityListing result = apiInstance.GetUsersDevelopmentActivitiesMe(moduleId, interval, completionInterval, overdue, pass, pageSize, pageNumber, sortOrder, types, statuses, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersDevelopmentActivitiesMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| Specifies the ID of the learning module. | [optional]  |
| **interval** | **string**| Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pass** | **string**| Specifies if only the failed (pass is \&quot;False\&quot;) or passed (pass is \&quot;True\&quot;) activities are returned. If pass is \&quot;Any\&quot; or if the pass parameter is not supplied, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **types** | [**List<string>**](string.html)| Specifies the activity types. | [optional] <br />**Values**: Informational, Coaching, AssessedContent, Assessment |
| **statuses** | [**List<string>**](string.html)| Specifies the activity statuses to filter by | [optional] <br />**Values**: Planned, InProgress, Completed, InvalidSchedule |
| **relationship** | [**List<string>**](string.html)| Specifies how the current user relation should be interpreted, and filters the activities returned to only the activities that have the specified relationship. If a value besides Attendee is specified, it will only return Coaching Appointments. If not specified, no filtering is applied. | [optional] <br />**Values**: Creator, Facilitator, Attendee |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityListing**](DevelopmentActivityListing.html)

<a name="getusersdevelopmentactivity"></a>

## [**DevelopmentActivity**](DevelopmentActivity.html) GetUsersDevelopmentActivity (string activityId, string type)



Get a Development Activity

Permission not required if you are the attendee, creator or facilitator of the coaching appointment or you are the assigned user of the learning assignment.

Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersDevelopmentActivityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var activityId = activityId_example;  // string | Specifies the activity ID, maps to either assignment or appointment ID
            var type = type_example;  // string | Specifies the activity type.

            try
            { 
                // Get a Development Activity
                DevelopmentActivity result = apiInstance.GetUsersDevelopmentActivity(activityId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersDevelopmentActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **activityId** | **string**| Specifies the activity ID, maps to either assignment or appointment ID |  |
| **type** | **string**| Specifies the activity type. | <br />**Values**: Informational, Coaching, AssessedContent, Assessment, External |
{: class="table table-striped"}

### Return type

[**DevelopmentActivity**](DevelopmentActivity.html)

<a name="getusersme"></a>

## [**UserMe**](UserMe.html) GetUsersMe (List<string> expand = null, string integrationPresenceSource = null)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | Get your presence for a given integration. This parameter will only be used when presence is provided as an \"expand\". (optional) 

            try
            { 
                // Get current user details.
                UserMe result = apiInstance.GetUsersMe(expand, integrationPresenceSource);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin, date, geolocationsettings, organization, presencedefinitions, divisionedpresencedefinitions, locationdefinitions, orgauthorization, orgproducts, favorites, superiors, directreports, adjacents, routingskills, routinglanguages, fieldconfigs, token, trustors, logCapture |
| **integrationPresenceSource** | **string**| Get your presence for a given integration. This parameter will only be used when presence is provided as an \&quot;expand\&quot;. | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
{: class="table table-striped"}

### Return type

[**UserMe**](UserMe.html)

<a name="getuserssearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetUsersSearch (string q64, List<string> expand = null, string integrationPresenceSource = null)



Search users using the q64 value returned from a previous search

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
    public class GetUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 
            var integrationPresenceSource = integrationPresenceSource_example;  // string | integrationPresenceSource (optional) 

            try
            { 
                // Search users using the q64 value returned from a previous search
                UsersSearchResponse result = apiInstance.GetUsersSearch(q64, expand, integrationPresenceSource);
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
| **integrationPresenceSource** | **string**| integrationPresenceSource | [optional] <br />**Values**: MicrosoftTeams, ZoomPhone, EightByEight |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="patchuser"></a>

## [**User**](User.html) PatchUser (string userId, UpdateUser body)



Update user

Requires ANY permissions: 

* directory:user:edit
* directory:organization:admin

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

Requires ANY permissions: 

* conversation:callForwarding:edit

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
* routing:queueMember:manage

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
* routing:queueMember:manage

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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



Update bulk acd autoanswer on users. Max 50 users can be updated at a time.

Requires ANY permissions: 

* directory:user:edit
* directory:organization:admin

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new List<PatchUser>(); // List<PatchUser> | Users

            try
            { 
                // Update bulk acd autoanswer on users. Max 50 users can be updated at a time.
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

<a name="postanalyticsusersactivityquery"></a>

## [**UserActivityResponse**](UserActivityResponse.html) PostAnalyticsUsersActivityQuery (UserActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for user activity observations

PostAnalyticsUsersActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostAnalyticsUsersActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new UserActivityQuery(); // UserActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for user activity observations
                UserActivityResponse result = apiInstance.PostAnalyticsUsersActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserActivityQuery**](UserActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**UserActivityResponse**](UserActivityResponse.html)

<a name="postanalyticsusersaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsUsersAggregatesJobs (UserAsyncAggregationQuery body)



Query for user aggregates asynchronously

PostAnalyticsUsersAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostAnalyticsUsersAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new UserAsyncAggregationQuery(); // UserAsyncAggregationQuery | query

            try
            { 
                // Query for user aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsUsersAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserAsyncAggregationQuery**](UserAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postanalyticsusersdetailsjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsUsersDetailsJobs (AsyncUserDetailsQuery body)



Query for user details asynchronously

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersDetailsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new AsyncUserDetailsQuery(); // AsyncUserDetailsQuery | query

            try
            { 
                // Query for user details asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsUsersDetailsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAnalyticsUsersDetailsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AsyncUserDetailsQuery**](AsyncUserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsusersdetailsquery"></a>

## [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html) PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)



Query for user details

Requires ANY permissions: 

* analytics:userDetail:view

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postauthorizationsubjectbulkadd"></a>

## void PostAuthorizationSubjectBulkadd (string subjectId, RoleDivisionGrants body, string subjectType = null)



Bulk-grant roles and divisions to a subject.

Requires ALL permissions: 

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
    public class PostAuthorizationSubjectBulkaddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs
            var subjectType = subjectType_example;  // string | what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional)  (default to "PC_USER")

            try
            { 
                // Bulk-grant roles and divisions to a subject.
                apiInstance.PostAuthorizationSubjectBulkadd(subjectId, body, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAuthorizationSubjectBulkadd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
| **subjectType** | **string**| what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectbulkremove"></a>

## void PostAuthorizationSubjectBulkremove (string subjectId, RoleDivisionGrants body)



Bulk-remove grants from a subject.

Requires ALL permissions: 

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
    public class PostAuthorizationSubjectBulkremoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs

            try
            { 
                // Bulk-remove grants from a subject.
                apiInstance.PostAuthorizationSubjectBulkremove(subjectId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAuthorizationSubjectBulkremove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectbulkreplace"></a>

## void PostAuthorizationSubjectBulkreplace (string subjectId, RoleDivisionGrants body, string subjectType = null)



Replace subject's roles and divisions with the exact list supplied in the request.

This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.

Requires ALL permissions: 

* authorization:grant:add
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
    public class PostAuthorizationSubjectBulkreplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs
            var subjectType = subjectType_example;  // string | what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional)  (default to "PC_USER")

            try
            { 
                // Replace subject's roles and divisions with the exact list supplied in the request.
                apiInstance.PostAuthorizationSubjectBulkreplace(subjectId, body, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostAuthorizationSubjectBulkreplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
| **subjectType** | **string**| what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectdivisionrole"></a>

## void PostAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId, string subjectType = null)



Make a grant of a role in a division

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var divisionId = divisionId_example;  // string | the id of the division to which to make the grant
            var roleId = roleId_example;  // string | the id of the role to grant
            var subjectType = subjectType_example;  // string | what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional)  (default to "PC_USER")

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
| **subjectType** | **string**| what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) | [optional] [default to "PC_USER"] |
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserExternalIdentifier(); // UserExternalIdentifier | 

            try
            { 
                // Create mapping between external identifier and user. Limit 100 per entity.
                List<UserExternalIdentifier> result = apiInstance.PostUserExternalid(userId, body);
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

* directory:organization:admin
* directory:userPassword:edit

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

If user creation is successful but the provided password is invalid or configuration fails, POST api/v2/users/{userId}/password can be used to re-attempt password configuration.

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postusersdevelopmentactivitiesaggregatesquery"></a>

## [**DevelopmentActivityAggregateResponse**](DevelopmentActivityAggregateResponse.html) PostUsersDevelopmentActivitiesAggregatesQuery (DevelopmentActivityAggregateParam body)



Retrieve aggregated development activity data

Results are filtered based on the applicable permissions.

Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersDevelopmentActivitiesAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new DevelopmentActivityAggregateParam(); // DevelopmentActivityAggregateParam | Aggregate Request

            try
            { 
                // Retrieve aggregated development activity data
                DevelopmentActivityAggregateResponse result = apiInstance.PostUsersDevelopmentActivitiesAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersDevelopmentActivitiesAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DevelopmentActivityAggregateParam**](DevelopmentActivityAggregateParam.html)| Aggregate Request |  |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityAggregateResponse**](DevelopmentActivityAggregateResponse.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
    public class PostUsersSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postuserssearchconversationtarget"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchConversationTarget (UserSearchRequest body)



Search users as conversation targets

PostUsersSearchConversationTarget is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:target

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchConversationTargetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users as conversation targets
                UsersSearchResponse result = apiInstance.PostUsersSearchConversationTarget(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersSearchConversationTarget: " + e.Message );
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

<a name="postuserssearchqueuemembersmanage"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchQueuemembersManage (UserSearchRequest body)



Search manage queue member

PostUsersSearchQueuemembersManage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* routing:queueMember:manage
* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchQueuemembersManageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search manage queue member
                UsersSearchResponse result = apiInstance.PostUsersSearchQueuemembersManage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersSearchQueuemembersManage: " + e.Message );
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

<a name="postuserssearchteamsassign"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostUsersSearchTeamsAssign (UserSearchRequest body)



Search users assigned to teams

Requires ANY permissions: 

* groups:team:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersSearchTeamsAssignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            { 
                // Search users assigned to teams
                UsersSearchResponse result = apiInstance.PostUsersSearchTeamsAssign(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersSearchTeamsAssign: " + e.Message );
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

<a name="putroutinguserutilization"></a>

## [**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse.html) PutRoutingUserUtilization (string userId, UtilizationRequest body)



Update the user's max utilization settings.  Include only those media types requiring custom configuration.

Requires ANY permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UtilizationRequest(); // UtilizationRequest | utilization

            try
            { 
                // Update the user's max utilization settings.  Include only those media types requiring custom configuration.
                AgentMaxUtilizationResponse result = apiInstance.PutRoutingUserUtilization(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutRoutingUserUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UtilizationRequest**](UtilizationRequest.html)| utilization |  |
{: class="table table-striped"}

### Return type

[**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse.html)

<a name="putusercallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) PutUserCallforwarding (string userId, CallForwarding body)



Update a user's CallForwarding

Requires ANY permissions: 

* conversation:callForwarding:edit

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<string>(); // List<string> | Skills

            try
            { 
                // Update profile skills for a user
                List<string> result = apiInstance.PutUserProfileskills(userId, body);
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
| **body** | [**List<string>**](string.html)| Skills |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserRoles (string subjectId, List<string> body)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var subjectId = subjectId_example;  // string | User ID
            var body = new List<string>(); // List<string> | List of roles

            try
            { 
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserRoles(subjectId, body);
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
| **subjectId** | **string**| User ID |  |
| **body** | [**List<string>**](string.html)| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putuserroutingskill"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body)



Update routing skill proficiency or state.

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="putuserstate"></a>

## [**UserState**](UserState.html) PutUserState (string userId, UserState body)



Update user state information.

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
    public class PutUserStateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserState(); // UserState | User

            try
            { 
                // Update user state information.
                UserState result = apiInstance.PutUserState(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserState: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserState**](UserState.html)| User |  |
{: class="table table-striped"}

### Return type

[**UserState**](UserState.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="putuserverifier"></a>

## [**Verifier**](Verifier.html) PutUserVerifier (string userId, string verifierId, UpdateVerifierRequest body)



Update a verifier

Requires ANY permissions: 

* mfa:verifier:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserVerifierExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var verifierId = verifierId_example;  // string | Verifier ID
            var body = new UpdateVerifierRequest(); // UpdateVerifierRequest | Verifier Update

            try
            { 
                // Update a verifier
                Verifier result = apiInstance.PutUserVerifier(userId, verifierId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserVerifier: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **verifierId** | **string**| Verifier ID |  |
| **body** | [**UpdateVerifierRequest**](UpdateVerifierRequest.html)| Verifier Update |  |
{: class="table table-striped"}

### Return type

[**Verifier**](Verifier.html)

