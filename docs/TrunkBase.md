# TrunkBase

## ININ.PureCloudApi.Model.TrunkBase

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
| **TrunkMetabase** | [**DomainEntityRef**](DomainEntityRef) | The meta-base this trunk is based on. | |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **TrunkType** | **string** | The type of this trunk base. | |
| **Managed** | **bool?** | Is this trunk being managed remotely. This property is synchronized with the managed property of the Edge Group to which it is assigned. | [optional] |
| **Site** | [**DomainEntityRef**](DomainEntityRef) | Used to determine the media regions for inbound and outbound calls through a trunk. Also determines the dial plan to use for calls that came in on a trunk and have to be sent out on it as well. | [optional] |
| **InboundSite** | [**DomainEntityRef**](DomainEntityRef) | Allows a customer to set the site to which inbound calls will be routed | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
