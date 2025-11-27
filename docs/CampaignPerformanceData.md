# CampaignPerformanceData

## ININ.PureCloudApi.Model.CampaignPerformanceData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaign** | [**DomainEntityRef**](DomainEntityRef) | Identifier of the campaign | |
| **Division** | [**AddressableEntityRef**](AddressableEntityRef) | The division the campaign belongs to | [optional] |
| **ContactRate** | [**CampaignPerformanceDataContactRate**](CampaignPerformanceDataContactRate) | Information regarding the campaign&#39;s connect rate | [optional] |
| **IdleAgents** | **int?** | Number of available agents not currently being utilized | [optional] |
| **EffectiveIdleAgents** | **double?** | Number of effective available agents not currently being utilized | [optional] |
| **AdjustedCallsPerAgent** | **double?** | Calls per agent adjusted by pace | [optional] |
| **OutstandingCalls** | **int?** | Number of campaign calls currently ongoing | [optional] |
| **ScheduledCalls** | **int?** | Number of campaign calls currently scheduled | [optional] |
| **RightPartyContactsCount** | **int?** | Information on the campaign&#39;s number of Right Party Contacts | [optional] |
| **CampaignStatus** | **string** | The status of the campaign | [optional] |
| **DialingMode** | **string** | The strategy this Campaign will use for dialing | [optional] |
| **Progress** | [**CampaignPerformanceDataProgress**](CampaignPerformanceDataProgress) | Information on the campaign&#39;s progress | [optional] |
| **LinesUtilization** | [**CampaignLinesUtilization**](CampaignLinesUtilization) | Information on the campaign&#39;s lines utilization | [optional] |
| **BusinessCategoryMetrics** | [**CampaignBusinessCategoryMetrics**](CampaignBusinessCategoryMetrics) | Information on the campaign&#39;s business category metrics | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
