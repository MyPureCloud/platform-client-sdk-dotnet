# TimeOffLimitValueRange

## ININ.PureCloudApi.Model.TimeOffLimitValueRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffLimit** | [**TimeOffLimitReference**](TimeOffLimitReference) | The ID of the time off limit | [optional] |
| **StartDate** | **String** | Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists | |
| **Granularity** | **string** | Granularity choice for time off limit | |
| **LimitMinutesPerInterval** | **List&lt;int?&gt;** | A list of time off limit values in minutes per granularity interval | [optional] |
| **AllocatedMinutesPerInterval** | **List&lt;int?&gt;** | A list of allocated time off minutes per granularity interval | [optional] |
| **WaitlistedMinutesPerInterval** | **List&lt;int?&gt;** | A list of waitlisted time off minutes per granularity interval | [optional] |
| **WaitlistedRequestsPerInterval** | **List&lt;int?&gt;** | The current number of waitlisted time off requests for every interval per granularity | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the time off limit | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
