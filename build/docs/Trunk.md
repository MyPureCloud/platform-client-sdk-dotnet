---
title: Trunk
---
## ININ.PureCloudApi.Model.Trunk

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
| **TrunkType** | **string** | The type of this trunk. | [optional] |
| **Edge** | [**UriReference**](UriReference.html) | The Edge using this trunk. | [optional] |
| **TrunkBase** | [**UriReference**](UriReference.html) | The trunk base configuration used on this trunk. | [optional] |
| **TrunkMetabase** | [**UriReference**](UriReference.html) | The metabase used to create this trunk. | [optional] |
| **EdgeGroup** | [**UriReference**](UriReference.html) | The edge group associated with this trunk. | [optional] |
| **InService** | **bool?** | True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base. | [optional] |
| **Enabled** | **bool?** | True if the Edge used by this trunk is in-service | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


