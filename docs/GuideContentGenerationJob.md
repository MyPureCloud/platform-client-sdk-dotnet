# GuideContentGenerationJob

## ININ.PureCloudApi.Model.GuideContentGenerationJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The status of the job. | [optional] |
| **Errors** | [**List&lt;ErrorBody&gt;**](ErrorBody) | The list of errors in case of job failure. | [optional] |
| **Guide** | [**AddressableEntityRef**](AddressableEntityRef) |  | [optional] |
| **GuideContent** | [**GeneratedGuideContent**](GeneratedGuideContent) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
