# Line

## ININ.PureCloudApi.Model.Line

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **EdgeGroup** | [**DomainEntityRef**](DomainEntityRef) | The edge group associated with the line. (Deprecated) | [optional] |
| **Template** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Site** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **LineBaseSettings** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **PrimaryEdge** | [**Edge**](Edge) | The primary edge associated to the line. (Deprecated) | [optional] |
| **SecondaryEdge** | [**Edge**](Edge) | The secondary edge associated to the line. (Deprecated) | [optional] |
| **LoggedInUser** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **DefaultForUser** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
