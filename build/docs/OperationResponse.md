# OperationResponse

## ININ.PureCloudApi.Model.OperationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | Status of the operation. | [optional] |
| **Type** | **string** | Type of the operation. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the operation. | [optional] |
| **DateCreated** | **DateTime?** | Operation creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Operation last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Source** | [**KnowledgeOperationSource**](KnowledgeOperationSource) | Source of the operation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
