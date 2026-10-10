# BuAdherenceAdjustmentsQueryJob

## ININ.PureCloudApi.Model.BuAdherenceAdjustmentsQueryJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Status** | **string** | The status of the adherence adjustments query job | [optional] |
| **DownloadUrl** | **string** | A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39; | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Error details if status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **Result** | [**AdherenceAdjustmentsListing**](AdherenceAdjustmentsListing) | Schema template for deserializing data returned from the downloadUrl. Will always be null on the response | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
