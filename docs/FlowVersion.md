# FlowVersion

## ININ.PureCloudApi.Model.FlowVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow version identifier | [optional] |
| **Name** | **string** |  | [optional] |
| **CommitVersion** | **string** |  | [optional] |
| **ConfigurationVersion** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **Secure** | **bool?** |  | [optional] |
| **Debug** | **bool?** |  | [optional] |
| **CreatedBy** | [**User**](User) |  | [optional] |
| **CreatedByClient** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **ConfigurationUri** | **string** |  | [optional] |
| **DateCreated** | **long?** |  | [optional] |
| **DateCheckedIn** | **long?** |  | [optional] |
| **DateSaved** | **long?** |  | [optional] |
| **GenerationId** | **string** |  | [optional] |
| **PublishResultUri** | **string** |  | [optional] |
| **InputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) |  | [optional] |
| **OutputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) |  | [optional] |
| **VirtualAgentEnabled** | **bool?** |  | [optional] |
| **DatePublished** | **DateTime?** | The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublishedEnd** | **DateTime?** | The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NluInfo** | [**NluInfo**](NluInfo) | Information about the natural language understanding configuration for the flow version | [optional] |
| **SupportedLanguages** | [**List&lt;SupportedLanguage&gt;**](SupportedLanguage) | List of supported languages for this version of the flow | [optional] |
| **CompatibleFlowTypes** | **List&lt;string&gt;** | Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
