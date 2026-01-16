# Flow

## ININ.PureCloudApi.Model.Flow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow identifier | [optional] |
| **Name** | **string** | The flow name | |
| **Division** | [**WritableDivision**](WritableDivision) | The division to which this entity belongs. | [optional] |
| **Description** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **LockedUser** | [**User**](User) | User that has the flow locked. | [optional] |
| **LockedClient** | [**DomainEntityRef**](DomainEntityRef) | OAuth client that has the flow locked. | [optional] |
| **Active** | **bool?** |  | [optional] |
| **System** | **bool?** |  | [optional] |
| **Deleted** | **bool?** |  | [optional] |
| **PublishedVersion** | [**FlowVersion**](FlowVersion) |  | [optional] |
| **SavedVersion** | [**FlowVersion**](FlowVersion) |  | [optional] |
| **InputSchema** | **Object** | json schema describing the inputs for the flow | [optional] |
| **OutputSchema** | **Object** | json schema describing the outputs for the flow | [optional] |
| **CheckedInVersion** | [**FlowVersion**](FlowVersion) |  | [optional] |
| **DebugVersion** | [**FlowVersion**](FlowVersion) |  | [optional] |
| **PublishedBy** | [**User**](User) |  | [optional] |
| **CurrentOperation** | [**Operation**](Operation) |  | [optional] |
| **NluInfo** | [**NluInfo**](NluInfo) | Information about the natural language understanding configuration for the published version of the flow | [optional] |
| **SupportedLanguages** | [**List&lt;SupportedLanguage&gt;**](SupportedLanguage) | List of supported languages for the published version of the flow. | [optional] |
| **CompatibleFlowTypes** | **List&lt;string&gt;** | Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action. | [optional] |
| **WorktypeId** | **string** |  | [optional] |
| **VirtualAgentEnabled** | **bool?** | Indicates whether virtual agent is enabled for this flow. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
