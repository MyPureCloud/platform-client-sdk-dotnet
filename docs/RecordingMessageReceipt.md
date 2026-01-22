# RecordingMessageReceipt

## ININ.PureCloudApi.Model.RecordingMessageReceipt

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the message receipt. Message receipts will have the same ID as the message they reference. | [optional] |
| **ReceiptTime** | **DateTime?** | Original time of the event (receipt). Example: delivery receipt time, read receipt time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The message receipt status | [optional] |
| **Reasons** | [**List&lt;RecordingMessageReceiptReason&gt;**](RecordingMessageReceiptReason) | List of reasons for a message receipt that indicates the message has failed. Only used with Failed status. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
