# Extension

## ININ.PureCloudApi.Model.Extension

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
| **Number** | **string** |  | [optional] |
| **Owner** | [**DomainEntityRef**](DomainEntityRef) | A Uri reference to the owner of this extension, which is either a User or an IVR | [optional] |
| **ExtensionPool** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **OwnerType** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
