# EmailCommunicationDispositionAppliedEvent

## ININ.PureCloudApi.Model.EmailCommunicationDispositionAppliedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **Code** | **string** | The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped. | [optional] |
| **Notes** | **string** | Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped. | [optional] |
| **Tags** | **List&lt;string&gt;** | The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped. | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
