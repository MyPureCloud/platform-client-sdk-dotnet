# Miner

## ININ.PureCloudApi.Model.Miner

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Chat Corpus Name. | |
| **Language** | **string** | Language Localization code. | [optional] |
| **MinerType** | **string** | Type of the miner, intent or topic. | [optional] |
| **DateCreated** | **DateTime?** | Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Status of the miner. | [optional] |
| **ConversationsDateRangeStart** | **String** | Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **ConversationsDateRangeEnd** | **String** | Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateCompleted** | **DateTime?** | Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Message** | **string** | Mining message if present. | [optional] |
| **ErrorInfo** | [**MinerErrorInfo**](MinerErrorInfo) | Error Information | [optional] |
| **WarningInfo** | [**MinerErrorInfo**](MinerErrorInfo) | Warning Information | [optional] |
| **ConversationDataUploaded** | **bool?** | Flag to indicate whether data file to be mined was uploaded. | [optional] |
| **MediaType** | **string** | Media type for filtering conversations. | [optional] |
| **ParticipantType** | **string** | Type of the participant, either agent, customer or both. | [optional] |
| **QueueIds** | **List&lt;string&gt;** | List of queue IDs for filtering conversations. | [optional] |
| **DateTriggered** | **DateTime?** | Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LatestDraftVersion** | [**Draft**](Draft) | Latest draft details of the miner. | [optional] |
| **ConversationsFetchedCount** | **int?** | Number of conversations/transcripts fetched. | [optional] |
| **ConversationsValidCount** | **int?** | Number of conversations/recordings/transcripts that were found valid for mining purposes. | [optional] |
| **GetminedItemCount** | **int?** | Number of intents or topics based on the miner type. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
