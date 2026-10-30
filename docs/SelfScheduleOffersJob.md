# SelfScheduleOffersJob

## ININ.PureCloudApi.Model.SelfScheduleOffersJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Status** | **string** | The status of the job | |
| **DownloadUrl** | **string** | URL from which to fetch results for requests. Populated if status &#x3D;&#x3D; ‘Complete&#39;. The downloaded data will conform to the schema defined in downloadResultTemplate | [optional] |
| **DownloadResultTemplate** | [**SelfScheduleOffersResultTemplate**](SelfScheduleOffersResultTemplate) | Schema template for deserializing lookup offers results returned from the downloadUrl | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
