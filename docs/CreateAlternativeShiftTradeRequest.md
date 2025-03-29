# CreateAlternativeShiftTradeRequest

## ININ.PureCloudApi.Model.CreateAlternativeShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **JobId** | **string** | The ID of this alternative shift job | |
| **DropShiftReferenceKeys** | **List&lt;string&gt;** | A list of offered shift reference keys an agent wants to drop | [optional] |
| **PickupShiftReferenceKeys** | **List&lt;string&gt;** | A list of offered shift reference keys an agent wants to pick up | [optional] |
| **AlternativeShiftTradeGranularity** | **string** | The granularity of alternative shifts to be traded | |
| **ExpirationDate** | **DateTime?** | The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
