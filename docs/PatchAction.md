# PatchAction

## ININ.PureCloudApi.Model.PatchAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaType** | **string** | Media type of action. | |
| **ActionTemplate** | [**ActionMapActionTemplate**](ActionMapActionTemplate) | Action template associated with the action map. | [optional] |
| **ActionTargetId** | **string** | Action target ID. | [optional] |
| **IsPacingEnabled** | **bool?** | Whether this action should be throttled. | [optional] |
| **Props** | [**PatchActionProperties**](PatchActionProperties) | Additional properties. | [optional] |
| **ArchitectFlowFields** | [**ArchitectFlowFields**](ArchitectFlowFields) | Architect Flow Id and input contract. | [optional] |
| **WebMessagingOfferFields** | [**PatchWebMessagingOfferFields**](PatchWebMessagingOfferFields) | Admin-configurable fields of a web messaging offer action. | [optional] |
| **OpenActionFields** | [**OpenActionFields**](OpenActionFields) | Admin-configurable fields of an open action. | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
