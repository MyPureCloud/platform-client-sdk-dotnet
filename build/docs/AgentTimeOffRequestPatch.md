# AgentTimeOffRequestPatch

## ININ.PureCloudApi.Model.AgentTimeOffRequestPatch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MarkedAsRead** | **bool?** | Whether this request has been read by the agent | [optional] |
| **Status** | **string** | The status of this time off request. Can only be canceled if the requested date has not already passed | [optional] |
| **Notes** | **string** | Notes about the time off request. Can only be edited while the request is still pending | [optional] |
| **FullDayEarliestStartOffsetMinutes** | [**ListWrapperInteger**](ListWrapperInteger) | Earliest start offset in minutes for each full-day request date. Values may be null when time-off estimation is disabled or no estimate is available | [optional] |
| **FullDayLatestEndOffsetMinutes** | [**ListWrapperInteger**](ListWrapperInteger) | Latest end offset in minutes for each full-day request date. Values may be null when time-off estimation is disabled or no estimate is available | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
