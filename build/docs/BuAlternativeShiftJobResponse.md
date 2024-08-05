---
title: BuAlternativeShiftJobResponse
---
## ININ.PureCloudApi.Model.BuAlternativeShiftJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The status of the alternative shift job | |
| **Type** | **string** | The type of job | |
| **DownloadUrl** | **string** | The URL where completed results are available, only set if status &#x3D;&#x3D; &#39;Complete&#39; | [optional] |
| **Error** | [**ErrorBody**](ErrorBody.html) | Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **ViewOffersResults** | [**AlternativeShiftOffersViewResponseTemplate**](AlternativeShiftOffersViewResponseTemplate.html) | Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListOffers&#39; or &#39;SearchOffers&#39; | [optional] |
| **ViewTradesResults** | [**AlternativeShiftTradesViewResponseTemplate**](AlternativeShiftTradesViewResponseTemplate.html) | Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListUserTrades&#39; or &#39;SearchTrades&#39; | [optional] |
| **BulkUpdateTradesResults** | [**AlternativeShiftBulkUpdateTradesResponseTemplate**](AlternativeShiftBulkUpdateTradesResponseTemplate.html) | Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;BulkUpdateTrades&#39; | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


