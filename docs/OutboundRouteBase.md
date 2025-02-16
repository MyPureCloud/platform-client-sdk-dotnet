# OutboundRouteBase

## ININ.PureCloudApi.Model.OutboundRouteBase

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
| **ClassificationTypes** | **List&lt;string&gt;** | The site associated to the outbound route. | |
| **Enabled** | **bool?** |  | [optional] |
| **Distribution** | **string** |  | [optional] |
| **ExternalTrunkBases** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Trunk base settings of trunkType \&quot;EXTERNAL\&quot;.  This base must also be set on an edge logical interface for correct routing. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
