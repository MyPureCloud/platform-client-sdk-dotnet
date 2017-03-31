---
title: Campaign
---
## ININ.PureCloudApi.Model.Campaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) | identifier of the contact list for the campaign | |
| **Queue** | [**UriReference**](UriReference.html) | identifier of the agent assignment queue, required for all dialing modes other than agentless | |
| **DialingMode** | **string** | dialing mode of the campaign | |
| **Script** | [**UriReference**](UriReference.html) | identifier of the campaign script, required for all dialing modes other than agentless | |
| **EdgeGroup** | [**UriReference**](UriReference.html) | identifier of the edge group, required for all dialing modes other than preview | |
| **CampaignStatus** | **string** | status of the campaign; can be set to &#39;on&#39; or &#39;off&#39; | |
| **PhoneColumns** | [**List&lt;PhoneColumn&gt;**](PhoneColumn.html) | the contact list phone columns to be called for the campaign | |
| **AbandonRate** | **double?** | the targeted abandon rate percentage | [optional] |
| **DncLists** | [**List&lt;UriReference&gt;**](UriReference.html) | identifiers of the do not call lists | [optional] |
| **CallableTimeSet** | [**UriReference**](UriReference.html) | the identifier of the callable time set | [optional] |
| **CallAnalysisResponseSet** | [**UriReference**](UriReference.html) | the identifier of the call analysis response set, required for all dialing modes other than preview | |
| **Errors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail.html) | a list of current error conditions associated with the campaign | [optional] |
| **CallerName** | **string** | caller id name to be displayed on the outbound call | [optional] |
| **CallerAddress** | **string** | caller id phone number to be displayed on the outbound call | [optional] |
| **OutboundLineCount** | **int?** | for agentless campaigns, the number of outbound lines to be concurrently dialed | [optional] |
| **RuleSets** | [**List&lt;UriReference&gt;**](UriReference.html) | identifiers of the rule sets | [optional] |
| **SkipPreviewDisabled** | **bool?** | for preview campaigns, indicator of whether the agent can skip a preview without placing a call | [optional] |
| **PreviewTimeOutSeconds** | **long?** | for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls | [optional] |
| **ContactSort** | [**ContactSort**](ContactSort.html) | information determining the order in which the contacts will be dialed | [optional] |
| **ContactSorts** | [**List&lt;ContactSort&gt;**](ContactSort.html) | column prioritized information determining the order in which the contacts will be dialed | [optional] |
| **NoAnswerTimeout** | **int?** | for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds | [optional] |
| **CallAnalysisLanguage** | **string** | The language the edge will use to analyse the call | [optional] |
| **Priority** | **int?** | The priority of this campaign relative to other campaigns | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


