# ActionEventRequest

## ININ.PureCloudApi.Model.ActionEventRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **SessionId** | **string** | UUID of the customer session for this action. | |
| **ActionId** | **string** | UUID for the action, as returned by the Ping endpoint when the action was qualified. | |
| **ActionState** | **string** | State the action is transitioning to. | |
| **ErrorCode** | **string** | Client defined error code (when state transitions to errored) | [optional] |
| **ErrorMessage** | **string** | Message of the error returned when the action fails (when state transitions to errored) | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
