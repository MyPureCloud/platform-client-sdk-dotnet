# SupportedContent

## ININ.PureCloudApi.Model.SupportedContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique supported content Id. | |
| **Name** | **string** | The name of the supported content profile | |
| **DateCreated** | **DateTime?** | Date this supported content profile was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this supported content profile was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this supported content profile | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that modified this supported content profile | [optional] |
| **Version** | **int?** | Version number | [optional] |
| **MediaTypes** | [**MediaTypes**](MediaTypes) | Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*_/_*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/_*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } } | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
