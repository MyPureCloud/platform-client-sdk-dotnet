# CampaignStats

## ININ.PureCloudApi.Model.CampaignStats

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactRate** | [**ConnectRate**](ConnectRate) | Information regarding the campaign&#39;s connect rate | [optional] |
| **IdleAgents** | **int?** | Number of available agents not currently being utilized | [optional] |
| **EffectiveIdleAgents** | **double?** | Number of effective available agents not currently being utilized | [optional] |
| **AdjustedCallsPerAgent** | **double?** | Calls per agent adjusted by pace | [optional] |
| **OutstandingCalls** | **int?** | Number of campaign calls currently ongoing | [optional] |
| **ScheduledCalls** | **int?** | Number of campaign calls currently scheduled | [optional] |
| **TimeZoneRescheduledCalls** | **int?** | Number of campaign calls currently timezone rescheduled | [optional] |
| **FilteredOutContactsCount** | **int?** | Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on. | [optional] |
| **RightPartyContactsCount** | **int?** | Information on the campaign&#39;s number of Right Party Contacts | [optional] |
| **ValidAttempts** | **int?** | Information on the campaign&#39;s valid attempts | [optional] |
| **LinesUtilization** | [**CampaignLinesUtilization**](CampaignLinesUtilization) | Information on the campaign&#39;s lines utilization | [optional] |
| **BusinessCategoryMetrics** | [**CampaignBusinessCategoryMetrics**](CampaignBusinessCategoryMetrics) | Information on the campaign&#39;s business category metrics | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
