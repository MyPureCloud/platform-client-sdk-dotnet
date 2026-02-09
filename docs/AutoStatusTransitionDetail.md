# AutoStatusTransitionDetail

## ININ.PureCloudApi.Model.AutoStatusTransitionDetail

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **NextStatus** | [**WorkitemStatusReference**](WorkitemStatusReference) | Next status of auto status transition. | [optional] |
| **DateOfTransition** | **DateTime?** | Date at which auto status transition occurs. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ErrorDetails** | [**TaskManagementErrorDetails**](TaskManagementErrorDetails) | This property will be set if auto status transition is failed. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
