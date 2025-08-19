# QueueConversationEventTopicFaxStatus

## ININ.PureCloudApi.Model.QueueConversationEventTopicFaxStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Direction** | **string** | The fax direction, either \&quot;send\&quot; or \&quot;receive\&quot;. | [optional] |
| **ExpectedPages** | **long?** | Total number of expected pages, if known. | [optional] |
| **ActivePage** | **long?** | Active page of the transmission. | [optional] |
| **LinesTransmitted** | **long?** | Number of lines that have completed transmission. | [optional] |
| **BytesTransmitted** | **long?** | Number of bytes that have competed transmission. | [optional] |
| **BaudRate** | **long?** | Current signaling rate of transmission, baud rate. | [optional] |
| **PageErrors** | **long?** | Number of page errors. | [optional] |
| **LineErrors** | **long?** | Number of line errors. | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
