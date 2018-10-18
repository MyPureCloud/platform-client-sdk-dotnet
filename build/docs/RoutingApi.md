---
title: RoutingApi
---
## PureCloudPlatform.Client.V2.Api.RoutingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteRoutingEmailDomain**](RoutingApi.html#deleteroutingemaildomain) | **DELETE** /api/v2/routing/email/domains/{domainId} | Delete a domain |
| [**DeleteRoutingEmailDomainRoute**](RoutingApi.html#deleteroutingemaildomainroute) | **DELETE** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Delete a route |
| [**DeleteRoutingQueue**](RoutingApi.html#deleteroutingqueue) | **DELETE** /api/v2/routing/queues/{queueId} | Delete a queue |
| [**DeleteRoutingQueueUser**](RoutingApi.html#deleteroutingqueueuser) | **DELETE** /api/v2/routing/queues/{queueId}/users/{memberId} | Delete queue member |
| [**DeleteRoutingQueueWrapupcode**](RoutingApi.html#deleteroutingqueuewrapupcode) | **DELETE** /api/v2/routing/queues/{queueId}/wrapupcodes/{codeId} | Delete a wrap-up code from a queue |
| [**DeleteRoutingSkill**](RoutingApi.html#deleteroutingskill) | **DELETE** /api/v2/routing/skills/{skillId} | Delete Routing Skill |
| [**DeleteRoutingSmsPhonenumber**](RoutingApi.html#deleteroutingsmsphonenumber) | **DELETE** /api/v2/routing/sms/phonenumbers/{addressId} | Delete a phone number provisioned for SMS. |
| [**DeleteRoutingUtilization**](RoutingApi.html#deleteroutingutilization) | **DELETE** /api/v2/routing/utilization | Delete utilization settings and revert to system defaults. |
| [**DeleteRoutingWrapupcode**](RoutingApi.html#deleteroutingwrapupcode) | **DELETE** /api/v2/routing/wrapupcodes/{codeId} | Delete wrap-up code |
| [**DeleteUserRoutinglanguage**](RoutingApi.html#deleteuserroutinglanguage) | **DELETE** /api/v2/users/{userId}/routinglanguages/{languageId} | Remove routing language from user |
| [**DeleteUserRoutingskill**](RoutingApi.html#deleteuserroutingskill) | **DELETE** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**GetRoutingEmailDomain**](RoutingApi.html#getroutingemaildomain) | **GET** /api/v2/routing/email/domains/{domainId} | Get domain |
| [**GetRoutingEmailDomainRoute**](RoutingApi.html#getroutingemaildomainroute) | **GET** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Get a route |
| [**GetRoutingEmailDomainRoutes**](RoutingApi.html#getroutingemaildomainroutes) | **GET** /api/v2/routing/email/domains/{domainName}/routes | Get routes |
| [**GetRoutingEmailDomains**](RoutingApi.html#getroutingemaildomains) | **GET** /api/v2/routing/email/domains | Get domains |
| [**GetRoutingEmailSetup**](RoutingApi.html#getroutingemailsetup) | **GET** /api/v2/routing/email/setup | Get email setup |
| [**GetRoutingLanguages**](RoutingApi.html#getroutinglanguages) | **GET** /api/v2/routing/languages | Get the list of supported languages. |
| [**GetRoutingMessageRecipient**](RoutingApi.html#getroutingmessagerecipient) | **GET** /api/v2/routing/message/recipients/{recipientId} | Get a recipient |
| [**GetRoutingMessageRecipients**](RoutingApi.html#getroutingmessagerecipients) | **GET** /api/v2/routing/message/recipients | Get recipients |
| [**GetRoutingQueue**](RoutingApi.html#getroutingqueue) | **GET** /api/v2/routing/queues/{queueId} | Get details about this queue. |
| [**GetRoutingQueueEstimatedwaittime**](RoutingApi.html#getroutingqueueestimatedwaittime) | **GET** /api/v2/routing/queues/{queueId}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueMediatypeEstimatedwaittime**](RoutingApi.html#getroutingqueuemediatypeestimatedwaittime) | **GET** /api/v2/routing/queues/{queueId}/mediatypes/{mediaType}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueUsers**](RoutingApi.html#getroutingqueueusers) | **GET** /api/v2/routing/queues/{queueId}/users | Get the members of this queue |
| [**GetRoutingQueueWrapupcodes**](RoutingApi.html#getroutingqueuewrapupcodes) | **GET** /api/v2/routing/queues/{queueId}/wrapupcodes | Get the wrap-up codes for a queue |
| [**GetRoutingQueues**](RoutingApi.html#getroutingqueues) | **GET** /api/v2/routing/queues | Get list of queues. |
| [**GetRoutingQueuesDivisionviews**](RoutingApi.html#getroutingqueuesdivisionviews) | **GET** /api/v2/routing/queues/divisionviews | Get a page of simplified queue objects, filterable by name, queue ID(s), or division ID(s). |
| [**GetRoutingQueuesMe**](RoutingApi.html#getroutingqueuesme) | **GET** /api/v2/routing/queues/me | Get a paged listing of queues the user is a member of. |
| [**GetRoutingSkill**](RoutingApi.html#getroutingskill) | **GET** /api/v2/routing/skills/{skillId} | Get Routing Skill |
| [**GetRoutingSkills**](RoutingApi.html#getroutingskills) | **GET** /api/v2/routing/skills | Get the list of routing skills. |
| [**GetRoutingSmsAvailablephonenumbers**](RoutingApi.html#getroutingsmsavailablephonenumbers) | **GET** /api/v2/routing/sms/availablephonenumbers | Get a list of available phone numbers for SMS provisioning. |
| [**GetRoutingSmsPhonenumber**](RoutingApi.html#getroutingsmsphonenumber) | **GET** /api/v2/routing/sms/phonenumbers/{addressId} | Get a phone number provisioned for SMS. |
| [**GetRoutingSmsPhonenumbers**](RoutingApi.html#getroutingsmsphonenumbers) | **GET** /api/v2/routing/sms/phonenumbers | Get a list of provisioned phone numbers. |
| [**GetRoutingUtilization**](RoutingApi.html#getroutingutilization) | **GET** /api/v2/routing/utilization | Get the utilization settings. |
| [**GetRoutingWrapupcode**](RoutingApi.html#getroutingwrapupcode) | **GET** /api/v2/routing/wrapupcodes/{codeId} | Get details about this wrap-up code. |
| [**GetRoutingWrapupcodes**](RoutingApi.html#getroutingwrapupcodes) | **GET** /api/v2/routing/wrapupcodes | Get list of wrapup codes. |
| [**GetUserRoutinglanguages**](RoutingApi.html#getuserroutinglanguages) | **GET** /api/v2/users/{userId}/routinglanguages | List routing language for user |
| [**GetUserRoutingskills**](RoutingApi.html#getuserroutingskills) | **GET** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**PatchRoutingQueueUser**](RoutingApi.html#patchroutingqueueuser) | **PATCH** /api/v2/routing/queues/{queueId}/users/{memberId} | Update the ring number of joined status for a User in a Queue |
| [**PatchRoutingQueueUsers**](RoutingApi.html#patchroutingqueueusers) | **PATCH** /api/v2/routing/queues/{queueId}/users | Join or unjoin a set of users for a queue |
| [**PatchUserRoutinglanguage**](RoutingApi.html#patchuserroutinglanguage) | **PATCH** /api/v2/users/{userId}/routinglanguages/{languageId} | Update routing language proficiency or state. |
| [**PatchUserRoutinglanguagesBulk**](RoutingApi.html#patchuserroutinglanguagesbulk) | **PATCH** /api/v2/users/{userId}/routinglanguages/bulk | Add bulk routing language to user. Max limit 50 languages |
| [**PatchUserRoutingskillsBulk**](RoutingApi.html#patchuserroutingskillsbulk) | **PATCH** /api/v2/users/{userId}/routingskills/bulk | Add bulk routing skills to user |
| [**PostAnalyticsQueuesObservationsQuery**](RoutingApi.html#postanalyticsqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostRoutingEmailDomainRoutes**](RoutingApi.html#postroutingemaildomainroutes) | **POST** /api/v2/routing/email/domains/{domainName}/routes | Create a route |
| [**PostRoutingEmailDomains**](RoutingApi.html#postroutingemaildomains) | **POST** /api/v2/routing/email/domains | Create a domain |
| [**PostRoutingLanguages**](RoutingApi.html#postroutinglanguages) | **POST** /api/v2/routing/languages | Create Language |
| [**PostRoutingQueueUsers**](RoutingApi.html#postroutingqueueusers) | **POST** /api/v2/routing/queues/{queueId}/users | Bulk add or delete up to 100 queue members |
| [**PostRoutingQueueWrapupcodes**](RoutingApi.html#postroutingqueuewrapupcodes) | **POST** /api/v2/routing/queues/{queueId}/wrapupcodes | Add up to 100 wrap-up codes to a queue |
| [**PostRoutingQueues**](RoutingApi.html#postroutingqueues) | **POST** /api/v2/routing/queues | Create a queue |
| [**PostRoutingSkills**](RoutingApi.html#postroutingskills) | **POST** /api/v2/routing/skills | Create Skill |
| [**PostRoutingSmsAddresses**](RoutingApi.html#postroutingsmsaddresses) | **POST** /api/v2/routing/sms/addresses | Provision an Address for SMS |
| [**PostRoutingSmsPhonenumbers**](RoutingApi.html#postroutingsmsphonenumbers) | **POST** /api/v2/routing/sms/phonenumbers | Provision a phone number for SMS |
| [**PostRoutingWrapupcodes**](RoutingApi.html#postroutingwrapupcodes) | **POST** /api/v2/routing/wrapupcodes | Create a wrap-up code |
| [**PostUserRoutinglanguages**](RoutingApi.html#postuserroutinglanguages) | **POST** /api/v2/users/{userId}/routinglanguages | Add routing language to user |
| [**PostUserRoutingskills**](RoutingApi.html#postuserroutingskills) | **POST** /api/v2/users/{userId}/routingskills | Add routing skill to user |
| [**PutRoutingEmailDomainRoute**](RoutingApi.html#putroutingemaildomainroute) | **PUT** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Update a route |
| [**PutRoutingMessageRecipient**](RoutingApi.html#putroutingmessagerecipient) | **PUT** /api/v2/routing/message/recipients/{recipientId} | Update a recipient |
| [**PutRoutingQueue**](RoutingApi.html#putroutingqueue) | **PUT** /api/v2/routing/queues/{queueId} | Update a queue |
| [**PutRoutingSmsPhonenumber**](RoutingApi.html#putroutingsmsphonenumber) | **PUT** /api/v2/routing/sms/phonenumbers/{addressId} | Update a phone number provisioned for SMS. |
| [**PutRoutingUtilization**](RoutingApi.html#putroutingutilization) | **PUT** /api/v2/routing/utilization | Update the utilization settings. |
| [**PutRoutingWrapupcode**](RoutingApi.html#putroutingwrapupcode) | **PUT** /api/v2/routing/wrapupcodes/{codeId} | Update wrap-up code |
| [**PutUserRoutingskill**](RoutingApi.html#putuserroutingskill) | **PUT** /api/v2/users/{userId}/routingskills/{skillId} | Update routing skill proficiency or state. |
{: class="table table-striped"}

<a name="deleteroutingemaildomain"></a>

## void DeleteRoutingEmailDomain (string domainId)



Delete a domain



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingEmailDomainExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainId = domainId_example;  // string | domain ID
            
            
            

            try
            {
                
                // Delete a domain
                
                apiInstance.DeleteRoutingEmailDomain(domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingemaildomainroute"></a>

## void DeleteRoutingEmailDomainRoute (string domainName, string routeId)



Delete a route



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingEmailDomainRouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainName = domainName_example;  // string | email domain
            
            
            
            
            var routeId = routeId_example;  // string | route ID
            
            
            

            try
            {
                
                // Delete a route
                
                apiInstance.DeleteRoutingEmailDomainRoute(domainName, routeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueue"></a>

## void DeleteRoutingQueue (string queueId, bool? forceDelete = null)



Delete a queue



Requires ANY permissions: 

* routing:queue:delete

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            var forceDelete = true;  // bool? | forceDelete (optional) 
            
            
            

            try
            {
                
                // Delete a queue
                
                apiInstance.DeleteRoutingQueue(queueId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueue: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **forceDelete** | **bool?**| forceDelete | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueueuser"></a>

## void DeleteRoutingQueueUser (string queueId, string memberId)



Delete queue member



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            var memberId = memberId_example;  // string | Member ID
            
            
            

            try
            {
                
                // Delete queue member
                
                apiInstance.DeleteRoutingQueueUser(queueId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueuewrapupcode"></a>

## void DeleteRoutingQueueWrapupcode (string queueId, string codeId)



Delete a wrap-up code from a queue



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueWrapupcodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            var codeId = codeId_example;  // string | Code ID
            
            
            

            try
            {
                
                // Delete a wrap-up code from a queue
                
                apiInstance.DeleteRoutingQueueWrapupcode(queueId, codeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueWrapupcode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingskill"></a>

## void DeleteRoutingSkill (string skillId)



Delete Routing Skill



Requires ANY permissions: 

* routing:skill:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSkillExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var skillId = skillId_example;  // string | Skill ID
            
            
            

            try
            {
                
                // Delete Routing Skill
                
                apiInstance.DeleteRoutingSkill(skillId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSkill: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingsmsphonenumber"></a>

## void DeleteRoutingSmsPhonenumber (string addressId)



Delete a phone number provisioned for SMS.



Requires ANY permissions: 

* sms:phoneNumber:delete

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSmsPhonenumberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var addressId = addressId_example;  // string | Address ID
            
            
            

            try
            {
                
                // Delete a phone number provisioned for SMS.
                
                apiInstance.DeleteRoutingSmsPhonenumber(addressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSmsPhonenumber: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingutilization"></a>

## void DeleteRoutingUtilization ()



Delete utilization settings and revert to system defaults.



Requires ANY permissions: 

* routing:utilization:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            

            try
            {
                
                // Delete utilization settings and revert to system defaults.
                
                apiInstance.DeleteRoutingUtilization();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingwrapupcode"></a>

## void DeleteRoutingWrapupcode (string codeId)



Delete wrap-up code



Requires ANY permissions: 

* routing:wrapupCode:delete

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingWrapupcodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var codeId = codeId_example;  // string | Wrapup Code ID
            
            
            

            try
            {
                
                // Delete wrap-up code
                
                apiInstance.DeleteRoutingWrapupcode(codeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserroutinglanguage"></a>

## void DeleteUserRoutinglanguage (string userId, string languageId)



Remove routing language from user



Requires ANY permissions: 

* routing:skill:assign
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var userId = userId_example;  // string | User ID
            
            
            
            
            var languageId = languageId_example;  // string | languageId
            
            
            

            try
            {
                
                // Remove routing language from user
                
                apiInstance.DeleteUserRoutinglanguage(userId, languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
~~~

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
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var userId = userId_example;  // string | User ID
            
            
            
            
            var skillId = skillId_example;  // string | skillId
            
            
            

            try
            {
                
                // Remove routing skill from user
                
                apiInstance.DeleteUserRoutingskill(userId, skillId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteUserRoutingskill: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getroutingemaildomain"></a>

## [**InboundDomain**](InboundDomain.html) GetRoutingEmailDomain (string domainId)



Get domain



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainId = domainId_example;  // string | domain ID
            
            
            

            try
            {
                
                // Get domain
                
                InboundDomain result = apiInstance.GetRoutingEmailDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.html)

<a name="getroutingemaildomainroute"></a>

## [**InboundRoute**](InboundRoute.html) GetRoutingEmailDomainRoute (string domainName, string routeId)



Get a route



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainRouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainName = domainName_example;  // string | email domain
            
            
            
            
            var routeId = routeId_example;  // string | route ID
            
            
            

            try
            {
                
                // Get a route
                
                InboundRoute result = apiInstance.GetRoutingEmailDomainRoute(domainName, routeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="getroutingemaildomainroutes"></a>

## [**InboundRouteEntityListing**](InboundRouteEntityListing.html) GetRoutingEmailDomainRoutes (string domainName, int? pageSize = null, int? pageNumber = null, string pattern = null)



Get routes



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainRoutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainName = domainName_example;  // string | email domain
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pattern = pattern_example;  // string | Filter routes by the route's pattern property (optional) 
            
            
            

            try
            {
                
                // Get routes
                
                InboundRouteEntityListing result = apiInstance.GetRoutingEmailDomainRoutes(domainName, pageSize, pageNumber, pattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomainRoutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pattern** | **string**| Filter routes by the route&#39;s pattern property | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundRouteEntityListing**](InboundRouteEntityListing.html)

<a name="getroutingemaildomains"></a>

## [**InboundDomainEntityListing**](InboundDomainEntityListing.html) GetRoutingEmailDomains ()



Get domains



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            

            try
            {
                
                // Get domains
                
                InboundDomainEntityListing result = apiInstance.GetRoutingEmailDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomains: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**InboundDomainEntityListing**](InboundDomainEntityListing.html)

<a name="getroutingemailsetup"></a>

## [**EmailSetup**](EmailSetup.html) GetRoutingEmailSetup ()



Get email setup



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailSetupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            

            try
            {
                
                // Get email setup
                
                EmailSetup result = apiInstance.GetRoutingEmailSetup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailSetup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailSetup**](EmailSetup.html)

<a name="getroutinglanguages"></a>

## [**LanguageEntityListing**](LanguageEntityListing.html) GetRoutingLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)



Get the list of supported languages.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingLanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            

            try
            {
                
                // Get the list of supported languages.
                
                LanguageEntityListing result = apiInstance.GetRoutingLanguages(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingLanguages: " + e.Message );
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
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**LanguageEntityListing**](LanguageEntityListing.html)

<a name="getroutingmessagerecipient"></a>

## [**Recipient**](Recipient.html) GetRoutingMessageRecipient (string recipientId)



Get a recipient



Requires ANY permissions: 

* routing:message:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingMessageRecipientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var recipientId = recipientId_example;  // string | Recipient ID
            
            
            

            try
            {
                
                // Get a recipient
                
                Recipient result = apiInstance.GetRoutingMessageRecipient(recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingMessageRecipient: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recipientId** | **string**| Recipient ID |  |
{: class="table table-striped"}

### Return type

[**Recipient**](Recipient.html)

<a name="getroutingmessagerecipients"></a>

## [**RecipientListing**](RecipientListing.html) GetRoutingMessageRecipients (string messengerType = null, int? pageSize = null, int? pageNumber = null)



Get recipients



Requires ANY permissions: 

* routing:message:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingMessageRecipientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var messengerType = messengerType_example;  // string | Messenger Type (optional) 
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // Get recipients
                
                RecipientListing result = apiInstance.GetRoutingMessageRecipients(messengerType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingMessageRecipients: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type | [optional] <br />**Values**: sms, facebook, twitter, line, whatsapp, telegram, kakao |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**RecipientListing**](RecipientListing.html)

<a name="getroutingqueue"></a>

## [**Queue**](Queue.html) GetRoutingQueue (string queueId)



Get details about this queue.



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            

            try
            {
                
                // Get details about this queue.
                
                Queue result = apiInstance.GetRoutingQueue(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueue: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="getroutingqueueestimatedwaittime"></a>

## [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html) GetRoutingQueueEstimatedwaittime (string queueId, string conversationId = null)



Get Estimated Wait Time



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueEstimatedwaittimeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | queueId
            
            
            
            
            var conversationId = conversationId_example;  // string | conversationId (optional) 
            
            
            

            try
            {
                
                // Get Estimated Wait Time
                
                EstimatedWaitTimePredictions result = apiInstance.GetRoutingQueueEstimatedwaittime(queueId, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueEstimatedwaittime: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **conversationId** | **string**| conversationId | [optional]  |
{: class="table table-striped"}

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html)

<a name="getroutingqueuemediatypeestimatedwaittime"></a>

## [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html) GetRoutingQueueMediatypeEstimatedwaittime (string queueId, string mediaType)



Get Estimated Wait Time



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueMediatypeEstimatedwaittimeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | queueId
            
            
            
            
            var mediaType = mediaType_example;  // string | mediaType
            
            
            

            try
            {
                
                // Get Estimated Wait Time
                
                EstimatedWaitTimePredictions result = apiInstance.GetRoutingQueueMediatypeEstimatedwaittime(queueId, mediaType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueMediatypeEstimatedwaittime: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **mediaType** | **string**| mediaType |  |
{: class="table table-striped"}

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html)

<a name="getroutingqueueusers"></a>

## [**QueueMemberEntityListing**](QueueMemberEntityListing.html) GetRoutingQueueUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, bool? joined = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null)



Get the members of this queue



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            
            
            
            var joined = true;  // bool? | Filter by joined status (optional) 
            
            
            
            
            var name = name_example;  // string | Filter by queue member name (optional) 
            
            
            
            
            
            var profileSkills = new List<string>(); // List<string> | Filter by profile skill (optional) 
            
            
            
            
            var skills = new List<string>(); // List<string> | Filter by skill (optional) 
            
            
            
            
            var languages = new List<string>(); // List<string> | Filter by language (optional) 
            
            
            
            
            var routingStatus = new List<string>(); // List<string> | Filter by routing status (optional) 
            
            
            
            
            var presence = new List<string>(); // List<string> | Filter by presence (optional) 
            
            

            try
            {
                
                // Get the members of this queue
                
                QueueMemberEntityListing result = apiInstance.GetRoutingQueueUsers(queueId, pageSize, pageNumber, sortBy, expand, joined, name, profileSkills, skills, languages, routingStatus, presence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, profileSkills, locations, groups, skills, languages |
| **joined** | **bool?**| Filter by joined status | [optional]  |
| **name** | **string**| Filter by queue member name | [optional]  |
| **profileSkills** | [**List<string>**](string.html)| Filter by profile skill | [optional]  |
| **skills** | [**List<string>**](string.html)| Filter by skill | [optional]  |
| **languages** | [**List<string>**](string.html)| Filter by language | [optional]  |
| **routingStatus** | [**List<string>**](string.html)| Filter by routing status | [optional]  |
| **presence** | [**List<string>**](string.html)| Filter by presence | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing.html)

<a name="getroutingqueuewrapupcodes"></a>

## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) GetRoutingQueueWrapupcodes (string queueId)



Get the wrap-up codes for a queue



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            

            try
            {
                
                // Get the wrap-up codes for a queue
                
                WrapupCodeEntityListing result = apiInstance.GetRoutingQueueWrapupcodes(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.html)

<a name="getroutingqueues"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetRoutingQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null, List<string> divisionId = null)



Get list of queues.



Requires ANY permissions: 

* routing:queue:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var active = true;  // bool? | Active (optional) 
            
            
            
            
            
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            
            

            try
            {
                
                // Get list of queues.
                
                QueueEntityListing result = apiInstance.GetRoutingQueues(pageSize, pageNumber, sortBy, name, active, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueues: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
| **active** | **bool?**| Active | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getroutingqueuesdivisionviews"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetRoutingQueuesDivisionviews (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null)



Get a page of simplified queue objects, filterable by name, queue ID(s), or division ID(s).



Requires ANY permissions: 

* routing:queue:search

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesDivisionviewsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            
            var id = new List<string>(); // List<string> | Queue ID(s) (optional) 
            
            
            
            
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            
            

            try
            {
                
                // Get a page of simplified queue objects, filterable by name, queue ID(s), or division ID(s).
                
                QueueEntityListing result = apiInstance.GetRoutingQueuesDivisionviews(pageSize, pageNumber, sortBy, sortOrder, name, id, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesDivisionviews: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc, score |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| Queue ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getroutingqueuesme"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) GetRoutingQueuesMe (bool? joined = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)



Get a paged listing of queues the user is a member of.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var joined = true;  // bool? | Joined (optional) 
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            
            
            

            try
            {
                
                // Get a paged listing of queues the user is a member of.
                
                UserQueueEntityListing result = apiInstance.GetRoutingQueuesMe(joined, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **joined** | **bool?**| Joined | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="getroutingskill"></a>

## [**RoutingSkill**](RoutingSkill.html) GetRoutingSkill (string skillId)



Get Routing Skill



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var skillId = skillId_example;  // string | Skill ID
            
            
            

            try
            {
                
                // Get Routing Skill
                
                RoutingSkill result = apiInstance.GetRoutingSkill(skillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkill: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="getroutingskills"></a>

## [**SkillEntityListing**](SkillEntityListing.html) GetRoutingSkills (int? pageSize = null, int? pageNumber = null, string name = null)



Get the list of routing skills.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var name = name_example;  // string | Filter for results that start with this value (optional) 
            
            
            

            try
            {
                
                // Get the list of routing skills.
                
                SkillEntityListing result = apiInstance.GetRoutingSkills(pageSize, pageNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkills: " + e.Message );
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
| **name** | **string**| Filter for results that start with this value | [optional]  |
{: class="table table-striped"}

### Return type

[**SkillEntityListing**](SkillEntityListing.html)

<a name="getroutingsmsavailablephonenumbers"></a>

## [**SMSAvailablePhoneNumberEntityListing**](SMSAvailablePhoneNumberEntityListing.html) GetRoutingSmsAvailablephonenumbers (string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null)



Get a list of available phone numbers for SMS provisioning.

This request will return up to 30 random phone numbers matching the criteria specified.  To get additional phone numbers repeat the request.

Requires ANY permissions: 

* sms:phoneNumber:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAvailablephonenumbersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var countryCode = countryCode_example;  // string | The ISO 3166-1 alpha-2 country code of the county for which available phone numbers should be returned
            
            
            
            
            var phoneNumberType = phoneNumberType_example;  // string | Type of available phone numbers searched
            
            
            
            
            var region = region_example;  // string | Region/province/state that can be used to restrict the numbers returned (optional) 
            
            
            
            
            var city = city_example;  // string | City that can be used to restrict the numbers returned (optional) 
            
            
            
            
            var areaCode = areaCode_example;  // string | Area code that can be used to restrict the numbers returned (optional) 
            
            
            
            
            var pattern = pattern_example;  // string | A pattern to match phone numbers. Valid characters are '*' and [0-9a-zA-Z]. The '*' character will match any single digit. (optional) 
            
            
            
            
            var addressRequirement = addressRequirement_example;  // string | This indicates whether the phone number requires to have an Address registered. (optional) 
            
            
            

            try
            {
                
                // Get a list of available phone numbers for SMS provisioning.
                
                SMSAvailablePhoneNumberEntityListing result = apiInstance.GetRoutingSmsAvailablephonenumbers(countryCode, phoneNumberType, region, city, areaCode, pattern, addressRequirement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAvailablephonenumbers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **countryCode** | **string**| The ISO 3166-1 alpha-2 country code of the county for which available phone numbers should be returned |  |
| **phoneNumberType** | **string**| Type of available phone numbers searched | <br />**Values**: local, mobile, tollfree |
| **region** | **string**| Region/province/state that can be used to restrict the numbers returned | [optional]  |
| **city** | **string**| City that can be used to restrict the numbers returned | [optional]  |
| **areaCode** | **string**| Area code that can be used to restrict the numbers returned | [optional]  |
| **pattern** | **string**| A pattern to match phone numbers. Valid characters are &#39;*&#39; and [0-9a-zA-Z]. The &#39;*&#39; character will match any single digit. | [optional]  |
| **addressRequirement** | **string**| This indicates whether the phone number requires to have an Address registered. | [optional] <br />**Values**: none, any, local, foreign |
{: class="table table-striped"}

### Return type

[**SMSAvailablePhoneNumberEntityListing**](SMSAvailablePhoneNumberEntityListing.html)

<a name="getroutingsmsphonenumber"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) GetRoutingSmsPhonenumber (string addressId)



Get a phone number provisioned for SMS.



Requires ANY permissions: 

* sms:phoneNumber:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsPhonenumberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var addressId = addressId_example;  // string | Address ID
            
            
            

            try
            {
                
                // Get a phone number provisioned for SMS.
                
                SmsPhoneNumber result = apiInstance.GetRoutingSmsPhonenumber(addressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsPhonenumber: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="getroutingsmsphonenumbers"></a>

## [**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing.html) GetRoutingSmsPhonenumbers (string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null)



Get a list of provisioned phone numbers.



Requires ANY permissions: 

* sms:phoneNumber:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsPhonenumbersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var phoneNumber = phoneNumber_example;  // string | Filter on phone number address. Allowable characters are the digits '0-9' and the wild card character '\\*'. If just digits are present, a contains search is done on the address pattern. For example, '317' could be matched anywhere in the address. An '\\*' will match multiple digits. For example, to match a specific area code within the US a pattern like '1317*' could be used. (optional) 
            
            
            
            
            var phoneNumberType = phoneNumberType_example;  // string | Filter on phone number type (optional) 
            
            
            
            
            var phoneNumberStatus = phoneNumberStatus_example;  // string | Filter on phone number status (optional) 
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // Get a list of provisioned phone numbers.
                
                SmsPhoneNumberEntityListing result = apiInstance.GetRoutingSmsPhonenumbers(phoneNumber, phoneNumberType, phoneNumberStatus, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsPhonenumbers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumber** | **string**| Filter on phone number address. Allowable characters are the digits &#39;0-9&#39; and the wild card character &#39;\\*&#39;. If just digits are present, a contains search is done on the address pattern. For example, &#39;317&#39; could be matched anywhere in the address. An &#39;\\*&#39; will match multiple digits. For example, to match a specific area code within the US a pattern like &#39;1317*&#39; could be used. | [optional]  |
| **phoneNumberType** | **string**| Filter on phone number type | [optional] <br />**Values**: local, mobile, tollfree |
| **phoneNumberStatus** | **string**| Filter on phone number status | [optional] <br />**Values**: active, invalid, porting |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing.html)

<a name="getroutingutilization"></a>

## [**Utilization**](Utilization.html) GetRoutingUtilization ()



Get the utilization settings.



Requires ANY permissions: 

* routing:utilization:manage
* routing:utilization:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            

            try
            {
                
                // Get the utilization settings.
                
                Utilization result = apiInstance.GetRoutingUtilization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.html)

<a name="getroutingwrapupcode"></a>

## [**WrapupCode**](WrapupCode.html) GetRoutingWrapupcode (string codeId)



Get details about this wrap-up code.



Requires ANY permissions: 

* routing:wrapupCode:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var codeId = codeId_example;  // string | Wrapup Code ID
            
            
            

            try
            {
                
                // Get details about this wrap-up code.
                
                WrapupCode result = apiInstance.GetRoutingWrapupcode(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getroutingwrapupcodes"></a>

## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) GetRoutingWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)



Get list of wrapup codes.



Requires ANY permissions: 

* routing:wrapupCode:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            

            try
            {
                
                // Get list of wrapup codes.
                
                WrapupCodeEntityListing result = apiInstance.GetRoutingWrapupcodes(pageSize, pageNumber, sortBy, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcodes: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, id |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.html)

<a name="getuserroutinglanguages"></a>

## [**UserLanguageEntityListing**](UserLanguageEntityListing.html) GetUserRoutinglanguages (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)



List routing language for user



Requires NO permissions: 


### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.GetUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
~~~

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
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.GetUserRoutingskills: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="patchroutingqueueuser"></a>

## [**QueueMember**](QueueMember.html) PatchRoutingQueueUser (string queueId, string memberId, QueueMember body)



Update the ring number of joined status for a User in a Queue



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            var memberId = memberId_example;  // string | Member ID
            
            
            
            
            
            var body = new QueueMember(); // QueueMember | Queue Member
            
            

            try
            {
                
                // Update the ring number of joined status for a User in a Queue
                
                QueueMember result = apiInstance.PatchRoutingQueueUser(queueId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember.html)| Queue Member |  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.html)

<a name="patchroutingqueueusers"></a>

## [**QueueMemberEntityListing**](QueueMemberEntityListing.html) PatchRoutingQueueUsers (string queueId, List<QueueMember> body)



Join or unjoin a set of users for a queue



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members
            
            

            try
            {
                
                // Join or unjoin a set of users for a queue
                
                QueueMemberEntityListing result = apiInstance.PatchRoutingQueueUsers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.html)| Queue Members |  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing.html)

<a name="patchuserroutinglanguage"></a>

## [**UserRoutingLanguage**](UserRoutingLanguage.html) PatchUserRoutinglanguage (string userId, string languageId, UserRoutingLanguage body)



Update routing language proficiency or state.



Requires ANY permissions: 

* routing:skill:assign
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
~~~

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
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutinglanguagesBulk: " + e.Message );
            }
        }
    }
}
~~~

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



Add bulk routing skills to user



Requires ANY permissions: 

* routing:skill:assign
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var userId = userId_example;  // string | User ID
            
            
            
            
            
            var body = new List<UserRoutingSkillPost>(); // List<UserRoutingSkillPost> | Skill
            
            

            try
            {
                
                // Add bulk routing skills to user
                
                UserSkillEntityListing result = apiInstance.PatchUserRoutingskillsBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutingskillsBulk: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingSkillPost>**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing.html)

<a name="postanalyticsqueuesobservationsquery"></a>

## [**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html) PostAnalyticsQueuesObservationsQuery (ObservationQuery body)



Query for queue observations



Requires ANY permissions: 

* analytics:queueObservation:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsQueuesObservationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new ObservationQuery(); // ObservationQuery | query
            
            

            try
            {
                
                // Query for queue observations
                
                QualifierMappingObservationQueryResponse result = apiInstance.PostAnalyticsQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostAnalyticsQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html)

<a name="postroutingemaildomainroutes"></a>

## [**InboundRoute**](InboundRoute.html) PostRoutingEmailDomainRoutes (string domainName, InboundRoute body)



Create a route



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainRoutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainName = domainName_example;  // string | email domain
            
            
            
            
            
            var body = new InboundRoute(); // InboundRoute | Route
            
            

            try
            {
                
                // Create a route
                
                InboundRoute result = apiInstance.PostRoutingEmailDomainRoutes(domainName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomainRoutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **body** | [**InboundRoute**](InboundRoute.html)| Route |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="postroutingemaildomains"></a>

## [**InboundDomain**](InboundDomain.html) PostRoutingEmailDomains (InboundDomain body)



Create a domain



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new InboundDomain(); // InboundDomain | Domain
            
            

            try
            {
                
                // Create a domain
                
                InboundDomain result = apiInstance.PostRoutingEmailDomains(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomains: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InboundDomain**](InboundDomain.html)| Domain |  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.html)

<a name="postroutinglanguages"></a>

## [**Language**](Language.html) PostRoutingLanguages (Language body)



Create Language



Requires ANY permissions: 

* routing:skill:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingLanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new Language(); // Language | Language
            
            

            try
            {
                
                // Create Language
                
                Language result = apiInstance.PostRoutingLanguages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingLanguages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Language**](Language.html)| Language |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

<a name="postroutingqueueusers"></a>

## **string** PostRoutingQueueUsers (string queueId, List<WritableEntity> body, bool? delete = null)



Bulk add or delete up to 100 queue members



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueueUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            
            var body = new List<WritableEntity>(); // List<WritableEntity> | Queue Members
            
            
            
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)
            
            
            

            try
            {
                
                // Bulk add or delete up to 100 queue members
                
                string result = apiInstance.PostRoutingQueueUsers(queueId, body, delete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WritableEntity>**](WritableEntity.html)| Queue Members |  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |
{: class="table table-striped"}

### Return type

**string**

<a name="postroutingqueuewrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) PostRoutingQueueWrapupcodes (string queueId, List<WrapUpCodeReference> body)



Add up to 100 wrap-up codes to a queue



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueueWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            
            var body = new List<WrapUpCodeReference>(); // List<WrapUpCodeReference> | List of wrapup codes
            
            

            try
            {
                
                // Add up to 100 wrap-up codes to a queue
                
                List&lt;WrapupCode&gt; result = apiInstance.PostRoutingQueueWrapupcodes(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WrapUpCodeReference>**](WrapUpCodeReference.html)| List of wrapup codes |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="postroutingqueues"></a>

## [**Queue**](Queue.html) PostRoutingQueues (CreateQueueRequest body)



Create a queue



Requires ANY permissions: 

* routing:queue:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueuesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new CreateQueueRequest(); // CreateQueueRequest | Queue
            
            

            try
            {
                
                // Create a queue
                
                Queue result = apiInstance.PostRoutingQueues(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueues: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateQueueRequest**](CreateQueueRequest.html)| Queue |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="postroutingskills"></a>

## [**RoutingSkill**](RoutingSkill.html) PostRoutingSkills (RoutingSkill body)



Create Skill



Requires ANY permissions: 

* routing:skill:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSkillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new RoutingSkill(); // RoutingSkill | Skill
            
            

            try
            {
                
                // Create Skill
                
                RoutingSkill result = apiInstance.PostRoutingSkills(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSkills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSkill**](RoutingSkill.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="postroutingsmsaddresses"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) PostRoutingSmsAddresses (SmsAddressProvision body)



Provision an Address for SMS



Requires ANY permissions: 

* sms:phoneNumber:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsAddressesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new SmsAddressProvision(); // SmsAddressProvision | SmsAddress
            
            

            try
            {
                
                // Provision an Address for SMS
                
                SmsPhoneNumber result = apiInstance.PostRoutingSmsAddresses(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsAddresses: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsAddressProvision**](SmsAddressProvision.html)| SmsAddress |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="postroutingsmsphonenumbers"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) PostRoutingSmsPhonenumbers (SmsPhoneNumberProvision body)



Provision a phone number for SMS



Requires ANY permissions: 

* sms:phoneNumber:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsPhonenumbersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new SmsPhoneNumberProvision(); // SmsPhoneNumberProvision | SmsPhoneNumber
            
            

            try
            {
                
                // Provision a phone number for SMS
                
                SmsPhoneNumber result = apiInstance.PostRoutingSmsPhonenumbers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsPhonenumbers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsPhoneNumberProvision**](SmsPhoneNumberProvision.html)| SmsPhoneNumber |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="postroutingwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) PostRoutingWrapupcodes (WrapupCode body)



Create a wrap-up code



Requires ANY permissions: 

* routing:wrapupCode:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new WrapupCode(); // WrapupCode | WrapupCode
            
            

            try
            {
                
                // Create a wrap-up code
                
                WrapupCode result = apiInstance.PostRoutingWrapupcodes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapupCode**](WrapupCode.html)| WrapupCode |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="postuserroutinglanguages"></a>

## [**UserRoutingLanguage**](UserRoutingLanguage.html) PostUserRoutinglanguages (string userId, UserRoutingLanguagePost body)



Add routing language to user



Requires ANY permissions: 

* routing:skill:assign
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.PostUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
~~~

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
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.PostUserRoutingskills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingSkillPost**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="putroutingemaildomainroute"></a>

## [**InboundRoute**](InboundRoute.html) PutRoutingEmailDomainRoute (string domainName, string routeId, InboundRoute body)



Update a route



Requires ANY permissions: 

* routing:email:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingEmailDomainRouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var domainName = domainName_example;  // string | email domain
            
            
            
            
            var routeId = routeId_example;  // string | route ID
            
            
            
            
            
            var body = new InboundRoute(); // InboundRoute | Route
            
            

            try
            {
                
                // Update a route
                
                InboundRoute result = apiInstance.PutRoutingEmailDomainRoute(domainName, routeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
| **body** | [**InboundRoute**](InboundRoute.html)| Route |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="putroutingmessagerecipient"></a>

## [**Recipient**](Recipient.html) PutRoutingMessageRecipient (string recipientId, Recipient body)



Update a recipient



Requires ANY permissions: 

* routing:message:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingMessageRecipientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var recipientId = recipientId_example;  // string | Recipient ID
            
            
            
            
            
            var body = new Recipient(); // Recipient | Recipient
            
            

            try
            {
                
                // Update a recipient
                
                Recipient result = apiInstance.PutRoutingMessageRecipient(recipientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingMessageRecipient: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recipientId** | **string**| Recipient ID |  |
| **body** | [**Recipient**](Recipient.html)| Recipient |  |
{: class="table table-striped"}

### Return type

[**Recipient**](Recipient.html)

<a name="putroutingqueue"></a>

## [**Queue**](Queue.html) PutRoutingQueue (string queueId, QueueRequest body)



Update a queue



Requires ANY permissions: 

* routing:queue:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingQueueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var queueId = queueId_example;  // string | Queue ID
            
            
            
            
            
            var body = new QueueRequest(); // QueueRequest | Queue
            
            

            try
            {
                
                // Update a queue
                
                Queue result = apiInstance.PutRoutingQueue(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingQueue: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**QueueRequest**](QueueRequest.html)| Queue |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="putroutingsmsphonenumber"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) PutRoutingSmsPhonenumber (string addressId, SmsPhoneNumber body)



Update a phone number provisioned for SMS.



Requires ANY permissions: 

* sms:phoneNumber:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingSmsPhonenumberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var addressId = addressId_example;  // string | Address ID
            
            
            
            
            
            var body = new SmsPhoneNumber(); // SmsPhoneNumber | SmsPhoneNumber
            
            

            try
            {
                
                // Update a phone number provisioned for SMS.
                
                SmsPhoneNumber result = apiInstance.PutRoutingSmsPhonenumber(addressId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSmsPhonenumber: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
| **body** | [**SmsPhoneNumber**](SmsPhoneNumber.html)| SmsPhoneNumber |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="putroutingutilization"></a>

## [**Utilization**](Utilization.html) PutRoutingUtilization (Utilization body)



Update the utilization settings.



Requires ANY permissions: 

* routing:utilization:manage

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            
            var body = new Utilization(); // Utilization | utilization
            
            

            try
            {
                
                // Update the utilization settings.
                
                Utilization result = apiInstance.PutRoutingUtilization(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Utilization**](Utilization.html)| utilization |  |
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.html)

<a name="putroutingwrapupcode"></a>

## [**WrapupCode**](WrapupCode.html) PutRoutingWrapupcode (string codeId, WrapupCode body)



Update wrap-up code



Requires ANY permissions: 

* routing:wrapupCode:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingWrapupcodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
            var codeId = codeId_example;  // string | Wrapup Code ID
            
            
            
            
            
            var body = new WrapupCode(); // WrapupCode | WrapupCode
            
            

            try
            {
                
                // Update wrap-up code
                
                WrapupCode result = apiInstance.PutRoutingWrapupcode(codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
| **body** | [**WrapupCode**](WrapupCode.html)| WrapupCode |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="putuserroutingskill"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body)



Update routing skill proficiency or state.



Requires ANY permissions: 

* routing:skill:assign
* admin

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new RoutingApi();
            
            
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
                Debug.Print("Exception when calling RoutingApi.PutUserRoutingskill: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

