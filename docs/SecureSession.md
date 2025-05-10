# SecureSession

## ININ.PureCloudApi.Model.SecureSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Flow** | [**DomainEntityRef**](DomainEntityRef) | The flow to execute securely | |
| **UserData** | **string** | Customer-provided data | [optional] |
| **State** | **string** | The current state of a secure session | |
| **SourceParticipantId** | **string** | Unique identifier for the participant initiating the secure session. | [optional] |
| **Disconnect** | **bool?** | If true, disconnect the agent after creating the session | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
