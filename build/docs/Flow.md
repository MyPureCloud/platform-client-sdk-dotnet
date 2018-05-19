---
title: Flow
---
## ININ.PureCloudApi.Model.Flow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The flow name | |
| **Description** | **string** |  | [optional] |
| **Division** | [**AuthzDivision**](AuthzDivision.html) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **LockedUser** | [**User**](User.html) |  | [optional] |
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


