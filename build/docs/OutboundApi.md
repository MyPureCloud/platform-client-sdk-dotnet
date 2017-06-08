---
title: OutboundApi
---
## PureCloudPlatform.Client.V2.Api.OutboundApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOutboundAttemptlimit**](OutboundApi.html#deleteoutboundattemptlimit) | **DELETE** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Delete attempt limits |
| [**DeleteOutboundCallabletimeset**](OutboundApi.html#deleteoutboundcallabletimeset) | **DELETE** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Delete callable time set |
| [**DeleteOutboundCallanalysisresponseset**](OutboundApi.html#deleteoutboundcallanalysisresponseset) | **DELETE** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Delete a dialer call analysis response set. |
| [**DeleteOutboundCampaign**](OutboundApi.html#deleteoutboundcampaign) | **DELETE** /api/v2/outbound/campaigns/{campaignId} | Delete a campaign. |
| [**DeleteOutboundCampaignProgress**](OutboundApi.html#deleteoutboundcampaignprogress) | **DELETE** /api/v2/outbound/campaigns/{campaignId}/progress | Reset campaign progress and recycle the campaign |
| [**DeleteOutboundCampaignrule**](OutboundApi.html#deleteoutboundcampaignrule) | **DELETE** /api/v2/outbound/campaignrules/{campaignRuleId} | Delete Campaign Rule |
| [**DeleteOutboundContactlist**](OutboundApi.html#deleteoutboundcontactlist) | **DELETE** /api/v2/outbound/contactlists/{contactListId} | Delete a contact list. |
| [**DeleteOutboundContactlistContact**](OutboundApi.html#deleteoutboundcontactlistcontact) | **DELETE** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Delete a contact. |
| [**DeleteOutboundContactlistContacts**](OutboundApi.html#deleteoutboundcontactlistcontacts) | **DELETE** /api/v2/outbound/contactlists/{contactListId}/contacts | Delete contacts from a contact list. |
| [**DeleteOutboundContactlistfilter**](OutboundApi.html#deleteoutboundcontactlistfilter) | **DELETE** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Delete Contact List Filter |
| [**DeleteOutboundDnclist**](OutboundApi.html#deleteoutbounddnclist) | **DELETE** /api/v2/outbound/dnclists/{dncListId} | Delete dialer DNC list |
| [**DeleteOutboundRuleset**](OutboundApi.html#deleteoutboundruleset) | **DELETE** /api/v2/outbound/rulesets/{ruleSetId} | Delete a Rule set. |
| [**DeleteOutboundSchedulesCampaign**](OutboundApi.html#deleteoutboundschedulescampaign) | **DELETE** /api/v2/outbound/schedules/campaigns/{campaignId} | Delete a dialer campaign schedule. |
| [**DeleteOutboundSchedulesSequence**](OutboundApi.html#deleteoutboundschedulessequence) | **DELETE** /api/v2/outbound/schedules/sequences/{sequenceId} | Delete a dialer sequence schedule. |
| [**DeleteOutboundSequence**](OutboundApi.html#deleteoutboundsequence) | **DELETE** /api/v2/outbound/sequences/{sequenceId} | Delete a dialer campaign sequence. |
| [**GetOutboundAttemptlimit**](OutboundApi.html#getoutboundattemptlimit) | **GET** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Get attempt limits |
| [**GetOutboundAttemptlimits**](OutboundApi.html#getoutboundattemptlimits) | **GET** /api/v2/outbound/attemptlimits | Query attempt limits list |
| [**GetOutboundCallabletimeset**](OutboundApi.html#getoutboundcallabletimeset) | **GET** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Get callable time set |
| [**GetOutboundCallabletimesets**](OutboundApi.html#getoutboundcallabletimesets) | **GET** /api/v2/outbound/callabletimesets | Query callable time set list |
| [**GetOutboundCallanalysisresponseset**](OutboundApi.html#getoutboundcallanalysisresponseset) | **GET** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Get a dialer call analysis response set. |
| [**GetOutboundCallanalysisresponsesets**](OutboundApi.html#getoutboundcallanalysisresponsesets) | **GET** /api/v2/outbound/callanalysisresponsesets | Query a list of dialer call analysis response sets. |
| [**GetOutboundCampaign**](OutboundApi.html#getoutboundcampaign) | **GET** /api/v2/outbound/campaigns/{campaignId} | Get dialer campaign. |
| [**GetOutboundCampaignDiagnostics**](OutboundApi.html#getoutboundcampaigndiagnostics) | **GET** /api/v2/outbound/campaigns/{campaignId}/diagnostics | Get campaign diagnostics |
| [**GetOutboundCampaignInteractions**](OutboundApi.html#getoutboundcampaigninteractions) | **GET** /api/v2/outbound/campaigns/{campaignId}/interactions | Get dialer campaign interactions. |
| [**GetOutboundCampaignProgress**](OutboundApi.html#getoutboundcampaignprogress) | **GET** /api/v2/outbound/campaigns/{campaignId}/progress | Get campaign progress |
| [**GetOutboundCampaignStats**](OutboundApi.html#getoutboundcampaignstats) | **GET** /api/v2/outbound/campaigns/{campaignId}/stats | Get statistics about a Dialer Campaign |
| [**GetOutboundCampaignrule**](OutboundApi.html#getoutboundcampaignrule) | **GET** /api/v2/outbound/campaignrules/{campaignRuleId} | Get Campaign Rule |
| [**GetOutboundCampaignrules**](OutboundApi.html#getoutboundcampaignrules) | **GET** /api/v2/outbound/campaignrules | Query Campaign Rule list |
| [**GetOutboundCampaigns**](OutboundApi.html#getoutboundcampaigns) | **GET** /api/v2/outbound/campaigns | Query a list of dialer campaigns. |
| [**GetOutboundContactlist**](OutboundApi.html#getoutboundcontactlist) | **GET** /api/v2/outbound/contactlists/{contactListId} | Get a dialer contact list. |
| [**GetOutboundContactlistContact**](OutboundApi.html#getoutboundcontactlistcontact) | **GET** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Get a contact. |
| [**GetOutboundContactlistExport**](OutboundApi.html#getoutboundcontactlistexport) | **GET** /api/v2/outbound/contactlists/{contactListId}/export | Get the URI of a contact list export. |
| [**GetOutboundContactlistImportstatus**](OutboundApi.html#getoutboundcontactlistimportstatus) | **GET** /api/v2/outbound/contactlists/{contactListId}/importstatus | Get dialer contactList import status. |
| [**GetOutboundContactlistfilter**](OutboundApi.html#getoutboundcontactlistfilter) | **GET** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Get Contact list filter |
| [**GetOutboundContactlistfilters**](OutboundApi.html#getoutboundcontactlistfilters) | **GET** /api/v2/outbound/contactlistfilters | Query Contact list filters |
| [**GetOutboundContactlists**](OutboundApi.html#getoutboundcontactlists) | **GET** /api/v2/outbound/contactlists | Query a list of contact lists. |
| [**GetOutboundDnclist**](OutboundApi.html#getoutbounddnclist) | **GET** /api/v2/outbound/dnclists/{dncListId} | Get dialer DNC list |
| [**GetOutboundDnclistExport**](OutboundApi.html#getoutbounddnclistexport) | **GET** /api/v2/outbound/dnclists/{dncListId}/export | Get the URI of a DNC list export. |
| [**GetOutboundDnclistImportstatus**](OutboundApi.html#getoutbounddnclistimportstatus) | **GET** /api/v2/outbound/dnclists/{dncListId}/importstatus | Get dialer dncList import status. |
| [**GetOutboundDnclists**](OutboundApi.html#getoutbounddnclists) | **GET** /api/v2/outbound/dnclists | Query dialer DNC lists |
| [**GetOutboundEvent**](OutboundApi.html#getoutboundevent) | **GET** /api/v2/outbound/events/{eventId} | Get Dialer Event |
| [**GetOutboundEvents**](OutboundApi.html#getoutboundevents) | **GET** /api/v2/outbound/events | Query Event Logs |
| [**GetOutboundRuleset**](OutboundApi.html#getoutboundruleset) | **GET** /api/v2/outbound/rulesets/{ruleSetId} | Get a Rule Set by ID. |
| [**GetOutboundRulesets**](OutboundApi.html#getoutboundrulesets) | **GET** /api/v2/outbound/rulesets | Query a list of Rule Sets. |
| [**GetOutboundSchedulesCampaign**](OutboundApi.html#getoutboundschedulescampaign) | **GET** /api/v2/outbound/schedules/campaigns/{campaignId} | Get a dialer campaign schedule. |
| [**GetOutboundSchedulesCampaigns**](OutboundApi.html#getoutboundschedulescampaigns) | **GET** /api/v2/outbound/schedules/campaigns | Query for a list of dialer campaign schedules. |
| [**GetOutboundSchedulesSequence**](OutboundApi.html#getoutboundschedulessequence) | **GET** /api/v2/outbound/schedules/sequences/{sequenceId} | Get a dialer sequence schedule. |
| [**GetOutboundSchedulesSequences**](OutboundApi.html#getoutboundschedulessequences) | **GET** /api/v2/outbound/schedules/sequences | Query for a list of dialer sequence schedules. |
| [**GetOutboundSequence**](OutboundApi.html#getoutboundsequence) | **GET** /api/v2/outbound/sequences/{sequenceId} | Get a dialer campaign sequence. |
| [**GetOutboundSequences**](OutboundApi.html#getoutboundsequences) | **GET** /api/v2/outbound/sequences | Query a list of dialer campaign sequences. |
| [**GetOutboundWrapupcodemappings**](OutboundApi.html#getoutboundwrapupcodemappings) | **GET** /api/v2/outbound/wrapupcodemappings | Get the Dialer wrap up code mapping. |
| [**PostOutboundAttemptlimits**](OutboundApi.html#postoutboundattemptlimits) | **POST** /api/v2/outbound/attemptlimits | Create attempt limits |
| [**PostOutboundAudits**](OutboundApi.html#postoutboundaudits) | **POST** /api/v2/outbound/audits | Retrieves audits for dialer. |
| [**PostOutboundCallabletimesets**](OutboundApi.html#postoutboundcallabletimesets) | **POST** /api/v2/outbound/callabletimesets | Create callable time set |
| [**PostOutboundCallanalysisresponsesets**](OutboundApi.html#postoutboundcallanalysisresponsesets) | **POST** /api/v2/outbound/callanalysisresponsesets | Create a dialer call analysis response set. |
| [**PostOutboundCampaignCallbackSchedule**](OutboundApi.html#postoutboundcampaigncallbackschedule) | **POST** /api/v2/outbound/campaigns/{campaignId}/callback/schedule | Schedule a Callback for a Dialer Campaign (Deprecated) |
| [**PostOutboundCampaignrules**](OutboundApi.html#postoutboundcampaignrules) | **POST** /api/v2/outbound/campaignrules | Create Campaign Rule |
| [**PostOutboundCampaigns**](OutboundApi.html#postoutboundcampaigns) | **POST** /api/v2/outbound/campaigns | Create a campaign. |
| [**PostOutboundCampaignsProgress**](OutboundApi.html#postoutboundcampaignsprogress) | **POST** /api/v2/outbound/campaigns/progress | Get progress for a list of campaigns |
| [**PostOutboundContactlistContacts**](OutboundApi.html#postoutboundcontactlistcontacts) | **POST** /api/v2/outbound/contactlists/{contactListId}/contacts | Add contacts to a contact list. |
| [**PostOutboundContactlistExport**](OutboundApi.html#postoutboundcontactlistexport) | **POST** /api/v2/outbound/contactlists/{contactListId}/export | Initiate the export of a contact list. |
| [**PostOutboundContactlistfilters**](OutboundApi.html#postoutboundcontactlistfilters) | **POST** /api/v2/outbound/contactlistfilters | Create Contact List Filter |
| [**PostOutboundContactlistfiltersPreview**](OutboundApi.html#postoutboundcontactlistfilterspreview) | **POST** /api/v2/outbound/contactlistfilters/preview | Get a preview of the output of a contact list filter |
| [**PostOutboundContactlists**](OutboundApi.html#postoutboundcontactlists) | **POST** /api/v2/outbound/contactlists | Create a contact List. |
| [**PostOutboundConversationDnc**](OutboundApi.html#postoutboundconversationdnc) | **POST** /api/v2/outbound/conversations/{conversationId}/dnc | Add phone numbers to a Dialer DNC list. |
| [**PostOutboundDnclistExport**](OutboundApi.html#postoutbounddnclistexport) | **POST** /api/v2/outbound/dnclists/{dncListId}/export | Initiate the export of a dnc list. |
| [**PostOutboundDnclistPhonenumbers**](OutboundApi.html#postoutbounddnclistphonenumbers) | **POST** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add phone numbers to a Dialer DNC list. |
| [**PostOutboundDnclists**](OutboundApi.html#postoutbounddnclists) | **POST** /api/v2/outbound/dnclists | Create dialer DNC list |
| [**PostOutboundRulesets**](OutboundApi.html#postoutboundrulesets) | **POST** /api/v2/outbound/rulesets | Create a Dialer Call Analysis Response Set. |
| [**PostOutboundSequences**](OutboundApi.html#postoutboundsequences) | **POST** /api/v2/outbound/sequences | Create a new campaign sequence. |
| [**PutOutboundAttemptlimit**](OutboundApi.html#putoutboundattemptlimit) | **PUT** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Update attempt limits |
| [**PutOutboundCallabletimeset**](OutboundApi.html#putoutboundcallabletimeset) | **PUT** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Update callable time set |
| [**PutOutboundCallanalysisresponseset**](OutboundApi.html#putoutboundcallanalysisresponseset) | **PUT** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Update a dialer call analysis response set. |
| [**PutOutboundCampaign**](OutboundApi.html#putoutboundcampaign) | **PUT** /api/v2/outbound/campaigns/{campaignId} | Update a campaign. |
| [**PutOutboundCampaignAgent**](OutboundApi.html#putoutboundcampaignagent) | **PUT** /api/v2/outbound/campaigns/{campaignId}/agents/{userId} | Send notification that an agent&#39;s state changed  |
| [**PutOutboundCampaignrule**](OutboundApi.html#putoutboundcampaignrule) | **PUT** /api/v2/outbound/campaignrules/{campaignRuleId} | Update Campaign Rule |
| [**PutOutboundContactlist**](OutboundApi.html#putoutboundcontactlist) | **PUT** /api/v2/outbound/contactlists/{contactListId} | Update a contact list. |
| [**PutOutboundContactlistContact**](OutboundApi.html#putoutboundcontactlistcontact) | **PUT** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Update a contact. |
| [**PutOutboundContactlistfilter**](OutboundApi.html#putoutboundcontactlistfilter) | **PUT** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Update Contact List Filter |
| [**PutOutboundDnclist**](OutboundApi.html#putoutbounddnclist) | **PUT** /api/v2/outbound/dnclists/{dncListId} | Update dialer DNC list |
| [**PutOutboundRuleset**](OutboundApi.html#putoutboundruleset) | **PUT** /api/v2/outbound/rulesets/{ruleSetId} | Update a RuleSet. |
| [**PutOutboundSchedulesCampaign**](OutboundApi.html#putoutboundschedulescampaign) | **PUT** /api/v2/outbound/schedules/campaigns/{campaignId} | Update a new campaign schedule. |
| [**PutOutboundSchedulesSequence**](OutboundApi.html#putoutboundschedulessequence) | **PUT** /api/v2/outbound/schedules/sequences/{sequenceId} | Update a new sequence schedule. |
| [**PutOutboundSequence**](OutboundApi.html#putoutboundsequence) | **PUT** /api/v2/outbound/sequences/{sequenceId} | Update a new campaign sequence. |
| [**PutOutboundWrapupcodemappings**](OutboundApi.html#putoutboundwrapupcodemappings) | **PUT** /api/v2/outbound/wrapupcodemappings | Update the Dialer wrap up code mapping. |
{: class="table table-striped"}

<a name="deleteoutboundattemptlimit"></a>

## void DeleteOutboundAttemptlimit (string attemptLimitsId)

Delete attempt limits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundAttemptlimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID
            
            
            

            try
            {
                
                // Delete attempt limits
                
                apiInstance.DeleteOutboundAttemptlimit(attemptLimitsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcallabletimeset"></a>

## void DeleteOutboundCallabletimeset (string callableTimeSetId)

Delete callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallabletimesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            
            
            

            try
            {
                
                // Delete callable time set
                
                apiInstance.DeleteOutboundCallabletimeset(callableTimeSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcallanalysisresponseset"></a>

## void DeleteOutboundCallanalysisresponseset (string callAnalysisSetId)

Delete a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallanalysisresponsesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            
            
            

            try
            {
                
                // Delete a dialer call analysis response set.
                
                apiInstance.DeleteOutboundCallanalysisresponseset(callAnalysisSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcampaign"></a>

## [**Campaign**](Campaign.html) DeleteOutboundCampaign (string campaignId)

Delete a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Delete a campaign.
                
                Campaign result = apiInstance.DeleteOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="deleteoutboundcampaignprogress"></a>

## void DeleteOutboundCampaignProgress (string campaignId)

Reset campaign progress and recycle the campaign



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Reset campaign progress and recycle the campaign
                
                apiInstance.DeleteOutboundCampaignProgress(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcampaignrule"></a>

## void DeleteOutboundCampaignrule (string campaignRuleId)

Delete Campaign Rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignruleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID
            
            
            

            try
            {
                
                // Delete Campaign Rule
                
                apiInstance.DeleteOutboundCampaignrule(campaignRuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlist"></a>

## void DeleteOutboundContactlist (string contactListId)

Delete a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            

            try
            {
                
                // Delete a contact list.
                
                apiInstance.DeleteOutboundContactlist(contactListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistcontact"></a>

## void DeleteOutboundContactlistContact (string contactListId, string contactId)

Delete a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | Contact List ID
            
            
            
            
            var contactId = contactId_example;  // string | Contact ID
            
            
            

            try
            {
                
                // Delete a contact.
                
                apiInstance.DeleteOutboundContactlistContact(contactListId, contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistcontacts"></a>

## void DeleteOutboundContactlistContacts (string contactListId, List<string> contactIds)

Delete contacts from a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | Contact List ID
            
            
            
            
            
            var contactIds = new List<string>(); // List<string> | ContactIds to delete.
            
            

            try
            {
                
                // Delete contacts from a contact list.
                
                apiInstance.DeleteOutboundContactlistContacts(contactListId, contactIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactIds** | [**List<string>**](string.html)| ContactIds to delete. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundcontactlistfilter"></a>

## void DeleteOutboundContactlistfilter (string contactListFilterId)

Delete Contact List Filter



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistfilterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID
            
            
            

            try
            {
                
                // Delete Contact List Filter
                
                apiInstance.DeleteOutboundContactlistfilter(contactListFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutbounddnclist"></a>

## void DeleteOutboundDnclist (string dncListId)

Delete dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            

            try
            {
                
                // Delete dialer DNC list
                
                apiInstance.DeleteOutboundDnclist(dncListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundruleset"></a>

## void DeleteOutboundRuleset (string ruleSetId)

Delete a Rule set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundRulesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            
            
            

            try
            {
                
                // Delete a Rule set.
                
                apiInstance.DeleteOutboundRuleset(ruleSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundRuleset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulescampaign"></a>

## void DeleteOutboundSchedulesCampaign (string campaignId)

Delete a dialer campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Delete a dialer campaign schedule.
                
                apiInstance.DeleteOutboundSchedulesCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundschedulessequence"></a>

## void DeleteOutboundSchedulesSequence (string sequenceId)

Delete a dialer sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Sequence ID
            
            
            

            try
            {
                
                // Delete a dialer sequence schedule.
                
                apiInstance.DeleteOutboundSchedulesSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteoutboundsequence"></a>

## void DeleteOutboundSequence (string sequenceId)

Delete a dialer campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            
            
            

            try
            {
                
                // Delete a dialer campaign sequence.
                
                apiInstance.DeleteOutboundSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getoutboundattemptlimit"></a>

## [**AttemptLimits**](AttemptLimits.html) GetOutboundAttemptlimit (string attemptLimitsId)

Get attempt limits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID
            
            
            

            try
            {
                
                // Get attempt limits
                
                AttemptLimits result = apiInstance.GetOutboundAttemptlimit(attemptLimitsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="getoutboundattemptlimits"></a>

## [**AttemptLimitsEntityListing**](AttemptLimitsEntityListing.html) GetOutboundAttemptlimits (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query attempt limits list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query attempt limits list
                
                AttemptLimitsEntityListing result = apiInstance.GetOutboundAttemptlimits(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimits: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**AttemptLimitsEntityListing**](AttemptLimitsEntityListing.html)

<a name="getoutboundcallabletimeset"></a>

## [**CallableTimeSet**](CallableTimeSet.html) GetOutboundCallabletimeset (string callableTimeSetId)

Get callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            
            
            

            try
            {
                
                // Get callable time set
                
                CallableTimeSet result = apiInstance.GetOutboundCallabletimeset(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="getoutboundcallabletimesets"></a>

## [**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html) GetOutboundCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query callable time set list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query callable time set list
                
                CallableTimeSetEntityListing result = apiInstance.GetOutboundCallabletimesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimesets: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html)

<a name="getoutboundcallanalysisresponseset"></a>

## [**ResponseSet**](ResponseSet.html) GetOutboundCallanalysisresponseset (string callAnalysisSetId)

Get a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            
            
            

            try
            {
                
                // Get a dialer call analysis response set.
                
                ResponseSet result = apiInstance.GetOutboundCallanalysisresponseset(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="getoutboundcallanalysisresponsesets"></a>

## [**ResponseSetEntityListing**](ResponseSetEntityListing.html) GetOutboundCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer call analysis response sets.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query a list of dialer call analysis response sets.
                
                ResponseSetEntityListing result = apiInstance.GetOutboundCallanalysisresponsesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponsesets: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ResponseSetEntityListing**](ResponseSetEntityListing.html)

<a name="getoutboundcampaign"></a>

## [**Campaign**](Campaign.html) GetOutboundCampaign (string campaignId)

Get dialer campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get dialer campaign.
                
                Campaign result = apiInstance.GetOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="getoutboundcampaigndiagnostics"></a>

## [**CampaignDiagnostics**](CampaignDiagnostics.html) GetOutboundCampaignDiagnostics (string campaignId)

Get campaign diagnostics



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignDiagnosticsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get campaign diagnostics
                
                CampaignDiagnostics result = apiInstance.GetOutboundCampaignDiagnostics(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignDiagnostics: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignDiagnostics**](CampaignDiagnostics.html)

<a name="getoutboundcampaigninteractions"></a>

## [**CampaignInteractions**](CampaignInteractions.html) GetOutboundCampaignInteractions (string campaignId)

Get dialer campaign interactions.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get dialer campaign interactions.
                
                CampaignInteractions result = apiInstance.GetOutboundCampaignInteractions(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignInteractions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignInteractions**](CampaignInteractions.html)

<a name="getoutboundcampaignprogress"></a>

## [**CampaignProgress**](CampaignProgress.html) GetOutboundCampaignProgress (string campaignId)

Get campaign progress



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get campaign progress
                
                CampaignProgress result = apiInstance.GetOutboundCampaignProgress(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignProgress**](CampaignProgress.html)

<a name="getoutboundcampaignstats"></a>

## [**CampaignStats**](CampaignStats.html) GetOutboundCampaignStats (string campaignId)

Get statistics about a Dialer Campaign



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignStatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get statistics about a Dialer Campaign
                
                CampaignStats result = apiInstance.GetOutboundCampaignStats(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignStats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignStats**](CampaignStats.html)

<a name="getoutboundcampaignrule"></a>

## [**CampaignRule**](CampaignRule.html) GetOutboundCampaignrule (string campaignRuleId)

Get Campaign Rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignruleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID
            
            
            

            try
            {
                
                // Get Campaign Rule
                
                CampaignRule result = apiInstance.GetOutboundCampaignrule(campaignRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="getoutboundcampaignrules"></a>

## [**CampaignRuleEntityListing**](CampaignRuleEntityListing.html) GetOutboundCampaignrules (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query Campaign Rule list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignrulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query Campaign Rule list
                
                CampaignRuleEntityListing result = apiInstance.GetOutboundCampaignrules(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrules: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignRuleEntityListing**](CampaignRuleEntityListing.html)

<a name="getoutboundcampaigns"></a>

## [**CampaignEntityListing**](CampaignEntityListing.html) GetOutboundCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaigns.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            
            
            
            
            var dncListId = dncListId_example;  // string | DNC list ID (optional) 
            
            
            
            
            var distributionQueueId = distributionQueueId_example;  // string | Distribution queue ID (optional) 
            
            
            
            
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID (optional) 
            
            
            
            
            var callAnalysisResponseSetId = callAnalysisResponseSetId_example;  // string | Call analysis response set ID (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query a list of dialer campaigns.
                
                CampaignEntityListing result = apiInstance.GetOutboundCampaigns(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaigns: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **dncListId** | **string**| DNC list ID | [optional]  |
| **distributionQueueId** | **string**| Distribution queue ID | [optional]  |
| **edgeGroupId** | **string**| Edge group ID | [optional]  |
| **callAnalysisResponseSetId** | **string**| Call analysis response set ID | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignEntityListing**](CampaignEntityListing.html)

<a name="getoutboundcontactlist"></a>

## [**ContactList**](ContactList.html) GetOutboundContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)

Get a dialer contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            
            
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            
            
            
            
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            
            
            

            try
            {
                
                // Get a dialer contact list.
                
                ContactList result = apiInstance.GetOutboundContactlist(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="getoutboundcontactlistcontact"></a>

## [**DialerContact**](DialerContact.html) GetOutboundContactlistContact (string contactListId, string contactId)

Get a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistContactExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | Contact List ID
            
            
            
            
            var contactId = contactId_example;  // string | Contact ID
            
            
            

            try
            {
                
                // Get a contact.
                
                DialerContact result = apiInstance.GetOutboundContactlistContact(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="getoutboundcontactlistexport"></a>

## [**ExportUri**](ExportUri.html) GetOutboundContactlistExport (string contactListId, string download = null)

Get the URI of a contact list export.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            
            
            var download = download_example;  // string | Redirect to download uri (optional)  (default to false)
            
            
            

            try
            {
                
                // Get the URI of a contact list export.
                
                ExportUri result = apiInstance.GetOutboundContactlistExport(contactListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getoutboundcontactlistimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetOutboundContactlistImportstatus (string contactListId)

Get dialer contactList import status.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistImportstatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            

            try
            {
                
                // Get dialer contactList import status.
                
                ImportStatus result = apiInstance.GetOutboundContactlistImportstatus(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistImportstatus: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getoutboundcontactlistfilter"></a>

## [**ContactListFilter**](ContactListFilter.html) GetOutboundContactlistfilter (string contactListFilterId)

Get Contact list filter



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfilterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID
            
            
            

            try
            {
                
                // Get Contact list filter
                
                ContactListFilter result = apiInstance.GetOutboundContactlistfilter(contactListFilterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="getoutboundcontactlistfilters"></a>

## [**ContactListFilterEntityListing**](ContactListFilterEntityListing.html) GetOutboundContactlistfilters (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListId = null)

Query Contact list filters



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfiltersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            
            
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            
            
            

            try
            {
                
                // Query Contact list filters
                
                ContactListFilterEntityListing result = apiInstance.GetOutboundContactlistfilters(pageSize, pageNumber, filterType, name, sortBy, sortOrder, contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilters: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
| **contactListId** | **string**| Contact List ID | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactListFilterEntityListing**](ContactListFilterEntityListing.html)

<a name="getoutboundcontactlists"></a>

## [**ContactListEntityListing**](ContactListEntityListing.html) GetOutboundContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of contact lists.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            
            
            
            
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query a list of contact lists.
                
                ContactListEntityListing result = apiInstance.GetOutboundContactlists(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**ContactListEntityListing**](ContactListEntityListing.html)

<a name="getoutbounddnclist"></a>

## [**DncList**](DncList.html) GetOutboundDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)

Get dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            
            
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            
            
            
            
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            
            
            

            try
            {
                
                // Get dialer DNC list
                
                DncList result = apiInstance.GetOutboundDnclist(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="getoutbounddnclistexport"></a>

## [**ExportUri**](ExportUri.html) GetOutboundDnclistExport (string dncListId, string download = null)

Get the URI of a DNC list export.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            
            
            var download = download_example;  // string | Redirect to download uri (optional)  (default to false)
            
            
            

            try
            {
                
                // Get the URI of a DNC list export.
                
                ExportUri result = apiInstance.GetOutboundDnclistExport(dncListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getoutbounddnclistimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetOutboundDnclistImportstatus (string dncListId)

Get dialer dncList import status.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistImportstatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            

            try
            {
                
                // Get dialer dncList import status.
                
                ImportStatus result = apiInstance.GetOutboundDnclistImportstatus(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistImportstatus: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getoutbounddnclists"></a>

## [**DncListEntityListing**](DncListEntityListing.html) GetOutboundDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query dialer DNC lists



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            
            
            
            
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            
            
            

            try
            {
                
                // Query dialer DNC lists
                
                DncListEntityListing result = apiInstance.GetOutboundDnclists(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DncListEntityListing**](DncListEntityListing.html)

<a name="getoutboundevent"></a>

## [**EventLog**](EventLog.html) GetOutboundEvent (string eventId)

Get Dialer Event



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var eventId = eventId_example;  // string | Event Log ID
            
            
            

            try
            {
                
                // Get Dialer Event
                
                EventLog result = apiInstance.GetOutboundEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvent: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **eventId** | **string**| Event Log ID |  |
{: class="table table-striped"}

### Return type

[**EventLog**](EventLog.html)

<a name="getoutboundevents"></a>

## [**DialerEventEntityListing**](DialerEventEntityListing.html) GetOutboundEvents (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)

Query Event Logs



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var category = category_example;  // string | Category (optional) 
            
            
            
            
            var level = level_example;  // string | Level (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query Event Logs
                
                DialerEventEntityListing result = apiInstance.GetOutboundEvents(pageSize, pageNumber, filterType, category, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvents: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **category** | **string**| Category | [optional]  |
| **level** | **string**| Level | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DialerEventEntityListing**](DialerEventEntityListing.html)

<a name="getoutboundruleset"></a>

## [**RuleSet**](RuleSet.html) GetOutboundRuleset (string ruleSetId)

Get a Rule Set by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            
            
            

            try
            {
                
                // Get a Rule Set by ID.
                
                RuleSet result = apiInstance.GetOutboundRuleset(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRuleset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="getoutboundrulesets"></a>

## [**RuleSetEntityListing**](RuleSetEntityListing.html) GetOutboundRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of Rule Sets.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query a list of Rule Sets.
                
                RuleSetEntityListing result = apiInstance.GetOutboundRulesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRulesets: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**RuleSetEntityListing**](RuleSetEntityListing.html)

<a name="getoutboundschedulescampaign"></a>

## [**CampaignSchedule**](CampaignSchedule.html) GetOutboundSchedulesCampaign (string campaignId)

Get a dialer campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            

            try
            {
                
                // Get a dialer campaign schedule.
                
                CampaignSchedule result = apiInstance.GetOutboundSchedulesCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="getoutboundschedulescampaigns"></a>

## [**List&lt;CampaignSchedule&gt;**](CampaignSchedule.html) GetOutboundSchedulesCampaigns ()

Query for a list of dialer campaign schedules.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            

            try
            {
                
                // Query for a list of dialer campaign schedules.
                
                List&lt;CampaignSchedule&gt; result = apiInstance.GetOutboundSchedulesCampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaigns: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<CampaignSchedule>**](CampaignSchedule.html)

<a name="getoutboundschedulessequence"></a>

## [**SequenceSchedule**](SequenceSchedule.html) GetOutboundSchedulesSequence (string sequenceId)

Get a dialer sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Sequence ID
            
            
            

            try
            {
                
                // Get a dialer sequence schedule.
                
                SequenceSchedule result = apiInstance.GetOutboundSchedulesSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="getoutboundschedulessequences"></a>

## [**List&lt;SequenceSchedule&gt;**](SequenceSchedule.html) GetOutboundSchedulesSequences ()

Query for a list of dialer sequence schedules.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            

            try
            {
                
                // Query for a list of dialer sequence schedules.
                
                List&lt;SequenceSchedule&gt; result = apiInstance.GetOutboundSchedulesSequences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<SequenceSchedule>**](SequenceSchedule.html)

<a name="getoutboundsequence"></a>

## [**CampaignSequence**](CampaignSequence.html) GetOutboundSequence (string sequenceId)

Get a dialer campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            
            
            

            try
            {
                
                // Get a dialer campaign sequence.
                
                CampaignSequence result = apiInstance.GetOutboundSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="getoutboundsequences"></a>

## [**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html) GetOutboundSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaign sequences.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            
            
            

            try
            {
                
                // Query a list of dialer campaign sequences.
                
                CampaignSequenceEntityListing result = apiInstance.GetOutboundSequences(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequences: " + e.Message );
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
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html)

<a name="getoutboundwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) GetOutboundWrapupcodemappings ()

Get the Dialer wrap up code mapping.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundWrapupcodemappingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            

            try
            {
                
                // Get the Dialer wrap up code mapping.
                
                WrapUpCodeMapping result = apiInstance.GetOutboundWrapupcodemappings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

<a name="postoutboundattemptlimits"></a>

## [**AttemptLimits**](AttemptLimits.html) PostOutboundAttemptlimits (AttemptLimits body)

Create attempt limits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundAttemptlimitsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits
            
            

            try
            {
                
                // Create attempt limits
                
                AttemptLimits result = apiInstance.PostOutboundAttemptlimits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundAttemptlimits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AttemptLimits**](AttemptLimits.html)| AttemptLimits |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="postoutboundaudits"></a>

## [**AuditSearchResult**](AuditSearchResult.html) PostOutboundAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)

Retrieves audits for dialer.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new DialerAuditRequest(); // DialerAuditRequest | AuditSearch
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to entity.name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            
            
            
            
            var facetsOnly = true;  // bool? | Facets only (optional)  (default to false)
            
            
            

            try
            {
                
                // Retrieves audits for dialer.
                
                AuditSearchResult result = apiInstance.PostOutboundAudits(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DialerAuditRequest**](DialerAuditRequest.html)| AuditSearch |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to entity.name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending] |
| **facetsOnly** | **bool?**| Facets only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AuditSearchResult**](AuditSearchResult.html)

<a name="postoutboundcallabletimesets"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PostOutboundCallabletimesets (CallableTimeSet body)

Create callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallabletimesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet
            
            

            try
            {
                
                // Create callable time set
                
                CallableTimeSet result = apiInstance.PostOutboundCallabletimesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallabletimesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="postoutboundcallanalysisresponsesets"></a>

## [**ResponseSet**](ResponseSet.html) PostOutboundCallanalysisresponsesets (ResponseSet body)

Create a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallanalysisresponsesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new ResponseSet(); // ResponseSet | ResponseSet
            
            

            try
            {
                
                // Create a dialer call analysis response set.
                
                ResponseSet result = apiInstance.PostOutboundCallanalysisresponsesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="postoutboundcampaigncallbackschedule"></a>

## [**ContactCallbackRequest**](ContactCallbackRequest.html) PostOutboundCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body)

Schedule a Callback for a Dialer Campaign (Deprecated)

This endpoint is deprecated and may have unexpected results. Please use \"/conversations/{conversationId}/participants/{participantId}/callbacks instead.\"

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignCallbackScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            
            
            
            var body = new ContactCallbackRequest(); // ContactCallbackRequest | ContactCallbackRequest
            
            

            try
            {
                
                // Schedule a Callback for a Dialer Campaign (Deprecated)
                
                ContactCallbackRequest result = apiInstance.PostOutboundCampaignCallbackSchedule(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignCallbackSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**ContactCallbackRequest**](ContactCallbackRequest.html)| ContactCallbackRequest |  |
{: class="table table-striped"}

### Return type

[**ContactCallbackRequest**](ContactCallbackRequest.html)

<a name="postoutboundcampaignrules"></a>

## [**CampaignRule**](CampaignRule.html) PostOutboundCampaignrules (CampaignRule body)

Create Campaign Rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignrulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new CampaignRule(); // CampaignRule | CampaignRule
            
            

            try
            {
                
                // Create Campaign Rule
                
                CampaignRule result = apiInstance.PostOutboundCampaignrules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignrules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignRule**](CampaignRule.html)| CampaignRule |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="postoutboundcampaigns"></a>

## [**Campaign**](Campaign.html) PostOutboundCampaigns (Campaign body)

Create a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new Campaign(); // Campaign | Campaign
            
            

            try
            {
                
                // Create a campaign.
                
                Campaign result = apiInstance.PostOutboundCampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaigns: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="postoutboundcampaignsprogress"></a>

## [**List&lt;CampaignProgress&gt;**](CampaignProgress.html) PostOutboundCampaignsProgress (List<string> body)

Get progress for a list of campaigns



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var body = ;  // List<string> | Campaign IDs
            
            
            

            try
            {
                
                // Get progress for a list of campaigns
                
                List&lt;CampaignProgress&gt; result = apiInstance.PostOutboundCampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignsProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **List<string>**| Campaign IDs |  |
{: class="table table-striped"}

### Return type

[**List<CampaignProgress>**](CampaignProgress.html)

<a name="postoutboundcontactlistcontacts"></a>

## [**List&lt;DialerContact&gt;**](DialerContact.html) PostOutboundContactlistContacts (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null)

Add contacts to a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | Contact List ID
            
            
            
            
            
            var body = new List<DialerContact>(); // List<DialerContact> | Contact
            
            
            
            var priority = true;  // bool? | Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional) 
            
            
            
            
            var clearSystemData = true;  // bool? | Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won't. (optional) 
            
            
            

            try
            {
                
                // Add contacts to a contact list.
                
                List&lt;DialerContact&gt; result = apiInstance.PostOutboundContactlistContacts(contactListId, body, priority, clearSystemData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<DialerContact>**](DialerContact.html)| Contact |  |
| **priority** | **bool?**| Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. | [optional]  |
| **clearSystemData** | **bool?**| Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<DialerContact>**](DialerContact.html)

<a name="postoutboundcontactlistexport"></a>

## [**UriReference**](UriReference.html) PostOutboundContactlistExport (string contactListId)

Initiate the export of a contact list.

Returns 200 if received OK.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            

            try
            {
                
                // Initiate the export of a contact list.
                
                UriReference result = apiInstance.PostOutboundContactlistExport(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**UriReference**](UriReference.html)

<a name="postoutboundcontactlistfilters"></a>

## [**ContactListFilter**](ContactListFilter.html) PostOutboundContactlistfilters (ContactListFilter body)

Create Contact List Filter



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter
            
            

            try
            {
                
                // Create Contact List Filter
                
                ContactListFilter result = apiInstance.PostOutboundContactlistfilters(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfilters: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="postoutboundcontactlistfilterspreview"></a>

## [**FilterPreviewResponse**](FilterPreviewResponse.html) PostOutboundContactlistfiltersPreview (ContactListFilter body)

Get a preview of the output of a contact list filter



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersPreviewExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter
            
            

            try
            {
                
                // Get a preview of the output of a contact list filter
                
                FilterPreviewResponse result = apiInstance.PostOutboundContactlistfiltersPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfiltersPreview: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**FilterPreviewResponse**](FilterPreviewResponse.html)

<a name="postoutboundcontactlists"></a>

## [**ContactList**](ContactList.html) PostOutboundContactlists (ContactList body)

Create a contact List.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new ContactList(); // ContactList | ContactList
            
            

            try
            {
                
                // Create a contact List.
                
                ContactList result = apiInstance.PostOutboundContactlists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="postoutboundconversationdnc"></a>

## void PostOutboundConversationDnc (string conversationId)

Add phone numbers to a Dialer DNC list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundConversationDncExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var conversationId = conversationId_example;  // string | Conversation ID
            
            
            

            try
            {
                
                // Add phone numbers to a Dialer DNC list.
                
                apiInstance.PostOutboundConversationDnc(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundConversationDnc: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutbounddnclistexport"></a>

## [**UriReference**](UriReference.html) PostOutboundDnclistExport (string dncListId)

Initiate the export of a dnc list.

Returns 200 if received OK.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            

            try
            {
                
                // Initiate the export of a dnc list.
                
                UriReference result = apiInstance.PostOutboundDnclistExport(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**UriReference**](UriReference.html)

<a name="postoutbounddnclistphonenumbers"></a>

## void PostOutboundDnclistPhonenumbers (string dncListId, List<string> body)

Add phone numbers to a Dialer DNC list.

Only Internal DNC lists may be appended to

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistPhonenumbersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            
            
            var body = ;  // List<string> | DNC Phone Numbers
            
            
            

            try
            {
                
                // Add phone numbers to a Dialer DNC list.
                
                apiInstance.PostOutboundDnclistPhonenumbers(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | **List<string>**| DNC Phone Numbers |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postoutbounddnclists"></a>

## [**DncList**](DncList.html) PostOutboundDnclists (DncListCreate body)

Create dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new DncListCreate(); // DncListCreate | DncList
            
            

            try
            {
                
                // Create dialer DNC list
                
                DncList result = apiInstance.PostOutboundDnclists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DncListCreate**](DncListCreate.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="postoutboundrulesets"></a>

## [**RuleSet**](RuleSet.html) PostOutboundRulesets (RuleSet body)

Create a Dialer Call Analysis Response Set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundRulesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new RuleSet(); // RuleSet | RuleSet
            
            

            try
            {
                
                // Create a Dialer Call Analysis Response Set.
                
                RuleSet result = apiInstance.PostOutboundRulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundRulesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="postoutboundsequences"></a>

## [**CampaignSequence**](CampaignSequence.html) PostOutboundSequences (CampaignSequence body)

Create a new campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundSequencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new CampaignSequence(); // CampaignSequence | Organization
            
            

            try
            {
                
                // Create a new campaign sequence.
                
                CampaignSequence result = apiInstance.PostOutboundSequences(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundSequences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putoutboundattemptlimit"></a>

## [**AttemptLimits**](AttemptLimits.html) PutOutboundAttemptlimit (string attemptLimitsId, AttemptLimits body)

Update attempt limits



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundAttemptlimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID
            
            
            
            
            
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits
            
            

            try
            {
                
                // Update attempt limits
                
                AttemptLimits result = apiInstance.PutOutboundAttemptlimit(attemptLimitsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
| **body** | [**AttemptLimits**](AttemptLimits.html)| AttemptLimits |  |
{: class="table table-striped"}

### Return type

[**AttemptLimits**](AttemptLimits.html)

<a name="putoutboundcallabletimeset"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PutOutboundCallabletimeset (string callableTimeSetId, CallableTimeSet body)

Update callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallabletimesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            
            
            
            
            
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet
            
            

            try
            {
                
                // Update callable time set
                
                CallableTimeSet result = apiInstance.PutOutboundCallabletimeset(callableTimeSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="putoutboundcallanalysisresponseset"></a>

## [**ResponseSet**](ResponseSet.html) PutOutboundCallanalysisresponseset (string callAnalysisSetId, ResponseSet body)

Update a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallanalysisresponsesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            
            
            
            
            
            var body = new ResponseSet(); // ResponseSet | ResponseSet
            
            

            try
            {
                
                // Update a dialer call analysis response set.
                
                ResponseSet result = apiInstance.PutOutboundCallanalysisresponseset(callAnalysisSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="putoutboundcampaign"></a>

## [**Campaign**](Campaign.html) PutOutboundCampaign (string campaignId, Campaign body)

Update a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            
            
            
            var body = new Campaign(); // Campaign | Campaign
            
            

            try
            {
                
                // Update a campaign.
                
                Campaign result = apiInstance.PutOutboundCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="putoutboundcampaignagent"></a>

## **string** PutOutboundCampaignAgent (string campaignId, string userId, Agent body)

Send notification that an agent's state changed 

New agent state.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignAgentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            
            
            var userId = userId_example;  // string | Agent's user ID
            
            
            
            
            
            var body = new Agent(); // Agent | agent
            
            

            try
            {
                
                // Send notification that an agent's state changed 
                
                string result = apiInstance.PutOutboundCampaignAgent(campaignId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignAgent: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **userId** | **string**| Agent&#39;s user ID |  |
| **body** | [**Agent**](Agent.html)| agent |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putoutboundcampaignrule"></a>

## [**CampaignRule**](CampaignRule.html) PutOutboundCampaignrule (string campaignRuleId, CampaignRule body)

Update Campaign Rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignruleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID
            
            
            
            
            
            var body = new CampaignRule(); // CampaignRule | CampaignRule
            
            

            try
            {
                
                // Update Campaign Rule
                
                CampaignRule result = apiInstance.PutOutboundCampaignrule(campaignRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
| **body** | [**CampaignRule**](CampaignRule.html)| CampaignRule |  |
{: class="table table-striped"}

### Return type

[**CampaignRule**](CampaignRule.html)

<a name="putoutboundcontactlist"></a>

## [**ContactList**](ContactList.html) PutOutboundContactlist (string contactListId, ContactList body)

Update a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | ContactList ID
            
            
            
            
            
            var body = new ContactList(); // ContactList | ContactList
            
            

            try
            {
                
                // Update a contact list.
                
                ContactList result = apiInstance.PutOutboundContactlist(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="putoutboundcontactlistcontact"></a>

## [**DialerContact**](DialerContact.html) PutOutboundContactlistContact (string contactListId, string contactId, DialerContact body)

Update a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistContactExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListId = contactListId_example;  // string | Contact List ID
            
            
            
            
            var contactId = contactId_example;  // string | Contact ID
            
            
            
            
            
            var body = new DialerContact(); // DialerContact | Contact
            
            

            try
            {
                
                // Update a contact.
                
                DialerContact result = apiInstance.PutOutboundContactlistContact(contactListId, contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
| **body** | [**DialerContact**](DialerContact.html)| Contact |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="putoutboundcontactlistfilter"></a>

## [**ContactListFilter**](ContactListFilter.html) PutOutboundContactlistfilter (string contactListFilterId, ContactListFilter body)

Update Contact List Filter



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistfilterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID
            
            
            
            
            
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter
            
            

            try
            {
                
                // Update Contact List Filter
                
                ContactListFilter result = apiInstance.PutOutboundContactlistfilter(contactListFilterId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
| **body** | [**ContactListFilter**](ContactListFilter.html)| ContactListFilter |  |
{: class="table table-striped"}

### Return type

[**ContactListFilter**](ContactListFilter.html)

<a name="putoutbounddnclist"></a>

## [**DncList**](DncList.html) PutOutboundDnclist (string dncListId, DncList body)

Update dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundDnclistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var dncListId = dncListId_example;  // string | DncList ID
            
            
            
            
            
            var body = new DncList(); // DncList | DncList
            
            

            try
            {
                
                // Update dialer DNC list
                
                DncList result = apiInstance.PutOutboundDnclist(dncListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundDnclist: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncList**](DncList.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="putoutboundruleset"></a>

## [**RuleSet**](RuleSet.html) PutOutboundRuleset (string ruleSetId, RuleSet body)

Update a RuleSet.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundRulesetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            
            
            
            
            
            var body = new RuleSet(); // RuleSet | RuleSet
            
            

            try
            {
                
                // Update a RuleSet.
                
                RuleSet result = apiInstance.PutOutboundRuleset(ruleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundRuleset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="putoutboundschedulescampaign"></a>

## [**CampaignSchedule**](CampaignSchedule.html) PutOutboundSchedulesCampaign (string campaignId, CampaignSchedule body)

Update a new campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var campaignId = campaignId_example;  // string | Campaign ID
            
            
            
            
            
            var body = new CampaignSchedule(); // CampaignSchedule | CampaignSchedule
            
            

            try
            {
                
                // Update a new campaign schedule.
                
                CampaignSchedule result = apiInstance.PutOutboundSchedulesCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignSchedule**](CampaignSchedule.html)| CampaignSchedule |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="putoutboundschedulessequence"></a>

## [**SequenceSchedule**](SequenceSchedule.html) PutOutboundSchedulesSequence (string sequenceId, SequenceSchedule body)

Update a new sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Sequence ID
            
            
            
            
            
            var body = new SequenceSchedule(); // SequenceSchedule | SequenceSchedule
            
            

            try
            {
                
                // Update a new sequence schedule.
                
                SequenceSchedule result = apiInstance.PutOutboundSchedulesSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
| **body** | [**SequenceSchedule**](SequenceSchedule.html)| SequenceSchedule |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="putoutboundsequence"></a>

## [**CampaignSequence**](CampaignSequence.html) PutOutboundSequence (string sequenceId, CampaignSequence body)

Update a new campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSequenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            
            
            
            
            
            var body = new CampaignSequence(); // CampaignSequence | Organization
            
            

            try
            {
                
                // Update a new campaign sequence.
                
                CampaignSequence result = apiInstance.PutOutboundSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSequence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putoutboundwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) PutOutboundWrapupcodemappings (WrapUpCodeMapping body)

Update the Dialer wrap up code mapping.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundWrapupcodemappingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OutboundApi();
            
            
            
            var body = new WrapUpCodeMapping(); // WrapUpCodeMapping | wrapUpCodeMapping
            
            

            try
            {
                
                // Update the Dialer wrap up code mapping.
                
                WrapUpCodeMapping result = apiInstance.PutOutboundWrapupcodemappings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapUpCodeMapping**](WrapUpCodeMapping.html)| wrapUpCodeMapping |  |
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

