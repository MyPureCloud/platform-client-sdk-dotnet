# PatchAction

## ININ.PureCloudApi.Model.PatchAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaType** | **string** | Media type of action. | |
| **ActionTemplate** | [**ActionMapActionTemplate**](ActionMapActionTemplate) | Action template associated with the action map. | [optional] |
| **ActionTargetId** | **string** | Deprecated. Action target ID. | [optional] |
| **IsPacingEnabled** | **bool?** | Deprecated. Whether this action should be throttled. | [optional] |
| **Props** | [**PatchActionProperties**](PatchActionProperties) | Deprecated. Additional properties. | [optional] |
| **ArchitectFlowFields** | [**ArchitectFlowFields**](ArchitectFlowFields) | Architect Flow Id and input contract. | [optional] |
| **WebMessagingOfferFields** | [**PatchWebMessagingOfferFields**](PatchWebMessagingOfferFields) | Admin-configurable fields of a web messaging offer action. | [optional] |
| **OpenActionFields** | [**OpenActionFields**](OpenActionFields) | Admin-configurable fields of an open action. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
