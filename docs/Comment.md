# Comment

## ININ.PureCloudApi.Model.Comment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Content** | **string** | The comment body. | [optional] |
| **User** | [**UserReference**](UserReference) | The User who authored the comment. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The User who last modified the comment. | [optional] |
| **DateCreated** | **DateTime?** | The date the comment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the comment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
