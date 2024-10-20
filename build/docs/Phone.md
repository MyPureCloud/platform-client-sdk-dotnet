# Phone

## ININ.PureCloudApi.Model.Phone

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
| **Site** | [**DomainEntityRef**](DomainEntityRef) | The site associated to the phone. | |
| **PhoneBaseSettings** | [**PhoneBaseSettings**](PhoneBaseSettings) | Phone Base Settings | |
| **LineBaseSettings** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **PhoneMetaBase** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Lines** | [**List&lt;Line&gt;**](Line) | Lines | |
| **Status** | [**PhoneStatus**](PhoneStatus) | The status of the phone and lines from the primary Edge. | [optional] |
| **SecondaryStatus** | [**PhoneStatus**](PhoneStatus) | The status of the phone and lines from the secondary Edge. | [optional] |
| **UserAgentInfo** | [**UserAgentInfo**](UserAgentInfo) | User Agent Information for this phone. This includes model, firmware version, and manufacturer. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Capabilities** | [**PhoneCapabilities**](PhoneCapabilities) |  | [optional] |
| **WebRtcUser** | [**DomainEntityRef**](DomainEntityRef) | This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones. | [optional] |
| **PrimaryEdge** | [**Edge**](Edge) |  | [optional] |
| **SecondaryEdge** | [**Edge**](Edge) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
