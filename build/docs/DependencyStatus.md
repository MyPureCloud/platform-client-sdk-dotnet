# DependencyStatus

## ININ.PureCloudApi.Model.DependencyStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User) | User that initiated the build. | [optional] |
| **Client** | [**DomainEntityRef**](DomainEntityRef) | OAuth client that initiated the build. | [optional] |
| **BuildId** | **string** |  | [optional] |
| **DateStarted** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** |  | [optional] |
| **FailedObjects** | [**List&lt;FailedObject&gt;**](FailedObject) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
