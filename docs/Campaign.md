# Campaign

## ININ.PureCloudApi.Model.Campaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Campaign. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | The ContactList for this Campaign to dial. | |
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | The Queue for this Campaign to route calls to. Required for all dialing modes except agentless. | [optional] |
| **DialingMode** | **string** | The strategy this Campaign will use for dialing. | |
| **Script** | [**DomainEntityRef**](DomainEntityRef) | The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless. | [optional] |
| **EdgeGroup** | [**DomainEntityRef**](DomainEntityRef) | The EdgeGroup that will place the calls. Required for all dialing modes except preview. | [optional] |
| **Site** | [**DomainEntityRef**](DomainEntityRef) | The identifier of the site to be used for dialing; can be set in place of an edge group. | [optional] |
| **CampaignStatus** | **string** | The current status of the Campaign. A Campaign may be turned &#39;on&#39; or &#39;off&#39;. Required for updates. | [optional] |
| **PhoneColumns** | [**List&lt;PhoneColumn&gt;**](PhoneColumn) | The ContactPhoneNumberColumns on the ContactList that this Campaign should dial. | |
| **AbandonRate** | **double?** | The targeted compliance abandon rate percentage. Required for power and predictive campaigns. | [optional] |
| **DncLists** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | DncLists for this Campaign to check before placing a call. | [optional] |
| **CallableTimeSet** | [**DomainEntityRef**](DomainEntityRef) | The callable time set for this campaign to check before placing a call. | [optional] |
| **CallAnalysisResponseSet** | [**DomainEntityRef**](DomainEntityRef) | The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview. | [optional] |
| **Errors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail) | A list of current error conditions associated with the campaign. | [optional] |
| **CallerName** | **string** | The caller id name to be displayed on the outbound call. | |
| **CallerAddress** | **string** | The caller id phone number to be displayed on the outbound call. | |
| **OutboundLineCount** | **int?** | The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless. | [optional] |
| **RuleSets** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Rule sets to be applied while this campaign is dialing. | [optional] |
| **SkipPreviewDisabled** | **bool?** | Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns. | [optional] |
| **PreviewTimeOutSeconds** | **long?** | The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns. | [optional] |
| **AlwaysRunning** | **bool?** | Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually. | [optional] |
| **ContactSort** | [**ContactSort**](ContactSort) | The order in which to sort contacts for dialing, based on a column. | [optional] |
| **ContactSorts** | [**List&lt;ContactSort&gt;**](ContactSort) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **NoAnswerTimeout** | **int?** | How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns. | [optional] |
| **CallAnalysisLanguage** | **string** | The language the edge will use to analyze the call. | [optional] |
| **Priority** | **int?** | The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest. | [optional] |
| **ContactListFilters** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied. | [optional] |
| **Division** | [**DomainEntityRef**](DomainEntityRef) | The division this campaign belongs to. | [optional] |
| **AgentOwnedColumn** | **string** | Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns. | [optional] |
| **DynamicContactQueueingSettings** | [**DynamicContactQueueingSettings**](DynamicContactQueueingSettings) | Settings for dynamic queueing of contacts. | [optional] |
| **SkillColumns** | **List&lt;string&gt;** | The skill columns on the ContactList that this Campaign should take into account when dialing | [optional] |
| **MaxCallsPerAgent** | **int?** | The maximum number of calls that can be placed per agent on this campaign | [optional] |
| **MaxCallsPerAgentDecimal** | **double?** | The maximum number of calls that can be placed per agent on this campaign with decimal precision | [optional] |
| **CallbackAutoAnswer** | **bool?** | The option manages the auto-answer callback calls | [optional] |
| **DynamicLineBalancingSettings** | [**DynamicLineBalancingSettings**](DynamicLineBalancingSettings) | Dynamic line balancing settings | [optional] |
| **DiagnosticsSettings** | [**DiagnosticsSettings**](DiagnosticsSettings) | Campaign diagnostics settings | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
