# ChecklistInferenceJobResponse

## ININ.PureCloudApi.Model.ChecklistInferenceJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the inference job. | |
| **Status** | **string** | Status of the checklist inference job. | |
| **Error** | [**ErrorInfo**](ErrorInfo) | Error information associated with a job in case of any errors. | [optional] |
| **AgentChecklistInfo** | [**AgentChecklistInfo**](AgentChecklistInfo) | Agent checklist info. | [optional] |
| **JobStartTime** | **DateTime?** | Date when the inference job started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **JobEndTime** | **DateTime?** | Date when the inference job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Language** | **string** | Language associated with the checklist. | [optional] |
| **AgentId** | **string** | Agent ID. | [optional] |
| **ParticipantId** | **string** | Participant ID. | [optional] |
| **QueueId** | **string** | Queue ID. | [optional] |
| **AssistantId** | **string** | Assistant ID. | [optional] |
| **MediaType** | **string** | Media type. | [optional] |
| **Direction** | **string** | Direction of the conversation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
