# BuRescheduleAgentScheduleResult

## ININ.PureCloudApi.Model.BuRescheduleAgentScheduleResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which this part of the result applies | [optional] |
| **DownloadResult** | [**MuRescheduleResultWrapper**](MuRescheduleResultWrapper) | The agent schedules.  Result will always come via the downloadUrl; however the schema is included for documentation | [optional] |
| **DownloadUrl** | **string** | The download URL from which to fetch the result | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
