# RecognitionBase

## ININ.PureCloudApi.Model.RecognitionBase

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Recipient** | [**UserReference**](UserReference) | The recipient of the recognition | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The creator of the recognition | [optional] |
| **DateCreated** | **DateTime?** | The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Type** | **string** | The type of recognition | [optional] |
| **Title** | **string** | The recognition title | [optional] |
| **Note** | **string** | The recognition note | [optional] |
| **ContextType** | **string** | The context type (optional) | [optional] |
| **ContextId** | **string** | The context id (optional) | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
