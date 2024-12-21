# ConversationSummary

## ININ.PureCloudApi.Model.ConversationSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Text** | **string** | The text of the summary. | [optional] |
| **Status** | **string** | The status of the conversation summary. | [optional] |
| **MediaType** | **string** | The media type of the conversation. | [optional] |
| **Language** | **string** | The language of the conversation. | [optional] |
| **PredictedWrapupCodes** | [**List&lt;ConversationSummaryWrapupCode&gt;**](ConversationSummaryWrapupCode) | The wrapup codes of the conversation summary. | [optional] |
| **EditedSummary** | [**ConversationEditedSummary**](ConversationEditedSummary) | The edited summary of the conversation. | [optional] |
| **Reason** | [**ConversationSummaryReason**](ConversationSummaryReason) | The reason of the conversation summary. | [optional] |
| **Followup** | [**ConversationSummaryFollowup**](ConversationSummaryFollowup) | The followup of the conversation summary. | [optional] |
| **Resolution** | [**ConversationSummaryResolution**](ConversationSummaryResolution) | The resolution of the conversation summary. | [optional] |
| **DateCreated** | **DateTime?** | The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Id** | **string** | The id of the summary. | [optional] |
| **Confidence** | **float?** | The AI confidence value. | [optional] |
| **Participants** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The list of participants. | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
