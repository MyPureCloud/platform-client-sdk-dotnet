# ResponseAsset

## ININ.PureCloudApi.Model.ResponseAsset

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **ContentLength** | **long?** | response asset size in bytes | [optional] |
| **ContentLocation** | **string** | response asset location. | [optional] |
| **ContentType** | **string** | MIME type of response asset | [optional] |
| **DateCreated** | **DateTime?** | Created date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User who created the response asset | [optional] |
| **DateModified** | **DateTime?** | Last modified date of the response asset. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User who last modified the response asset | [optional] |
| **Responses** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Canned responses actively using this asset | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
