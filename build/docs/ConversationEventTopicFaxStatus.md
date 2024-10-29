# ConversationEventTopicFaxStatus

## ININ.PureCloudApi.Model.ConversationEventTopicFaxStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Direction** | **string** | The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;. | [optional] |
| **ExpectedPages** | **int?** | Total number of expected pages, if known. | [optional] |
| **ActivePage** | **int?** | Active page of the transmission. | [optional] |
| **LinesTransmitted** | **int?** | Number of lines that have completed transmission. | [optional] |
| **BytesTransmitted** | **int?** | Number of bytes that have competed transmission. | [optional] |
| **BaudRate** | **int?** | Current signaling rate of transmission, baud rate. | [optional] |
| **PageErrors** | **int?** | Number of page errors. | [optional] |
| **LineErrors** | **int?** | Number of line errors. | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
