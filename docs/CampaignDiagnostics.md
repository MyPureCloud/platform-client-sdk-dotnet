# CampaignDiagnostics

## ININ.PureCloudApi.Model.CampaignDiagnostics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CallableContacts** | [**CallableContactsDiagnostic**](CallableContactsDiagnostic) | Campaign properties that can impact which contacts are callable | [optional] |
| **QueueUtilizationDiagnostic** | [**QueueUtilizationDiagnostic**](QueueUtilizationDiagnostic) | Information regarding the campaign&#39;s queue | [optional] |
| **RuleSetDiagnostics** | [**List&lt;RuleSetDiagnostic&gt;**](RuleSetDiagnostic) | Information regarding the campaign&#39;s rule sets | [optional] |
| **OutstandingInteractionsCount** | **int?** | Current number of outstanding interactions on the campaign | [optional] |
| **ScheduledInteractionsCount** | **int?** | Current number of scheduled interactions on the campaign | [optional] |
| **TimeZoneRescheduledCallsCount** | **int?** | Current number of time zone rescheduled calls on the campaign | [optional] |
| **FilteredOutContactsCount** | **int?** | Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on. | [optional] |
| **CampaignSkillStatistics** | [**CampaignSkillStatistics**](CampaignSkillStatistics) | Information regarding the campaign&#39;s skills | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
