# DialerCampaignConfigChangeCampaign

## ININ.PureCloudApi.Model.DialerCampaignConfigChangeCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactList** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) |  | [optional] |
| **Queue** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **DialingMode** | **string** | dialing mode of the campaign | [optional] |
| **Script** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **EdgeGroup** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **Site** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **CampaignStatus** | **string** |  | [optional] |
| **PhoneColumns** | [**List&lt;DialerCampaignConfigChangePhoneColumn&gt;**](DialerCampaignConfigChangePhoneColumn) | the contact list phone columns to be called for the campaign | [optional] |
| **AbandonRate** | **double?** | the targeted abandon rate percentage | [optional] |
| **DncLists** | [**List&lt;DialerCampaignConfigChangeUriReference&gt;**](DialerCampaignConfigChangeUriReference) | identifiers of the do not call lists | [optional] |
| **CallableTimeSet** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **CallAnalysisResponseSet** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **CallerName** | **string** | caller id name to be displayed on the outbound call | [optional] |
| **CallerAddress** | **string** | caller id phone number to be displayed on the outbound call | [optional] |
| **OutboundLineCount** | **long?** | for agentless campaigns, the number of outbound lines to be concurrently dialed | [optional] |
| **Errors** | [**List&lt;DialerCampaignConfigChangeRestErrorDetail&gt;**](DialerCampaignConfigChangeRestErrorDetail) | a list of current error conditions associated with the campaign | [optional] |
| **RuleSets** | [**List&lt;DialerCampaignConfigChangeUriReference&gt;**](DialerCampaignConfigChangeUriReference) | identifiers of the rule sets | [optional] |
| **SkipPreviewDisabled** | **bool?** | for preview campaigns, indicator of whether the agent can skip a preview without placing a call | [optional] |
| **PreviewTimeOutSeconds** | **long?** | for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls | [optional] |
| **SingleNumberPreview** | **bool?** | for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview | [optional] |
| **ContactSort** | [**DialerCampaignConfigChangeContactSort**](DialerCampaignConfigChangeContactSort) |  | [optional] |
| **ContactSorts** | [**List&lt;DialerCampaignConfigChangeContactSort&gt;**](DialerCampaignConfigChangeContactSort) | List of contact sort objects. | [optional] |
| **NoAnswerTimeout** | **long?** | for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds | [optional] |
| **CallAnalysisLanguage** | **string** | The language the edge will use to analyze the call | [optional] |
| **Priority** | **long?** | The priority of this campaign relative to other campaigns | [optional] |
| **ContactListFilters** | [**List&lt;DialerCampaignConfigChangeUriReference&gt;**](DialerCampaignConfigChangeUriReference) | List of contact filters | [optional] |
| **Division** | [**DialerCampaignConfigChangeUriReference**](DialerCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **AgentOwnedColumn** | **string** | For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to. | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
