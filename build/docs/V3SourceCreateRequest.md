# V3SourceCreateRequest

## ININ.PureCloudApi.Model.V3SourceCreateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the source. | |
| **Type** | **string** | The type of the source. Required if connectionId is not specified, inherits the connection type otherwise. | [optional] |
| **ConnectionId** | **string** | The id of the connection related to the source. Required if type is Sharepoint. | [optional] |
| **TriggerType** | **string** | The trigger type of the source. Default is Manual. | [optional] |
| **ScheduleSettings** | [**V3SourceScheduleSettings**](V3SourceScheduleSettings) | Settings that determine when the source starts a sync. Required if triggerType is Scheduled. | [optional] |
| **Filters** | [**V3SourceFilter**](V3SourceFilter) | Filters that determine what documents are synced. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
