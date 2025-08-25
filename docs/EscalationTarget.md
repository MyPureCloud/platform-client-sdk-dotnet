# EscalationTarget

## ININ.PureCloudApi.Model.EscalationTarget

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TargetType** | **string** | Defines the target that the message will be escalated to. | |
| **Destination** | **string** | Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source. | |
| **Override** | [**OverrideEscalationTarget**](OverrideEscalationTarget) | Set the integration ID.Only valid when type is OverrideIntegration. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
