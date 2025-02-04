# IvrEstablishedEvent

## ININ.PureCloudApi.Model.IvrEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **IvrPhoneNumber** | **string** | The phone number for this IVR, if any is known | [optional] |
| **IvrName** | **string** | A displayable name for this IVR, if any is known. | [optional] |
| **Ani** | **string** | The automatic number identification if it is available for this conversation. | [optional] |
| **Dnis** | **string** | The dialed number identification if it is available for this conversation. | [optional] |
| **InitialConfiguration** | [**InitialConfiguration**](InitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 226.0.0_
