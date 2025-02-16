# TestMessage

## ININ.PureCloudApi.Model.TestMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | After the message has been sent, this is the value of the Message-ID email header. | [optional] |
| **To** | [**List&lt;EmailAddress&gt;**](EmailAddress) | The recipients of the email message. | |
| **From** | [**EmailAddress**](EmailAddress) | The sender of the email message. | |
| **Subject** | **string** | The subject of the email message. | [optional] |
| **TextBody** | **string** | The text body of the email message. | |
| **HtmlBody** | **string** | The html body of the email message | [optional] |
| **Time** | **DateTime?** | The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
