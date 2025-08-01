# ArchitectFlowOutcomeNotificationArchitectOperation

## ININ.PureCloudApi.Model.ArchitectFlowOutcomeNotificationArchitectOperation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique identifier for this operation, as generated by the initiating client | [optional] |
| **Complete** | **bool?** | Indicates if the operation is complete | [optional] |
| **User** | [**ArchitectFlowOutcomeNotificationUser**](ArchitectFlowOutcomeNotificationUser) |  | [optional] |
| **Client** | [**ArchitectFlowOutcomeNotificationClient**](ArchitectFlowOutcomeNotificationClient) |  | [optional] |
| **ActionName** | **string** | The action being performed | [optional] |
| **ActionStatus** | **string** | The action status | [optional] |
| **ErrorMessage** | **string** | The error message, if the action failed | [optional] |
| **ErrorCode** | **string** | The error code, if the action failed | [optional] |
| **ErrorMessageParams** | [**ArchitectFlowOutcomeNotificationErrorMessageParams**](ArchitectFlowOutcomeNotificationErrorMessageParams) |  | [optional] |
| **ErrorDetails** | [**List&lt;ArchitectFlowOutcomeNotificationErrorDetail&gt;**](ArchitectFlowOutcomeNotificationErrorDetail) | The error details, if the action failed | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
