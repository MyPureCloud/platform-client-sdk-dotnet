---
title: CampaignDiagnostics
---
## ININ.PureCloudApi.Model.CampaignDiagnostics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CallableContacts** | [**CallableContactsDiagnostic**](CallableContactsDiagnostic.html) | Campaign properties that can impact which contacts are callable | [optional] |
| **QueueUtilizationDiagnostic** | [**QueueUtilizationDiagnostic**](QueueUtilizationDiagnostic.html) | Information regarding the campaign&#39;s queue | [optional] |
| **RuleSetDiagnostics** | [**List&lt;RuleSetDiagnostic&gt;**](RuleSetDiagnostic.html) | Information regarding the campaign&#39;s rule sets | [optional] |
| **OutstandingInteractionsCount** | **int?** | Current number of outstanding interactions on the campaign | [optional] |
| **ScheduledInteractionsCount** | **int?** | Current number of scheduled interactions on the campaign | [optional] |
| **TimeZoneRescheduledCallsCount** | **int?** | Current number of time zone rescheduled calls on the campaign | [optional] |
{: class="table table-striped"}


