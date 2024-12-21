# BuTimeOffLimitValueRange

## ININ.PureCloudApi.Model.BuTimeOffLimitValueRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TimeOffLimit** | [**BuTimeOffLimitReference**](BuTimeOffLimitReference) | The ID of the time-off limit | |
| **StartDate** | **String** | Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists | |
| **Granularity** | **string** | Granularity choice for time-off limit | |
| **LimitMinutesPerInterval** | **List&lt;int?&gt;** | A list of time-off limit values in minutes per granularity interval | |
| **AllocatedMinutesPerInterval** | **List&lt;int?&gt;** | A list of allocated time-off minutes per granularity interval | |
| **WaitlistedMinutesPerInterval** | **List&lt;int?&gt;** | A list of waitlisted time-off minutes per granularity interval | |
| **WaitlistedRequestsPerInterval** | **List&lt;int?&gt;** | The current number of waitlisted time-off requests for every interval per granularity | |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the time-off limit | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
