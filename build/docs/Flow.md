---
title: Flow
---
## ININ.PureCloudApi.Model.Flow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow identifier | [optional] |
| **Name** | **string** | The flow name | |
| **Division** | [**WritableDivision**](WritableDivision.html) | The division to which this entity belongs. | [optional] |
| **Description** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **LockedUser** | [**User**](User.html) | User that has the flow locked. | [optional] |
| **LockedClient** | [**DomainEntityRef**](DomainEntityRef.html) | OAuth client that has the flow locked. | [optional] |
| **Active** | **bool?** |  | [optional] |
| **System** | **bool?** |  | [optional] |
| **Deleted** | **bool?** |  | [optional] |
| **PublishedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **SavedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **InputSchema** | **Object** | json schema describing the inputs for the flow | [optional] |
| **OutputSchema** | **Object** | json schema describing the outputs for the flow | [optional] |
| **CheckedInVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **PublishedBy** | [**User**](User.html) |  | [optional] |
| **CurrentOperation** | [**Operation**](Operation.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


