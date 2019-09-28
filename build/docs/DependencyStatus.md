---
title: DependencyStatus
---
## ININ.PureCloudApi.Model.DependencyStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User.html) | User that initiated the build. | [optional] |
| **Client** | [**DomainEntityRef**](DomainEntityRef.html) | OAuth client that initiated the build. | [optional] |
| **BuildId** | **string** |  | [optional] |
| **DateStarted** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateCompleted** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Status** | **string** |  | [optional] |
| **FailedObjects** | [**List&lt;FailedObject&gt;**](FailedObject.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


