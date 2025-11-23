# TextBotPromptSegment

## ININ.PureCloudApi.Model.TextBotPromptSegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Text** | **string** | The text of this prompt segment. | |
| **Type** | **string** | The segment type which describes any semantics about the &#39;text&#39; and also indicates which other field might include additional relevant info. | |
| **Format** | [**Format**](Format) | Additional details describing the segment’s contents, which the client should honour where possible. | [optional] |
| **Content** | [**List&lt;ConversationMessageContent&gt;**](ConversationMessageContent) | Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;. | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
