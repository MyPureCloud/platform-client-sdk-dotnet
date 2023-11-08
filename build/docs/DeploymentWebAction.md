---
title: DeploymentWebAction
---
## ININ.PureCloudApi.Model.DeploymentWebAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | System-generated UUID for the action. | |
| **MediaType** | **string** | Action media type used to deliver the action. | |
| **CustomerId** | **string** | ID string of the customer that the action was triggered for. | [optional] |
| **CustomerIdType** | **string** | Type of the customer ID that the action was triggered for. | [optional] |
| **ActionMapId** | **string** | ID of the action map that triggered the action. | |
| **ActionMapVersion** | **int?** | Version of the action map that triggered the action. | |
| **SessionId** | **string** | ID of the session that the action was triggered for. | |
| **WebMessagingOfferProperties** | [**WebMessagingOfferProperties**](WebMessagingOfferProperties.html) | Web messaging offer specific properties. | [optional] |
| **ContentOfferProperties** | [**ContentOffer**](ContentOffer.html) | Content offer specific properties. | [optional] |
| **OpenActionProperties** | [**OpenActionProperties**](OpenActionProperties.html) | Open action specific properties. | [optional] |
{: class="table table-striped"}


