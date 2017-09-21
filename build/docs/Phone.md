---
title: Phone
---
## ININ.PureCloudApi.Model.Phone

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
| **Site** | [**UriReference**](UriReference.html) | The site associated to the phone. | |
| **PhoneBaseSettings** | [**UriReference**](UriReference.html) | Phone Base Settings | |
| **LineBaseSettings** | [**UriReference**](UriReference.html) |  | [optional] |
| **PhoneMetaBase** | [**UriReference**](UriReference.html) |  | [optional] |
| **Lines** | [**List&lt;Line&gt;**](Line.html) | Lines | |
| **Status** | [**PhoneStatus**](PhoneStatus.html) | The status of the phone and lines from the primary Edge. | [optional] |
| **SecondaryStatus** | [**PhoneStatus**](PhoneStatus.html) | The status of the phone and lines from the secondary Edge. | [optional] |
| **UserAgentInfo** | [**UserAgentInfo**](UserAgentInfo.html) | User Agent Information for this phone. This includes model, firmware version, and manufacturer. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Capabilities** | [**PhoneCapabilities**](PhoneCapabilities.html) |  | [optional] |
| **WebRtcUser** | [**UriReference**](UriReference.html) | This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones. | [optional] |
| **PrimaryEdge** | [**Edge**](Edge.html) |  | [optional] |
| **SecondaryEdge** | [**Edge**](Edge.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


