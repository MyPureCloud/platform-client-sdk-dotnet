---
title: Line
---
## ININ.PureCloudApi.Model.Line

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
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


