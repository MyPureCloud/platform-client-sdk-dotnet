# ConversationSummary

## ININ.PureCloudApi.Model.ConversationSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the summary. | [optional] |
| **Text** | **string** | The text of the summary. | [optional] |
| **Confidence** | **float?** | The AI confidence value. | [optional] |
| **Status** | **string** | The status of the conversation summary. | [optional] |
| **MediaType** | **string** | The media type of the conversation. | [optional] |
| **Language** | **string** | The language of the conversation. | [optional] |
| **PredictedWrapupCodes** | [**List&lt;ConversationSummaryWrapupCode&gt;**](ConversationSummaryWrapupCode) | The wrapup codes of the conversation summary. | [optional] |
| **EditedSummary** | [**ConversationEditedInput**](ConversationEditedInput) | The edited summary of the conversation. | [optional] |
| **Reason** | [**ConversationSummaryReason**](ConversationSummaryReason) | The reason of the conversation summary. | [optional] |
| **Followup** | [**ConversationSummaryFollowup**](ConversationSummaryFollowup) | The followup of the conversation summary. | [optional] |
| **Resolution** | [**ConversationSummaryResolution**](ConversationSummaryResolution) | The resolution of the conversation summary. | [optional] |
| **DateCreated** | **DateTime?** | The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LatestCommunication** | [**Entity**](Entity) | The most recent communication whose corresponding content was used for generating the summary. This field will be null if not available. | [optional] |
| **Labels** | [**List&lt;ConversationSummaryLabel&gt;**](ConversationSummaryLabel) | The summary labels. | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | The queue that handled the conversation, if any. | [optional] |
| **TriggerSource** | [**ConversationSummaryTriggerSource**](ConversationSummaryTriggerSource) | The configuration source that triggered summarization. | [optional] |
| **SummarySourceType** | **string** | The service used to generate the summary. | [optional] |
| **TriggerType** | **string** | How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect. | [optional] |
| **LastEditedBy** | [**ConversationSummaryEditedBy**](ConversationSummaryEditedBy) | The user that last edited the summary, if the summary was edited. | [optional] |
| **Participants** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The list of participants. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
