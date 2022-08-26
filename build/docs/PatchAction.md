---
title: PatchAction
---
## ININ.PureCloudApi.Model.PatchAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaType** | **string** | Media type of action. | |
| **ActionTemplate** | [**ActionMapActionTemplate**](ActionMapActionTemplate.html) | Action template associated with the action map. | [optional] |
| **ActionTargetId** | **string** | Action target ID. | [optional] |
| **IsPacingEnabled** | **bool?** | Whether this action should be throttled. | [optional] |
| **Props** | [**PatchActionProperties**](PatchActionProperties.html) | Additional properties. | [optional] |
| **ArchitectFlowFields** | [**ArchitectFlowFields**](ArchitectFlowFields.html) | Architect Flow Id and input contract. | [optional] |
| **WebMessagingOfferFields** | [**PatchWebMessagingOfferFields**](PatchWebMessagingOfferFields.html) | Admin-configurable fields of a web messaging offer action. | [optional] |
| **OpenActionFields** | [**OpenActionFields**](OpenActionFields.html) | Admin-configurable fields of an open action. | [optional] |
{: class="table table-striped"}


