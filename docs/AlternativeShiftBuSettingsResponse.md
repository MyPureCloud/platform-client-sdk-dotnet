# AlternativeShiftBuSettingsResponse

## ININ.PureCloudApi.Model.AlternativeShiftBuSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnabledGranularities** | **List&lt;string&gt;** | The granularity at which alternative shifts is allowed. An empty list means Alternative Shifts is disabled | |
| **MinMinutesBeforeStartTime** | **int?** | The minimum number of minutes before the start of a shift that an alternative shift can be automatically approved | |
| **RetainedActivityCategories** | **List&lt;string&gt;** | Categories of activities that are required to remain at the same time slot for the alternative shifts offered. An empty list represents no retained activities | |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this business unit&#39;s alternative shift settings | |



_PureCloudPlatform.Client.V2 221.0.0_
