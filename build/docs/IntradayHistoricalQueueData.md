---
title: IntradayHistoricalQueueData
---
## ININ.PureCloudApi.Model.IntradayHistoricalQueueData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Offered** | **int?** | The number of interactions routed into the queue for the given media type(s) for an agent to answer | [optional] |
| **Completed** | **int?** | The number of interactions completed | [optional] |
| **Answered** | **int?** | The number of interactions answered by an agent in a given period | [optional] |
| **Abandoned** | **int?** | The number of customers who disconnect before connecting with an agent | [optional] |
| **AverageTalkTimeSeconds** | **double?** | The average time in seconds an agent spends interacting with a customer per talk segment for a defined period of time | [optional] |
| **AverageAfterCallWorkSeconds** | **double?** | The average time in seconds spent in after-call work. After-call work is the work that an agent performs immediately following an interaction | [optional] |
| **ServiceLevelPercent** | **double?** | Percent of interactions answered in X seconds, where X is the service level objective configured in the service goal group matching this intraday group | [optional] |
| **AverageSpeedOfAnswerSeconds** | **double?** | The average time in seconds it takes to answer an interaction once the interaction becomes available to be routed | [optional] |
{: class="table table-striped"}


