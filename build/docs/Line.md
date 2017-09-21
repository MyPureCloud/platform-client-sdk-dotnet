---
title: Line
---
## ININ.PureCloudApi.Model.Line

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **EdgeGroup** | [**UriReference**](UriReference.html) |  | [optional] |
| **Template** | [**UriReference**](UriReference.html) |  | [optional] |
| **Site** | [**UriReference**](UriReference.html) |  | [optional] |
| **LineBaseSettings** | [**UriReference**](UriReference.html) |  | [optional] |
| **PrimaryEdge** | [**Edge**](Edge.html) | The primary edge associated to the line. (Deprecated) | [optional] |
| **SecondaryEdge** | [**Edge**](Edge.html) | The secondary edge associated to the line. (Deprecated) | [optional] |
| **LoggedInUser** | [**UriReference**](UriReference.html) |  | [optional] |
| **DefaultForUser** | [**UriReference**](UriReference.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


