---
title: RoutingApi
---
## PureCloudPlatform.Client.V2.Api.RoutingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteRoutingAssessment**](RoutingApi.html#deleteroutingassessment) | **DELETE** /api/v2/routing/assessments/{assessmentId} | Delete single benefit assessment. |
| [**DeleteRoutingEmailDomain**](RoutingApi.html#deleteroutingemaildomain) | **DELETE** /api/v2/routing/email/domains/{domainId} | Delete a domain |
| [**DeleteRoutingEmailDomainRoute**](RoutingApi.html#deleteroutingemaildomainroute) | **DELETE** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Delete a route |
| [**DeleteRoutingPredictor**](RoutingApi.html#deleteroutingpredictor) | **DELETE** /api/v2/routing/predictors/{predictorId} | Delete single predictor. |
| [**DeleteRoutingQueue**](RoutingApi.html#deleteroutingqueue) | **DELETE** /api/v2/routing/queues/{queueId} | Delete a queue |
| [**DeleteRoutingQueueMember**](RoutingApi.html#deleteroutingqueuemember) | **DELETE** /api/v2/routing/queues/{queueId}/members/{memberId} | Delete a queue member. |
| [**DeleteRoutingQueueUser**](RoutingApi.html#deleteroutingqueueuser) | **DELETE** /api/v2/routing/queues/{queueId}/users/{memberId} | DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member. |
| [**DeleteRoutingQueueWrapupcode**](RoutingApi.html#deleteroutingqueuewrapupcode) | **DELETE** /api/v2/routing/queues/{queueId}/wrapupcodes/{codeId} | Delete a wrap-up code from a queue |
| [**DeleteRoutingSettings**](RoutingApi.html#deleteroutingsettings) | **DELETE** /api/v2/routing/settings | Delete an organization&#39;s routing settings |
| [**DeleteRoutingSkill**](RoutingApi.html#deleteroutingskill) | **DELETE** /api/v2/routing/skills/{skillId} | Delete Routing Skill |
| [**DeleteRoutingSmsAddress**](RoutingApi.html#deleteroutingsmsaddress) | **DELETE** /api/v2/routing/sms/addresses/{addressId} | Delete an Address by Id for SMS |
| [**DeleteRoutingSmsPhonenumber**](RoutingApi.html#deleteroutingsmsphonenumber) | **DELETE** /api/v2/routing/sms/phonenumbers/{addressId} | Delete a phone number provisioned for SMS. |
| [**DeleteRoutingUserUtilization**](RoutingApi.html#deleteroutinguserutilization) | **DELETE** /api/v2/routing/users/{userId}/utilization | Delete the user&#39;s max utilization settings and revert to the organization-wide default. |
| [**DeleteRoutingUtilization**](RoutingApi.html#deleteroutingutilization) | **DELETE** /api/v2/routing/utilization | Delete the organization-wide max utilization settings and revert to the system default. |
| [**DeleteRoutingWrapupcode**](RoutingApi.html#deleteroutingwrapupcode) | **DELETE** /api/v2/routing/wrapupcodes/{codeId} | Delete wrap-up code |
| [**DeleteUserRoutinglanguage**](RoutingApi.html#deleteuserroutinglanguage) | **DELETE** /api/v2/users/{userId}/routinglanguages/{languageId} | Remove routing language from user |
| [**DeleteUserRoutingskill**](RoutingApi.html#deleteuserroutingskill) | **DELETE** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**GetRoutingAssessment**](RoutingApi.html#getroutingassessment) | **GET** /api/v2/routing/assessments/{assessmentId} | Retrieve a single benefit assessment. |
| [**GetRoutingAssessments**](RoutingApi.html#getroutingassessments) | **GET** /api/v2/routing/assessments | Retrieve all benefit assessments. |
| [**GetRoutingAssessmentsJob**](RoutingApi.html#getroutingassessmentsjob) | **GET** /api/v2/routing/assessments/jobs/{jobId} | Retrieve a single benefit assessments job. |
| [**GetRoutingAssessmentsJobs**](RoutingApi.html#getroutingassessmentsjobs) | **GET** /api/v2/routing/assessments/jobs | Retrieve all benefit assessment jobs. |
| [**GetRoutingEmailDomain**](RoutingApi.html#getroutingemaildomain) | **GET** /api/v2/routing/email/domains/{domainId} | Get domain |
| [**GetRoutingEmailDomainRoute**](RoutingApi.html#getroutingemaildomainroute) | **GET** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Get a route |
| [**GetRoutingEmailDomainRoutes**](RoutingApi.html#getroutingemaildomainroutes) | **GET** /api/v2/routing/email/domains/{domainName}/routes | Get routes |
| [**GetRoutingEmailDomains**](RoutingApi.html#getroutingemaildomains) | **GET** /api/v2/routing/email/domains | Get domains |
| [**GetRoutingEmailSetup**](RoutingApi.html#getroutingemailsetup) | **GET** /api/v2/routing/email/setup | Get email setup |
| [**GetRoutingLanguages**](RoutingApi.html#getroutinglanguages) | **GET** /api/v2/routing/languages | Get the list of supported languages. |
| [**GetRoutingMessageRecipient**](RoutingApi.html#getroutingmessagerecipient) | **GET** /api/v2/routing/message/recipients/{recipientId} | Get a recipient |
| [**GetRoutingMessageRecipients**](RoutingApi.html#getroutingmessagerecipients) | **GET** /api/v2/routing/message/recipients | Get recipients |
| [**GetRoutingPredictor**](RoutingApi.html#getroutingpredictor) | **GET** /api/v2/routing/predictors/{predictorId} | Retrieve a single predictor. |
| [**GetRoutingPredictors**](RoutingApi.html#getroutingpredictors) | **GET** /api/v2/routing/predictors | Retrieve all predictors. |
| [**GetRoutingPredictorsKeyperformanceindicators**](RoutingApi.html#getroutingpredictorskeyperformanceindicators) | **GET** /api/v2/routing/predictors/keyperformanceindicators | Get a list of Key Performance Indicators |
| [**GetRoutingQueue**](RoutingApi.html#getroutingqueue) | **GET** /api/v2/routing/queues/{queueId} | Get details about this queue. |
| [**GetRoutingQueueComparisonperiod**](RoutingApi.html#getroutingqueuecomparisonperiod) | **GET** /api/v2/routing/queues/{queueId}/comparisonperiods/{comparisonPeriodId} | Get a Comparison Period. |
| [**GetRoutingQueueComparisonperiods**](RoutingApi.html#getroutingqueuecomparisonperiods) | **GET** /api/v2/routing/queues/{queueId}/comparisonperiods | Get list of comparison periods |
| [**GetRoutingQueueEstimatedwaittime**](RoutingApi.html#getroutingqueueestimatedwaittime) | **GET** /api/v2/routing/queues/{queueId}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueMediatypeEstimatedwaittime**](RoutingApi.html#getroutingqueuemediatypeestimatedwaittime) | **GET** /api/v2/routing/queues/{queueId}/mediatypes/{mediaType}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueMembers**](RoutingApi.html#getroutingqueuemembers) | **GET** /api/v2/routing/queues/{queueId}/members | Get the members of this queue. |
| [**GetRoutingQueueUsers**](RoutingApi.html#getroutingqueueusers) | **GET** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue. |
| [**GetRoutingQueueWrapupcodes**](RoutingApi.html#getroutingqueuewrapupcodes) | **GET** /api/v2/routing/queues/{queueId}/wrapupcodes | Get the wrap-up codes for a queue |
| [**GetRoutingQueues**](RoutingApi.html#getroutingqueues) | **GET** /api/v2/routing/queues | Get list of queues. |
| [**GetRoutingQueuesDivisionviews**](RoutingApi.html#getroutingqueuesdivisionviews) | **GET** /api/v2/routing/queues/divisionviews | Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s). |
| [**GetRoutingQueuesDivisionviewsAll**](RoutingApi.html#getroutingqueuesdivisionviewsall) | **GET** /api/v2/routing/queues/divisionviews/all | Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization. |
| [**GetRoutingQueuesMe**](RoutingApi.html#getroutingqueuesme) | **GET** /api/v2/routing/queues/me | Get a paged listing of queues the user is a member of. |
| [**GetRoutingSettings**](RoutingApi.html#getroutingsettings) | **GET** /api/v2/routing/settings | Get an organization&#39;s routing settings |
| [**GetRoutingSettingsContactcenter**](RoutingApi.html#getroutingsettingscontactcenter) | **GET** /api/v2/routing/settings/contactcenter | Get Contact Center Settings |
| [**GetRoutingSettingsTranscription**](RoutingApi.html#getroutingsettingstranscription) | **GET** /api/v2/routing/settings/transcription | Get Transcription Settings |
| [**GetRoutingSkill**](RoutingApi.html#getroutingskill) | **GET** /api/v2/routing/skills/{skillId} | Get Routing Skill |
| [**GetRoutingSkills**](RoutingApi.html#getroutingskills) | **GET** /api/v2/routing/skills | Get the list of routing skills. |
| [**GetRoutingSmsAddress**](RoutingApi.html#getroutingsmsaddress) | **GET** /api/v2/routing/sms/addresses/{addressId} | Get an Address by Id for SMS |
| [**GetRoutingSmsAddresses**](RoutingApi.html#getroutingsmsaddresses) | **GET** /api/v2/routing/sms/addresses | Get a list of Addresses for SMS |
| [**GetRoutingSmsAvailablephonenumbers**](RoutingApi.html#getroutingsmsavailablephonenumbers) | **GET** /api/v2/routing/sms/availablephonenumbers | Get a list of available phone numbers for SMS provisioning. |
| [**GetRoutingSmsPhonenumber**](RoutingApi.html#getroutingsmsphonenumber) | **GET** /api/v2/routing/sms/phonenumbers/{addressId} | Get a phone number provisioned for SMS. |
| [**GetRoutingSmsPhonenumbers**](RoutingApi.html#getroutingsmsphonenumbers) | **GET** /api/v2/routing/sms/phonenumbers | Get a list of provisioned phone numbers. |
| [**GetRoutingUserUtilization**](RoutingApi.html#getroutinguserutilization) | **GET** /api/v2/routing/users/{userId}/utilization | Get the user&#39;s max utilization settings.  If not configured, the organization-wide default is returned. |
| [**GetRoutingUtilization**](RoutingApi.html#getroutingutilization) | **GET** /api/v2/routing/utilization | Get the organization-wide max utilization settings. |
| [**GetRoutingWrapupcode**](RoutingApi.html#getroutingwrapupcode) | **GET** /api/v2/routing/wrapupcodes/{codeId} | Get details about this wrap-up code. |
| [**GetRoutingWrapupcodes**](RoutingApi.html#getroutingwrapupcodes) | **GET** /api/v2/routing/wrapupcodes | Get list of wrapup codes. |
| [**GetUserQueues**](RoutingApi.html#getuserqueues) | **GET** /api/v2/users/{userId}/queues | Get queues for user |
| [**GetUserRoutinglanguages**](RoutingApi.html#getuserroutinglanguages) | **GET** /api/v2/users/{userId}/routinglanguages | List routing language for user |
| [**GetUserRoutingskills**](RoutingApi.html#getuserroutingskills) | **GET** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**PatchRoutingConversation**](RoutingApi.html#patchroutingconversation) | **PATCH** /api/v2/routing/conversations/{conversationId} | Update attributes of an in-queue conversation |
| [**PatchRoutingEmailDomain**](RoutingApi.html#patchroutingemaildomain) | **PATCH** /api/v2/routing/email/domains/{domainId} | Update domain settings |
| [**PatchRoutingEmailDomainValidate**](RoutingApi.html#patchroutingemaildomainvalidate) | **PATCH** /api/v2/routing/email/domains/{domainId}/validate | Validate domain settings |
| [**PatchRoutingPredictor**](RoutingApi.html#patchroutingpredictor) | **PATCH** /api/v2/routing/predictors/{predictorId} | Update single predictor. |
| [**PatchRoutingQueueMember**](RoutingApi.html#patchroutingqueuemember) | **PATCH** /api/v2/routing/queues/{queueId}/members/{memberId} | Update the ring number OR joined status for a queue member. |
| [**PatchRoutingQueueMembers**](RoutingApi.html#patchroutingqueuemembers) | **PATCH** /api/v2/routing/queues/{queueId}/members | Join or unjoin a set of users for a queue |
| [**PatchRoutingQueueUser**](RoutingApi.html#patchroutingqueueuser) | **PATCH** /api/v2/routing/queues/{queueId}/users/{memberId} | DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue. |
| [**PatchRoutingQueueUsers**](RoutingApi.html#patchroutingqueueusers) | **PATCH** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue. |
| [**PatchRoutingSettingsContactcenter**](RoutingApi.html#patchroutingsettingscontactcenter) | **PATCH** /api/v2/routing/settings/contactcenter | Update Contact Center Settings |
| [**PatchUserQueue**](RoutingApi.html#patchuserqueue) | **PATCH** /api/v2/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**PatchUserQueues**](RoutingApi.html#patchuserqueues) | **PATCH** /api/v2/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**PatchUserRoutinglanguage**](RoutingApi.html#patchuserroutinglanguage) | **PATCH** /api/v2/users/{userId}/routinglanguages/{languageId} | Update routing language proficiency or state. |
| [**PatchUserRoutinglanguagesBulk**](RoutingApi.html#patchuserroutinglanguagesbulk) | **PATCH** /api/v2/users/{userId}/routinglanguages/bulk | Add bulk routing language to user. Max limit 50 languages |
| [**PatchUserRoutingskillsBulk**](RoutingApi.html#patchuserroutingskillsbulk) | **PATCH** /api/v2/users/{userId}/routingskills/bulk | Bulk add routing skills to user |
| [**PostAnalyticsQueuesObservationsQuery**](RoutingApi.html#postanalyticsqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostRoutingAssessments**](RoutingApi.html#postroutingassessments) | **POST** /api/v2/routing/assessments | Create a benefit assessment. |
| [**PostRoutingAssessmentsJobs**](RoutingApi.html#postroutingassessmentsjobs) | **POST** /api/v2/routing/assessments/jobs | Create a benefit assessment job. |
| [**PostRoutingEmailDomainRoutes**](RoutingApi.html#postroutingemaildomainroutes) | **POST** /api/v2/routing/email/domains/{domainName}/routes | Create a route |
| [**PostRoutingEmailDomainTestconnection**](RoutingApi.html#postroutingemaildomaintestconnection) | **POST** /api/v2/routing/email/domains/{domainId}/testconnection | Tests the custom SMTP server integration connection set on this domain |
| [**PostRoutingEmailDomains**](RoutingApi.html#postroutingemaildomains) | **POST** /api/v2/routing/email/domains | Create a domain |
| [**PostRoutingLanguages**](RoutingApi.html#postroutinglanguages) | **POST** /api/v2/routing/languages | Create Language |
| [**PostRoutingPredictors**](RoutingApi.html#postroutingpredictors) | **POST** /api/v2/routing/predictors | Create a predictor. |
| [**PostRoutingQueueMembers**](RoutingApi.html#postroutingqueuemembers) | **POST** /api/v2/routing/queues/{queueId}/members | Bulk add or delete up to 100 queue members |
| [**PostRoutingQueueUsers**](RoutingApi.html#postroutingqueueusers) | **POST** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members. |
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
| [**PutRoutingSettings**](RoutingApi.html#putroutingsettings) | **PUT** /api/v2/routing/settings | Update an organization&#39;s routing settings |
| [**PutRoutingSettingsTranscription**](RoutingApi.html#putroutingsettingstranscription) | **PUT** /api/v2/routing/settings/transcription | Update Transcription Settings |
| [**PutRoutingSmsPhonenumber**](RoutingApi.html#putroutingsmsphonenumber) | **PUT** /api/v2/routing/sms/phonenumbers/{addressId} | Update a phone number provisioned for SMS. |
| [**PutRoutingUserUtilization**](RoutingApi.html#putroutinguserutilization) | **PUT** /api/v2/routing/users/{userId}/utilization | Update the user&#39;s max utilization settings.  Include only those media types requiring custom configuration. |
| [**PutRoutingUtilization**](RoutingApi.html#putroutingutilization) | **PUT** /api/v2/routing/utilization | Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration. |
| [**PutRoutingWrapupcode**](RoutingApi.html#putroutingwrapupcode) | **PUT** /api/v2/routing/wrapupcodes/{codeId} | Update wrap-up code |
| [**PutUserRoutingskill**](RoutingApi.html#putuserroutingskill) | **PUT** /api/v2/users/{userId}/routingskills/{skillId} | Update routing skill proficiency or state. |
| [**PutUserRoutingskillsBulk**](RoutingApi.html#putuserroutingskillsbulk) | **PUT** /api/v2/users/{userId}/routingskills/bulk | Replace all routing skills assigned to a user |
{: class="table table-striped"}

<a name="deleteroutingassessment"></a>

## void DeleteRoutingAssessment (string assessmentId)



Delete single benefit assessment.



Requires ANY permissions: 

* routing:assessment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingAssessmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var assessmentId = assessmentId_example;  // string | Benefit Assessment ID

            try
            { 
                // Delete single benefit assessment.
                apiInstance.DeleteRoutingAssessment(assessmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assessmentId** | **string**| Benefit Assessment ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingemaildomain"></a>

## void DeleteRoutingEmailDomain (string domainId)



Delete a domain



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingpredictor"></a>

## void DeleteRoutingPredictor (string predictorId)



Delete single predictor.



Requires ALL permissions: 

* routing:predictor:delete
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
    public class DeleteRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID

            try
            { 
                // Delete single predictor.
                apiInstance.DeleteRoutingPredictor(predictorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueue"></a>

## void DeleteRoutingQueue (string queueId, bool? forceDelete = null)



Delete a queue



Requires ALL permissions: 

* routing:queue:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **forceDelete** | **bool?**| forceDelete | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueuemember"></a>

## void DeleteRoutingQueueMember (string queueId, string memberId)



Delete a queue member.



Requires ANY permissions: 

* routing:queue:edit
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
    public class DeleteRoutingQueueMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID

            try
            { 
                // Delete a queue member.
                apiInstance.DeleteRoutingQueueMember(queueId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingqueueuser"></a>

## void DeleteRoutingQueueUser (string queueId, string memberId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member.



Requires ANY permissions: 

* routing:queue:edit
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
    public class DeleteRoutingQueueUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID

            try
            { 
                // DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member.
                apiInstance.DeleteRoutingQueueUser(queueId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueUser: " + e.Message );
            }
        }
    }
}
```

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



Requires ALL permissions: 

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
    public class DeleteRoutingQueueWrapupcodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingsettings"></a>

## void DeleteRoutingSettings ()



Delete an organization's routing settings



Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Delete an organization's routing settings
                apiInstance.DeleteRoutingSettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)

<a name="deleteroutingskill"></a>

## void DeleteRoutingSkill (string skillId)



Delete Routing Skill



Requires ALL permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingsmsaddress"></a>

## void DeleteRoutingSmsAddress (string addressId)



Delete an Address by Id for SMS



Requires ALL permissions: 

* sms:phoneNumber:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSmsAddressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID

            try
            { 
                // Delete an Address by Id for SMS
                apiInstance.DeleteRoutingSmsAddress(addressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSmsAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteroutingsmsphonenumber"></a>

## void DeleteRoutingSmsPhonenumber (string addressId)



Delete a phone number provisioned for SMS.



Requires ALL permissions: 

* sms:phoneNumber:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
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

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete the user's max utilization settings and revert to the organization-wide default.
                apiInstance.DeleteRoutingUserUtilization(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUserUtilization: " + e.Message );
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

<a name="deleteroutingutilization"></a>

## void DeleteRoutingUtilization ()



Delete the organization-wide max utilization settings and revert to the system default.



Requires ALL permissions: 

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
    public class DeleteRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Delete the organization-wide max utilization settings and revert to the system default.
                apiInstance.DeleteRoutingUtilization();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)

<a name="deleteroutingwrapupcode"></a>

## void DeleteRoutingWrapupcode (string codeId)



Delete wrap-up code



Requires ALL permissions: 

* routing:wrapupCode:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getroutingassessment"></a>

## [**BenefitAssessment**](BenefitAssessment.html) GetRoutingAssessment (string assessmentId)



Retrieve a single benefit assessment.



Requires ANY permissions: 

* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var assessmentId = assessmentId_example;  // string | Benefit Assessment ID

            try
            { 
                // Retrieve a single benefit assessment.
                BenefitAssessment result = apiInstance.GetRoutingAssessment(assessmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assessmentId** | **string**| Benefit Assessment ID |  |
{: class="table table-striped"}

### Return type

[**BenefitAssessment**](BenefitAssessment.html)

<a name="getroutingassessments"></a>

## [**AssessmentListing**](AssessmentListing.html) GetRoutingAssessments (string before = null, string after = null, string limit = null, string pageSize = null, List<string> queueId = null)



Retrieve all benefit assessments.



Requires ANY permissions: 

* routing:queue:view
* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var queueId = new List<string>(); // List<string> | Queue ID(s) to filter assessments by. (optional) 

            try
            { 
                // Retrieve all benefit assessments.
                AssessmentListing result = apiInstance.GetRoutingAssessments(before, after, limit, pageSize, queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **queueId** | [**List<string>**](string.html)| Queue ID(s) to filter assessments by. | [optional]  |
{: class="table table-striped"}

### Return type

[**AssessmentListing**](AssessmentListing.html)

<a name="getroutingassessmentsjob"></a>

## [**BenefitAssessmentJob**](BenefitAssessmentJob.html) GetRoutingAssessmentsJob (string jobId)



Retrieve a single benefit assessments job.



Requires ANY permissions: 

* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var jobId = jobId_example;  // string | Benefit Assessment Job ID

            try
            { 
                // Retrieve a single benefit assessments job.
                BenefitAssessmentJob result = apiInstance.GetRoutingAssessmentsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessmentsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Benefit Assessment Job ID |  |
{: class="table table-striped"}

### Return type

[**BenefitAssessmentJob**](BenefitAssessmentJob.html)

<a name="getroutingassessmentsjobs"></a>

## [**AssessmentJobListing**](AssessmentJobListing.html) GetRoutingAssessmentsJobs (List<string> divisionId = null)



Retrieve all benefit assessment jobs.



Requires ANY permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var divisionId = new List<string>(); // List<string> | Division ID(s) to filter assessment jobs by. (optional) 

            try
            { 
                // Retrieve all benefit assessment jobs.
                AssessmentJobListing result = apiInstance.GetRoutingAssessmentsJobs(divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessmentsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | [**List<string>**](string.html)| Division ID(s) to filter assessment jobs by. | [optional]  |
{: class="table table-striped"}

### Return type

[**AssessmentJobListing**](AssessmentJobListing.html)

<a name="getroutingemaildomain"></a>

## [**InboundDomain**](InboundDomain.html) GetRoutingEmailDomain (string domainId)



Get domain



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

## [**InboundDomainEntityListing**](InboundDomainEntityListing.html) GetRoutingEmailDomains (bool? excludeStatus = null)



Get domains



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var excludeStatus = true;  // bool? | Exclude MX record data (optional)  (default to false)

            try
            { 
                // Get domains
                InboundDomainEntityListing result = apiInstance.GetRoutingEmailDomains(excludeStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **excludeStatus** | **bool?**| Exclude MX record data | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**InboundDomainEntityListing**](InboundDomainEntityListing.html)

<a name="getroutingemailsetup"></a>

## [**EmailSetup**](EmailSetup.html) GetRoutingEmailSetup ()



Get email setup



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters
This endpoint does require any parameters.


### Return type

[**EmailSetup**](EmailSetup.html)

<a name="getroutinglanguages"></a>

## [**LanguageEntityListing**](LanguageEntityListing.html) GetRoutingLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, List<string> id = null)



Get the list of supported languages.



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
    public class GetRoutingLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Get the list of supported languages.
                LanguageEntityListing result = apiInstance.GetRoutingLanguages(pageSize, pageNumber, sortOrder, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingLanguages: " + e.Message );
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
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
{: class="table table-striped"}

### Return type

[**LanguageEntityListing**](LanguageEntityListing.html)

<a name="getroutingmessagerecipient"></a>

## [**Recipient**](Recipient.html) GetRoutingMessageRecipient (string recipientId)



Get a recipient



Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type | [optional] <br />**Values**: sms, facebook, twitter, line, whatsapp, open, instagram |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**RecipientListing**](RecipientListing.html)

<a name="getroutingpredictor"></a>

## [**Predictor**](Predictor.html) GetRoutingPredictor (string predictorId)



Retrieve a single predictor.



Requires ANY permissions: 

* routing:predictor:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID

            try
            { 
                // Retrieve a single predictor.
                Predictor result = apiInstance.GetRoutingPredictor(predictorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |
{: class="table table-striped"}

### Return type

[**Predictor**](Predictor.html)

<a name="getroutingpredictors"></a>

## [**PredictorListing**](PredictorListing.html) GetRoutingPredictors (string before = null, string after = null, string limit = null, string pageSize = null, List<string> queueId = null)



Retrieve all predictors.



Requires ANY permissions: 

* routing:predictor:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var queueId = new List<string>(); // List<string> | Comma-separated list of queue Ids to filter by. (optional) 

            try
            { 
                // Retrieve all predictors.
                PredictorListing result = apiInstance.GetRoutingPredictors(before, after, limit, pageSize, queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **queueId** | [**List<string>**](string.html)| Comma-separated list of queue Ids to filter by. | [optional]  |
{: class="table table-striped"}

### Return type

[**PredictorListing**](PredictorListing.html)

<a name="getroutingpredictorskeyperformanceindicators"></a>

## [**List&lt;KeyPerformanceIndicator&gt;**](KeyPerformanceIndicator.html) GetRoutingPredictorsKeyperformanceindicators (string kpiGroup = null)



Get a list of Key Performance Indicators



Requires ANY permissions: 

* routing:keyPerformanceIndicator:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorsKeyperformanceindicatorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var kpiGroup = kpiGroup_example;  // string | The Group of Key Performance Indicators to return (optional) 

            try
            { 
                // Get a list of Key Performance Indicators
                List<KeyPerformanceIndicator> result = apiInstance.GetRoutingPredictorsKeyperformanceindicators(kpiGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictorsKeyperformanceindicators: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **kpiGroup** | **string**| The Group of Key Performance Indicators to return | [optional] <br />**Values**: Standard, Custom |
{: class="table table-striped"}

### Return type

[**List<KeyPerformanceIndicator>**](KeyPerformanceIndicator.html)

<a name="getroutingqueue"></a>

## [**Queue**](Queue.html) GetRoutingQueue (string queueId)



Get details about this queue.



Requires ALL permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="getroutingqueuecomparisonperiod"></a>

## [**ComparisonPeriod**](ComparisonPeriod.html) GetRoutingQueueComparisonperiod (string queueId, string comparisonPeriodId)



Get a Comparison Period.



Requires ALL permissions: 

* routing:comparisonPeriod:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueComparisonperiodExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue id
            var comparisonPeriodId = comparisonPeriodId_example;  // string | ComparisonPeriod id

            try
            { 
                // Get a Comparison Period.
                ComparisonPeriod result = apiInstance.GetRoutingQueueComparisonperiod(queueId, comparisonPeriodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueComparisonperiod: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue id |  |
| **comparisonPeriodId** | **string**| ComparisonPeriod id |  |
{: class="table table-striped"}

### Return type

[**ComparisonPeriod**](ComparisonPeriod.html)

<a name="getroutingqueuecomparisonperiods"></a>

## [**ComparisonPeriodListing**](ComparisonPeriodListing.html) GetRoutingQueueComparisonperiods (string queueId)



Get list of comparison periods



Requires ALL permissions: 

* routing:comparisonPeriod:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueComparisonperiodsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue id

            try
            { 
                // Get list of comparison periods
                ComparisonPeriodListing result = apiInstance.GetRoutingQueueComparisonperiods(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueComparisonperiods: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue id |  |
{: class="table table-striped"}

### Return type

[**ComparisonPeriodListing**](ComparisonPeriodListing.html)

<a name="getroutingqueueestimatedwaittime"></a>

## [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html) GetRoutingQueueEstimatedwaittime (string queueId, string conversationId = null)



Get Estimated Wait Time



Requires ALL permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **mediaType** | **string**| mediaType |  |
{: class="table table-striped"}

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html)

<a name="getroutingqueuemembers"></a>

## [**QueueMemberEntityListing**](QueueMemberEntityListing.html) GetRoutingQueueMembers (string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null, string memberBy = null, bool? joined = null)



Get the members of this queue.



Requires ANY permissions: 

* routing:queue:view
* routing:queue:edit
* routing:queue:readonly
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
    public class GetRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? | Max value is 100 (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var name = name_example;  // string | Filter by queue member name (optional) 
            var profileSkills = new List<string>(); // List<string> | Filter by profile skill (optional) 
            var skills = new List<string>(); // List<string> | Filter by skill (optional) 
            var languages = new List<string>(); // List<string> | Filter by language (optional) 
            var routingStatus = new List<string>(); // List<string> | Filter by routing status (optional) 
            var presence = new List<string>(); // List<string> | Filter by presence (optional) 
            var memberBy = memberBy_example;  // string | Filter by member type (optional) 
            var joined = joined_example;  // bool? | Filter by joined status (optional) 

            try
            { 
                // Get the members of this queue.
                QueueMemberEntityListing result = apiInstance.GetRoutingQueueMembers(queueId, pageNumber, pageSize, sortOrder, expand, name, profileSkills, skills, languages, routingStatus, presence, memberBy, joined);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**| Max value is 100 | [optional] [default to 25] |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, dateLastLogin, authorization.unusedRoles, team, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
| **name** | **string**| Filter by queue member name | [optional]  |
| **profileSkills** | [**List<string>**](string.html)| Filter by profile skill | [optional]  |
| **skills** | [**List<string>**](string.html)| Filter by skill | [optional]  |
| **languages** | [**List<string>**](string.html)| Filter by language | [optional]  |
| **routingStatus** | [**List<string>**](string.html)| Filter by routing status | [optional]  |
| **presence** | [**List<string>**](string.html)| Filter by presence | [optional]  |
| **memberBy** | **string**| Filter by member type | [optional] <br />**Values**: user, group |
| **joined** | **bool?**| Filter by joined status | [optional] <br />**Values**: true, false |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing.html)

<a name="getroutingqueueusers"></a>

## [**QueueMemberEntityListingV1**](QueueMemberEntityListingV1.html) GetRoutingQueueUsers (string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, bool? joined = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue.



Requires ANY permissions: 

* routing:queue:view
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
    public class GetRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? | Max value is 100 (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
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
                // DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue.
                QueueMemberEntityListingV1 result = apiInstance.GetRoutingQueueUsers(queueId, pageNumber, pageSize, sortOrder, expand, joined, name, profileSkills, skills, languages, routingStatus, presence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**| Max value is 100 | [optional] [default to 25] |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, dateLastLogin, authorization.unusedRoles, team, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography |
| **joined** | **bool?**| Filter by joined status | [optional]  |
| **name** | **string**| Filter by queue member name | [optional]  |
| **profileSkills** | [**List<string>**](string.html)| Filter by profile skill | [optional]  |
| **skills** | [**List<string>**](string.html)| Filter by skill | [optional]  |
| **languages** | [**List<string>**](string.html)| Filter by language | [optional]  |
| **routingStatus** | [**List<string>**](string.html)| Filter by routing status | [optional]  |
| **presence** | [**List<string>**](string.html)| Filter by presence | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListingV1**](QueueMemberEntityListingV1.html)

<a name="getroutingqueuewrapupcodes"></a>

## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) GetRoutingQueueWrapupcodes (string queueId, int? pageSize = null, int? pageNumber = null)



Get the wrap-up codes for a queue



Requires ALL permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get the wrap-up codes for a queue
                WrapupCodeEntityListing result = apiInstance.GetRoutingQueueWrapupcodes(queueId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.html)

<a name="getroutingqueues"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetRoutingQueues (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null)



Get list of queues.



Requires ANY permissions: 

* routing:queue:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
            var name = name_example;  // string | Filter by queue name (optional) 
            var id = new List<string>(); // List<string> | Filter by queue ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Filter by queue division ID(s) (optional) 

            try
            { 
                // Get list of queues.
                QueueEntityListing result = apiInstance.GetRoutingQueues(pageNumber, pageSize, sortOrder, name, id, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **name** | **string**| Filter by queue name | [optional]  |
| **id** | [**List<string>**](string.html)| Filter by queue ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Filter by queue division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getroutingqueuesdivisionviews"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetRoutingQueuesDivisionviews (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null)



Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s).



Requires ALL permissions: 

* routing:queue:search

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size [max value is 100] (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number [max value is 5] (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | Queue ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s).
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size [max value is 100] | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number [max value is 5] | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, id, divisionId |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string.html)| Queue ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string.html)| Division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getroutingqueuesdivisionviewsall"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetRoutingQueuesDivisionviewsAll (int? pageSize = null, int? pageNumber = null, string sortOrder = null)



Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization.



Requires ALL permissions: 

* routing:queue:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesDivisionviewsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size [max value is 500] (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            { 
                // Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization.
                QueueEntityListing result = apiInstance.GetRoutingQueuesDivisionviewsAll(pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesDivisionviewsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size [max value is 500] | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getroutingqueuesme"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) GetRoutingQueuesMe (int? pageNumber = null, int? pageSize = null, bool? joined = null, string sortOrder = null)



Get a paged listing of queues the user is a member of.



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
    public class GetRoutingQueuesMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var joined = joined_example;  // bool? | Filter by joined status. (optional) 
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)

            try
            { 
                // Get a paged listing of queues the user is a member of.
                UserQueueEntityListing result = apiInstance.GetRoutingQueuesMe(pageNumber, pageSize, joined, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **joined** | **bool?**| Filter by joined status. | [optional] <br />**Values**: true, false |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="getroutingsettings"></a>

## [**RoutingSettings**](RoutingSettings.html) GetRoutingSettings ()



Get an organization's routing settings



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
    public class GetRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get an organization's routing settings
                RoutingSettings result = apiInstance.GetRoutingSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**RoutingSettings**](RoutingSettings.html)

<a name="getroutingsettingscontactcenter"></a>

## [**ContactCenterSettings**](ContactCenterSettings.html) GetRoutingSettingsContactcenter ()



Get Contact Center Settings



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
    public class GetRoutingSettingsContactcenterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get Contact Center Settings
                ContactCenterSettings result = apiInstance.GetRoutingSettingsContactcenter();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettingsContactcenter: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**ContactCenterSettings**](ContactCenterSettings.html)

<a name="getroutingsettingstranscription"></a>

## [**TranscriptionSettings**](TranscriptionSettings.html) GetRoutingSettingsTranscription ()



Get Transcription Settings



Requires ANY permissions: 

* routing:transcriptionSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSettingsTranscriptionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get Transcription Settings
                TranscriptionSettings result = apiInstance.GetRoutingSettingsTranscription();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettingsTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**TranscriptionSettings**](TranscriptionSettings.html)

<a name="getroutingskill"></a>

## [**RoutingSkill**](RoutingSkill.html) GetRoutingSkill (string skillId)



Get Routing Skill



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
    public class GetRoutingSkillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="getroutingskills"></a>

## [**SkillEntityListing**](SkillEntityListing.html) GetRoutingSkills (int? pageSize = null, int? pageNumber = null, string name = null, List<string> id = null)



Get the list of routing skills.



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
    public class GetRoutingSkillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Filter for results that start with this value (optional) 
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Get the list of routing skills.
                SkillEntityListing result = apiInstance.GetRoutingSkills(pageSize, pageNumber, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkills: " + e.Message );
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
| **name** | **string**| Filter for results that start with this value | [optional]  |
| **id** | [**List<string>**](string.html)| id | [optional]  |
{: class="table table-striped"}

### Return type

[**SkillEntityListing**](SkillEntityListing.html)

<a name="getroutingsmsaddress"></a>

## [**SmsAddress**](SmsAddress.html) GetRoutingSmsAddress (string addressId)



Get an Address by Id for SMS



Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAddressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID

            try
            { 
                // Get an Address by Id for SMS
                SmsAddress result = apiInstance.GetRoutingSmsAddress(addressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
{: class="table table-striped"}

### Return type

[**SmsAddress**](SmsAddress.html)

<a name="getroutingsmsaddresses"></a>

## [**SmsAddressEntityListing**](SmsAddressEntityListing.html) GetRoutingSmsAddresses (int? pageSize = null, int? pageNumber = null)



Get a list of Addresses for SMS



Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Addresses for SMS
                SmsAddressEntityListing result = apiInstance.GetRoutingSmsAddresses(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAddresses: " + e.Message );
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

[**SmsAddressEntityListing**](SmsAddressEntityListing.html)

<a name="getroutingsmsavailablephonenumbers"></a>

## [**SMSAvailablePhoneNumberEntityListing**](SMSAvailablePhoneNumberEntityListing.html) GetRoutingSmsAvailablephonenumbers (string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null)



Get a list of available phone numbers for SMS provisioning.

This request will return up to 30 random phone numbers matching the criteria specified.  To get additional phone numbers repeat the request.



Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="getroutingsmsphonenumbers"></a>

## [**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing.html) GetRoutingSmsPhonenumbers (string phoneNumber = null, List<string> phoneNumberType = null, List<string> phoneNumberStatus = null, List<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null)



Get a list of provisioned phone numbers.



Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var phoneNumber = phoneNumber_example;  // string | Filter on phone number address. Allowable characters are the digits '0-9' and the wild card character '\\*'. If just digits are present, a contains search is done on the address pattern. For example, '317' could be matched anywhere in the address. An '\\*' will match multiple digits. For example, to match a specific area code within the US a pattern like '1317*' could be used. (optional) 
            var phoneNumberType = new List<string>(); // List<string> | Filter on phone number type (optional) 
            var phoneNumberStatus = new List<string>(); // List<string> | Filter on phone number status (optional) 
            var countryCode = new List<string>(); // List<string> | Filter on country code (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Optional field to sort results (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var language = en-US;  // string | A language tag (which is sometimes referred to as a \"locale identifier\") to use to localize country field and sort operations (optional)  (default to "en-US")

            try
            { 
                // Get a list of provisioned phone numbers.
                SmsPhoneNumberEntityListing result = apiInstance.GetRoutingSmsPhonenumbers(phoneNumber, phoneNumberType, phoneNumberStatus, countryCode, pageSize, pageNumber, sortBy, sortOrder, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumber** | **string**| Filter on phone number address. Allowable characters are the digits &#39;0-9&#39; and the wild card character &#39;\\*&#39;. If just digits are present, a contains search is done on the address pattern. For example, &#39;317&#39; could be matched anywhere in the address. An &#39;\\*&#39; will match multiple digits. For example, to match a specific area code within the US a pattern like &#39;1317*&#39; could be used. | [optional]  |
| **phoneNumberType** | [**List<string>**](string.html)| Filter on phone number type | [optional] <br />**Values**: local, mobile, tollfree, shortcode |
| **phoneNumberStatus** | [**List<string>**](string.html)| Filter on phone number status | [optional] <br />**Values**: active, invalid, initiated, porting, pending, pending-cancellation |
| **countryCode** | [**List<string>**](string.html)| Filter on country code | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Optional field to sort results | [optional] <br />**Values**: phoneNumber, countryCode, country, dateCreated, dateModified, phoneNumberStatus, phoneNumberType, purchaseDate, supportsMms, supportsSms, supportsVoice |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: ascending, descending |
| **language** | **string**| A language tag (which is sometimes referred to as a \&quot;locale identifier\&quot;) to use to localize country field and sort operations | [optional] [default to "en-US"] |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing.html)

<a name="getroutinguserutilization"></a>

## [**AgentMaxUtilization**](AgentMaxUtilization.html) GetRoutingUserUtilization (string userId)



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

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get the user's max utilization settings.  If not configured, the organization-wide default is returned.
                AgentMaxUtilization result = apiInstance.GetRoutingUserUtilization(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUserUtilization: " + e.Message );
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

[**AgentMaxUtilization**](AgentMaxUtilization.html)

<a name="getroutingutilization"></a>

## [**Utilization**](Utilization.html) GetRoutingUtilization ()



Get the organization-wide max utilization settings.



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
    public class GetRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get the organization-wide max utilization settings.
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
```

### Parameters
This endpoint does require any parameters.


### Return type

[**Utilization**](Utilization.html)

<a name="getroutingwrapupcode"></a>

## [**WrapupCode**](WrapupCode.html) GetRoutingWrapupcode (string codeId)



Get details about this wrap-up code.



Requires ALL permissions: 

* routing:wrapupCode:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getroutingwrapupcodes"></a>

## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) GetRoutingWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null)



Get list of wrapup codes.



Requires ALL permissions: 

* routing:wrapupCode:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var name = name_example;  // string | Wrapup code's name ('Sort by' param is ignored unless this field is provided) (optional) 

            try
            { 
                // Get list of wrapup codes.
                WrapupCodeEntityListing result = apiInstance.GetRoutingWrapupcodes(pageSize, pageNumber, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcodes: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, id |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Wrapup code&#39;s name (&#39;Sort by&#39; param is ignored unless this field is provided) | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.html)

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.GetUserQueues: " + e.Message );
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

<a name="patchroutingconversation"></a>

## [**RoutingConversationAttributesResponse**](RoutingConversationAttributesResponse.html) PatchRoutingConversation (string conversationId, RoutingConversationAttributesRequest body)



Update attributes of an in-queue conversation

Returns an object indicating the updated values of all settable attributes. Supported attributes: skillIds, languageId, and priority.



Requires ANY permissions: 

* routing:conversation:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var body = new RoutingConversationAttributesRequest(); // RoutingConversationAttributesRequest | Conversation Attributes

            try
            { 
                // Update attributes of an in-queue conversation
                RoutingConversationAttributesResponse result = apiInstance.PatchRoutingConversation(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **body** | [**RoutingConversationAttributesRequest**](RoutingConversationAttributesRequest.html)| Conversation Attributes |  |
{: class="table table-striped"}

### Return type

[**RoutingConversationAttributesResponse**](RoutingConversationAttributesResponse.html)

<a name="patchroutingemaildomain"></a>

## [**InboundDomain**](InboundDomain.html) PatchRoutingEmailDomain (string domainId, InboundDomainPatchRequest body)



Update domain settings



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingEmailDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new InboundDomainPatchRequest(); // InboundDomainPatchRequest | Domain settings

            try
            { 
                // Update domain settings
                InboundDomain result = apiInstance.PatchRoutingEmailDomain(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**InboundDomainPatchRequest**](InboundDomainPatchRequest.html)| Domain settings |  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.html)

<a name="patchroutingemaildomainvalidate"></a>

## [**InboundDomain**](InboundDomain.html) PatchRoutingEmailDomainValidate (string domainId, InboundDomainPatchRequest body)



Validate domain settings



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingEmailDomainValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new InboundDomainPatchRequest(); // InboundDomainPatchRequest | Domain settings

            try
            { 
                // Validate domain settings
                InboundDomain result = apiInstance.PatchRoutingEmailDomainValidate(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingEmailDomainValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**InboundDomainPatchRequest**](InboundDomainPatchRequest.html)| Domain settings |  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.html)

<a name="patchroutingpredictor"></a>

## [**Predictor**](Predictor.html) PatchRoutingPredictor (string predictorId, PatchPredictorRequest body = null)



Update single predictor.



Requires ALL permissions: 

* routing:predictor:edit
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
    public class PatchRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID
            var body = new PatchPredictorRequest(); // PatchPredictorRequest |  (optional) 

            try
            { 
                // Update single predictor.
                Predictor result = apiInstance.PatchRoutingPredictor(predictorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |
| **body** | [**PatchPredictorRequest**](PatchPredictorRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Predictor**](Predictor.html)

<a name="patchroutingqueuemember"></a>

## void PatchRoutingQueueMember (string queueId, string memberId, QueueMember body)



Update the ring number OR joined status for a queue member.



Requires ANY permissions: 

* routing:queue:edit
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
    public class PatchRoutingQueueMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID
            var body = new QueueMember(); // QueueMember | Queue Member

            try
            { 
                // Update the ring number OR joined status for a queue member.
                apiInstance.PatchRoutingQueueMember(queueId, memberId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember.html)| Queue Member |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchroutingqueuemembers"></a>

## [**QueueMemberEntityListing**](QueueMemberEntityListing.html) PatchRoutingQueueMembers (string queueId, List<QueueMember> body)



Join or unjoin a set of users for a queue



Requires ANY permissions: 

* routing:queue:edit
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
    public class PatchRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members

            try
            { 
                // Join or unjoin a set of users for a queue
                QueueMemberEntityListing result = apiInstance.PatchRoutingQueueMembers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.html)| Queue Members |  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing.html)

<a name="patchroutingqueueuser"></a>

## void PatchRoutingQueueUser (string queueId, string memberId, QueueMember body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue.



Requires ANY permissions: 

* routing:queue:edit
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
    public class PatchRoutingQueueUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID
            var body = new QueueMember(); // QueueMember | Queue Member

            try
            { 
                // DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue.
                apiInstance.PatchRoutingQueueUser(queueId, memberId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember.html)| Queue Member |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchroutingqueueusers"></a>

## [**QueueMemberEntityListingV1**](QueueMemberEntityListingV1.html) PatchRoutingQueueUsers (string queueId, List<QueueMember> body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue.



Requires ANY permissions: 

* routing:queue:edit
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
    public class PatchRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members

            try
            { 
                // DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue.
                QueueMemberEntityListingV1 result = apiInstance.PatchRoutingQueueUsers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.html)| Queue Members |  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListingV1**](QueueMemberEntityListingV1.html)

<a name="patchroutingsettingscontactcenter"></a>

## void PatchRoutingSettingsContactcenter (ContactCenterSettings body)



Update Contact Center Settings



Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingSettingsContactcenterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new ContactCenterSettings(); // ContactCenterSettings | Contact Center Settings

            try
            { 
                // Update Contact Center Settings
                apiInstance.PatchRoutingSettingsContactcenter(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingSettingsContactcenter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactCenterSettings**](ContactCenterSettings.html)| Contact Center Settings |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.PatchUserQueue: " + e.Message );
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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.PatchUserQueues: " + e.Message );
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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutingskillsBulk: " + e.Message );
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

<a name="postanalyticsqueuesobservationsquery"></a>

## [**QueueObservationQueryResponse**](QueueObservationQueryResponse.html) PostAnalyticsQueuesObservationsQuery (QueueObservationQuery body)



Query for queue observations



Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new QueueObservationQuery(); // QueueObservationQuery | query

            try
            { 
                // Query for queue observations
                QueueObservationQueryResponse result = apiInstance.PostAnalyticsQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostAnalyticsQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueueObservationQuery**](QueueObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**QueueObservationQueryResponse**](QueueObservationQueryResponse.html)

<a name="postroutingassessments"></a>

## [**BenefitAssessment**](BenefitAssessment.html) PostRoutingAssessments (CreateBenefitAssessmentRequest body = null)



Create a benefit assessment.



Requires ALL permissions: 

* routing:assessment:add
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingAssessmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateBenefitAssessmentRequest(); // CreateBenefitAssessmentRequest |  (optional) 

            try
            { 
                // Create a benefit assessment.
                BenefitAssessment result = apiInstance.PostRoutingAssessments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingAssessments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateBenefitAssessmentRequest**](CreateBenefitAssessmentRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**BenefitAssessment**](BenefitAssessment.html)

<a name="postroutingassessmentsjobs"></a>

## [**BenefitAssessmentJob**](BenefitAssessmentJob.html) PostRoutingAssessmentsJobs (CreateBenefitAssessmentJobRequest body = null)



Create a benefit assessment job.



Requires ANY permissions: 

* routing:assessment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingAssessmentsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateBenefitAssessmentJobRequest(); // CreateBenefitAssessmentJobRequest |  (optional) 

            try
            { 
                // Create a benefit assessment job.
                BenefitAssessmentJob result = apiInstance.PostRoutingAssessmentsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingAssessmentsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateBenefitAssessmentJobRequest**](CreateBenefitAssessmentJobRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**BenefitAssessmentJob**](BenefitAssessmentJob.html)

<a name="postroutingemaildomainroutes"></a>

## [**InboundRoute**](InboundRoute.html) PostRoutingEmailDomainRoutes (string domainName, InboundRoute body)



Create a route



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **body** | [**InboundRoute**](InboundRoute.html)| Route |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="postroutingemaildomaintestconnection"></a>

## [**TestMessage**](TestMessage.html) PostRoutingEmailDomainTestconnection (string domainId, TestMessage body = null)



Tests the custom SMTP server integration connection set on this domain

The request body is optional. If omitted, this endpoint will just test the connection of the Custom SMTP Server. If the body is specified, there will be an attempt to send an email message to the server.



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainTestconnectionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new TestMessage(); // TestMessage | TestMessage (optional) 

            try
            { 
                // Tests the custom SMTP server integration connection set on this domain
                TestMessage result = apiInstance.PostRoutingEmailDomainTestconnection(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomainTestconnection: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**TestMessage**](TestMessage.html)| TestMessage | [optional]  |
{: class="table table-striped"}

### Return type

[**TestMessage**](TestMessage.html)

<a name="postroutingemaildomains"></a>

## [**InboundDomain**](InboundDomain.html) PostRoutingEmailDomains (InboundDomain body)



Create a domain



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Language**](Language.html)| Language |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

<a name="postroutingpredictors"></a>

## [**Predictor**](Predictor.html) PostRoutingPredictors (CreatePredictorRequest body = null)



Create a predictor.



Requires ALL permissions: 

* routing:predictor:add
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
    public class PostRoutingPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreatePredictorRequest(); // CreatePredictorRequest |  (optional) 

            try
            { 
                // Create a predictor.
                Predictor result = apiInstance.PostRoutingPredictors(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreatePredictorRequest**](CreatePredictorRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Predictor**](Predictor.html)

<a name="postroutingqueuemembers"></a>

## void PostRoutingQueueMembers (string queueId, List<WritableEntity> body, bool? delete = null)



Bulk add or delete up to 100 queue members



Requires ANY permissions: 

* routing:queue:edit
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
    public class PostRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WritableEntity>(); // List<WritableEntity> | Queue Members
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)

            try
            { 
                // Bulk add or delete up to 100 queue members
                apiInstance.PostRoutingQueueMembers(queueId, body, delete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WritableEntity>**](WritableEntity.html)| Queue Members |  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postroutingqueueusers"></a>

## void PostRoutingQueueUsers (string queueId, List<WritableEntity> body, bool? delete = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members.



Requires ANY permissions: 

* routing:queue:edit
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
    public class PostRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WritableEntity>(); // List<WritableEntity> | Queue Members
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)

            try
            { 
                // DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members.
                apiInstance.PostRoutingQueueUsers(queueId, body, delete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WritableEntity>**](WritableEntity.html)| Queue Members |  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postroutingqueuewrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) PostRoutingQueueWrapupcodes (string queueId, List<WrapUpCodeReference> body)



Add up to 100 wrap-up codes to a queue



Requires ALL permissions: 

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
    public class PostRoutingQueueWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WrapUpCodeReference>(); // List<WrapUpCodeReference> | List of wrapup codes

            try
            { 
                // Add up to 100 wrap-up codes to a queue
                List<WrapupCode> result = apiInstance.PostRoutingQueueWrapupcodes(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
```

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
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSkill**](RoutingSkill.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="postroutingsmsaddresses"></a>

## [**SmsAddress**](SmsAddress.html) PostRoutingSmsAddresses (SmsAddressProvision body)



Provision an Address for SMS



Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SmsAddressProvision(); // SmsAddressProvision | SmsAddress

            try
            { 
                // Provision an Address for SMS
                SmsAddress result = apiInstance.PostRoutingSmsAddresses(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsAddressProvision**](SmsAddressProvision.html)| SmsAddress |  |
{: class="table table-striped"}

### Return type

[**SmsAddress**](SmsAddress.html)

<a name="postroutingsmsphonenumbers"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) PostRoutingSmsPhonenumbers (SmsPhoneNumberProvision body)



Provision a phone number for SMS



Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:wrapupCode:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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
```

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



Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**QueueRequest**](QueueRequest.html)| Queue |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="putroutingsettings"></a>

## [**RoutingSettings**](RoutingSettings.html) PutRoutingSettings (RoutingSettings body)



Update an organization's routing settings



Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new RoutingSettings(); // RoutingSettings | Organization Settings

            try
            { 
                // Update an organization's routing settings
                RoutingSettings result = apiInstance.PutRoutingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSettings**](RoutingSettings.html)| Organization Settings |  |
{: class="table table-striped"}

### Return type

[**RoutingSettings**](RoutingSettings.html)

<a name="putroutingsettingstranscription"></a>

## [**TranscriptionSettings**](TranscriptionSettings.html) PutRoutingSettingsTranscription (TranscriptionSettings body)



Update Transcription Settings



Requires ANY permissions: 

* routing:transcriptionSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingSettingsTranscriptionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new TranscriptionSettings(); // TranscriptionSettings | Organization Settings

            try
            { 
                // Update Transcription Settings
                TranscriptionSettings result = apiInstance.PutRoutingSettingsTranscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSettingsTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptionSettings**](TranscriptionSettings.html)| Organization Settings |  |
{: class="table table-striped"}

### Return type

[**TranscriptionSettings**](TranscriptionSettings.html)

<a name="putroutingsmsphonenumber"></a>

## [**SmsPhoneNumber**](SmsPhoneNumber.html) PutRoutingSmsPhonenumber (string addressId, SmsPhoneNumber body)



Update a phone number provisioned for SMS.



Requires ALL permissions: 

* sms:phoneNumber:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
| **body** | [**SmsPhoneNumber**](SmsPhoneNumber.html)| SmsPhoneNumber |  |
{: class="table table-striped"}

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber.html)

<a name="putroutinguserutilization"></a>

## [**AgentMaxUtilization**](AgentMaxUtilization.html) PutRoutingUserUtilization (string userId, Utilization body)



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

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new Utilization(); // Utilization | utilization

            try
            { 
                // Update the user's max utilization settings.  Include only those media types requiring custom configuration.
                AgentMaxUtilization result = apiInstance.PutRoutingUserUtilization(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUserUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**Utilization**](Utilization.html)| utilization |  |
{: class="table table-striped"}

### Return type

[**AgentMaxUtilization**](AgentMaxUtilization.html)

<a name="putroutingutilization"></a>

## [**Utilization**](Utilization.html) PutRoutingUtilization (Utilization body)



Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration.



Requires ALL permissions: 

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
    public class PutRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new Utilization(); // Utilization | utilization

            try
            { 
                // Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration.
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
```

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



Requires ALL permissions: 

* routing:wrapupCode:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.PutUserRoutingskillsBulk: " + e.Message );
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

