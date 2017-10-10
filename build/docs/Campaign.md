---
title: Campaign
---
## ININ.PureCloudApi.Model.Campaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Campaign. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) | The ContactList for this Campaign to dial. | |
| **Queue** | [**UriReference**](UriReference.html) | The Queue for this Campaign to route calls to. Required for all dialing modes except agentless. | [optional] |
| **DialingMode** | **string** | The strategy this Campaign will use for dialing. | |
| **Script** | [**UriReference**](UriReference.html) | The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless. | [optional] |
| **EdgeGroup** | [**UriReference**](UriReference.html) | The EdgeGroup that will place the calls. Required for all dialing modes except preview. | [optional] |
| **CampaignStatus** | **string** | The current status of the Campaign. A Campaign may be turned &#39;on&#39; or &#39;off&#39;. Required for updates. | [optional] |
| **PhoneColumns** | [**List&lt;PhoneColumn&gt;**](PhoneColumn.html) | The ContactPhoneNumberColumns on the ContactList that this Campaign should dial. | |
| **AbandonRate** | **double?** | The targeted abandon rate percentage. Required for progressive, power, and predictive campaigns. | [optional] |
| **DncLists** | [**List&lt;UriReference&gt;**](UriReference.html) | DncLists for this Campaign to check before placing a call. | [optional] |
| **CallableTimeSet** | [**UriReference**](UriReference.html) | The callable time set for this campaign to check before placing a call. | [optional] |
| **CallAnalysisResponseSet** | [**UriReference**](UriReference.html) | The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview. | [optional] |
| **Errors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail.html) | A list of current error conditions associated with the campaign. | [optional] |
| **CallerName** | **string** | The caller id name to be displayed on the outbound call. | |
| **CallerAddress** | **string** | The caller id phone number to be displayed on the outbound call. | |
| **OutboundLineCount** | **int?** | The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless. | [optional] |
| **RuleSets** | [**List&lt;UriReference&gt;**](UriReference.html) | Rule sets to be applied while this campaign is dialing. | [optional] |
| **SkipPreviewDisabled** | **bool?** | Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns. | [optional] |
| **PreviewTimeOutSeconds** | **long?** | The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns. | [optional] |
| **AlwaysRunning** | **bool?** | Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually. | [optional] |
| **ContactSort** | [**ContactSort**](ContactSort.html) | The order in which to sort contacts for dialing, based on a column. | [optional] |
| **ContactSorts** | [**List&lt;ContactSort&gt;**](ContactSort.html) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **NoAnswerTimeout** | **int?** | How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns. | [optional] |
| **CallAnalysisLanguage** | **string** | The language the edge will use to analyze the call. | [optional] |
| **Priority** | **int?** | The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest. | [optional] |
| **ContactListFilters** | [**List&lt;UriReference&gt;**](UriReference.html) | Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


