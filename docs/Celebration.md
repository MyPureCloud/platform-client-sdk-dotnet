# Celebration

## ININ.PureCloudApi.Model.Celebration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Recipient** | [**UserReference**](UserReference) | The Recipient of the celebration | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The creator of the celebration | [optional] |
| **DateCreated** | **DateTime?** | The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Type** | **string** | The Celebration Type | [optional] |
| **Title** | **string** | The Celebration title | [optional] |
| **Note** | **string** | The Celebration note | [optional] |
| **SourceEntity** | [**SourceEntity**](SourceEntity) | The celebration&#39;s source entity | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
