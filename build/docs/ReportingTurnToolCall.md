# ReportingTurnToolCall

## ININ.PureCloudApi.Model.ReportingTurnToolCall

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ToolId** | **string** | Represents the identifier of the tool called. | [optional] |
| **ToolName** | **string** | Represents the name of the tool used in the event. | [optional] |
| **ToolType** | **string** | Represents the type of tool used in the event. | [optional] |
| **TargetId** | **string** | Represents the identifier of the target that the tool is using. | [optional] |
| **Status** | **string** | Represents whether the tool call was successful or not. | [optional] |
| **ErrorText** | **string** | Represents the error returned by the tool in the event of a failure. | [optional] |
| **DateInvoked** | **DateTime?** | Represents the starting time of the tool call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LatencyMs** | **int?** | Represents the time it took the tool call to execute. | [optional] |
| **Origin** | **string** | Represents the origin of the tool call. | [optional] |
| **KnowledgeMetadata** | [**ReportingTurnKnowledgeMetadata**](ReportingTurnKnowledgeMetadata) | Represents various metadata of knowledge calls used by the tool if the tool is configured to use knowledge. | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
