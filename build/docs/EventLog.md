---
title: EventLog
---
## ININ.PureCloudApi.Model.EventLog

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ErrorEntity** | [**UriReference**](UriReference.html) |  | [optional] |
| **RelatedEntity** | [**UriReference**](UriReference.html) |  | [optional] |
| **Timestamp** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Level** | **string** |  | [optional] |
| **Category** | **string** |  | [optional] |
| **CorrelationId** | **string** |  | [optional] |
| **EventMessage** | [**EventMessage**](EventMessage.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


