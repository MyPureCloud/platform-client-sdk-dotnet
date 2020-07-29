---
title: HistoricalAdherenceExceptionInfo
---
## ININ.PureCloudApi.Model.HistoricalAdherenceExceptionInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartOffsetSeconds** | **int?** | Exception start offset in seconds relative to query start time | [optional] |
| **EndOffsetSeconds** | **int?** | Exception end offset in seconds relative to query start time | [optional] |
| **ScheduledActivityCodeId** | **string** | The ID of the scheduled activity for this user | [optional] |
| **ScheduledActivityCategory** | **string** | Activity for which the user is scheduled | [optional] |
| **ActualActivityCategory** | **string** | Activity for which the user is actually engaged | [optional] |
| **SystemPresence** | **string** | Actual underlying system presence value | [optional] |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus.html) | Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue | [optional] |
| **Impact** | **string** | The impact of the current adherence state for this user | [optional] |
| **SecondaryPresenceLookupId** | **string** | The lookup ID used to retrieve secondary status from map of lookup ID to corresponding secondary presence ID | [optional] |
{: class="table table-striped"}


