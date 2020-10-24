---
title: EdgeLine
---
## ININ.PureCloudApi.Model.EdgeLine

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **Schema** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Edge** | [**Edge**](Edge.html) |  | [optional] |
| **EdgeGroup** | [**EdgeGroup**](EdgeGroup.html) |  | [optional] |
| **LineType** | **string** |  | [optional] |
| **Endpoint** | [**Endpoint**](Endpoint.html) |  | [optional] |
| **IpAddress** | **string** |  | [optional] |
| **LogicalInterfaceId** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


