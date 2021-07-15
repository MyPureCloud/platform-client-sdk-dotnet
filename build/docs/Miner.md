---
title: Miner
---
## ININ.PureCloudApi.Model.Miner

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Chat Corpus Name. | |
| **Language** | **string** | Language Localization code. | [optional] |
| **DateCreated** | **DateTime?** | Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Status of the miner. | [optional] |
| **ConversationsDateRangeStart** | **String** | Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **ConversationsDateRangeEnd** | **String** | Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateCompleted** | **DateTime?** | Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Message** | **string** | Mining message if present. | [optional] |
| **ConversationDataUploaded** | **bool?** | Flag to indicate whether data file to be mined was uploaded. | [optional] |
| **MediaType** | **string** | Media type for filtering conversations. | [optional] |
| **QueueIds** | **List&lt;string&gt;** | List of queue IDs for filtering conversations. | [optional] |
| **DateTriggered** | **DateTime?** | Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LatestDraftVersion** | [**Draft**](Draft.html) | Latest draft details of the miner. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


