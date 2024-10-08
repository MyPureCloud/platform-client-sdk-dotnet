# AdherenceSettings

## ININ.PureCloudApi.Model.AdherenceSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SevereAlertThresholdMinutes** | **int?** | The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence | [optional] |
| **AdherenceTargetPercent** | **int?** | Target adherence percentage | [optional] |
| **AdherenceExceptionThresholdSeconds** | **int?** | The threshold in seconds for which agents should not be penalized for being momentarily out of adherence | [optional] |
| **NonOnQueueActivitiesEquivalent** | **bool?** | Whether to treat all non-on-queue activities as equivalent for adherence purposes | [optional] |
| **TrackOnQueueActivity** | **bool?** | Whether to track on-queue activities | [optional] |
| **IgnoredActivityCategories** | [**IgnoredActivityCategories**](IgnoredActivityCategories) | Activity categories that should be ignored for adherence purposes | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
