# UpdateAlternativeShiftBuSettingsRequest

## ININ.PureCloudApi.Model.UpdateAlternativeShiftBuSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnabledGranularities** | [**ListWrapperAlternativeShiftBuSettingsGranularity**](ListWrapperAlternativeShiftBuSettingsGranularity) | The granularity at which alternative shifts is allowed. An empty list as the wrapped value will indicate alternative shifts is disabled | [optional] |
| **MinMinutesBeforeStartTime** | **int?** | The minimum number of minutes before the start of a shift that an alternative shift can be automatically approved | [optional] |
| **RetainedActivityCategories** | [**ListWrapperAlternativeShiftBuSettingsActivityCategory**](ListWrapperAlternativeShiftBuSettingsActivityCategory) | Categories of activities that are required to remain at the same time slot for the alternative shifts offered. An empty list indicates no retained activities | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this business unit&#39;s alternative shift settings | |



_PureCloudPlatform.Client.V2 236.0.0_
