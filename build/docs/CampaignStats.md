---
title: CampaignStats
---
## ININ.PureCloudApi.Model.CampaignStats

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactRate** | [**ConnectRate**](ConnectRate.html) | Information regarding the campaign&#39;s connect rate | [optional] |
| **IdleAgents** | **int?** | Number of available agents not currently being utilized | [optional] |
| **EffectiveIdleAgents** | **double?** | Number of effective available agents not currently being utilized | [optional] |
| **AdjustedCallsPerAgent** | **double?** | Calls per agent adjusted by pace | [optional] |
| **OutstandingCalls** | **int?** | Number of campaign calls currently ongoing | [optional] |
| **ScheduledCalls** | **int?** | Number of campaign calls currently scheduled | [optional] |
| **TimeZoneRescheduledCalls** | **int?** | Number of campaign calls currently timezone rescheduled | [optional] |
| **LinesUtilization** | [**CampaignLinesUtilization**](CampaignLinesUtilization.html) | Information on the campaign&#39;s lines utilization | [optional] |
{: class="table table-striped"}


