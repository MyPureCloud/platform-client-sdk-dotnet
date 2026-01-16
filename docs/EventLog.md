# EventLog

## ININ.PureCloudApi.Model.EventLog

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ErrorEntity** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **RelatedEntity** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Timestamp** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Level** | **string** |  | [optional] |
| **Category** | **string** |  | [optional] |
| **CorrelationId** | **string** |  | [optional] |
| **EventMessage** | [**EventMessage**](EventMessage) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
