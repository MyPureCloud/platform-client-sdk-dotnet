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
| **IdleAgents** | **int?** | Information regarding the campaign&#39;s available agents. | [optional] |
| **EffectiveIdleAgents** | **double?** | Information regarding the campaign&#39;s effective available agents. | [optional] |
| **LinesUtilization** | [**CampaignLinesUtilization**](CampaignLinesUtilization) | Information on the campaign&#39;s lines utilization. | [optional] |
| **NumberOfContactsCalled** | **long?** | Number of contacts called during the campaign. | [optional] |
| **TotalNumberOfContacts** | **long?** | Total number of contacts in the campaign. | [optional] |
| **CampaignErrors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail) | A list of current error conditions associated with the campaign. | [optional] |
| **CampaignSkillStatistics** | [**CampaignSkillStatistics**](CampaignSkillStatistics) | Information regarding the campaign&#39;s skills | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
