# EmailMessageReply

## ININ.PureCloudApi.Model.EmailMessageReply

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **To** | [**List&lt;EmailAddress&gt;**](EmailAddress) | The recipients of the email message. | |
| **Cc** | [**List&lt;EmailAddress&gt;**](EmailAddress) | The recipients that were copied on the email message. | [optional] |
| **Bcc** | [**List&lt;EmailAddress&gt;**](EmailAddress) | The recipients that were blind copied on the email message. | [optional] |
| **From** | [**EmailAddress**](EmailAddress) | The sender of the email message. | |
| **ReplyTo** | [**EmailAddress**](EmailAddress) | The receiver of the reply email message. | [optional] |
| **Subject** | **string** | The subject of the email message. | [optional] |
| **Attachments** | [**List&lt;Attachment&gt;**](Attachment) | The attachments of the email message. | [optional] |
| **TextBody** | **string** | The text body of the email message. | |
| **HtmlBody** | **string** | The html body of the email message. | [optional] |
| **Time** | **DateTime?** | The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **HistoryIncluded** | **bool?** | Indicates whether the history of previous emails of the conversation is included within the email bodies of this message. | [optional] |
| **EmailSizeBytes** | **int?** | Indicates an estimation of the size of the current email as a whole, in its final, ready to be sent form. | [optional] |
| **MaxEmailSizeBytes** | **int?** | Indicates the maximum allowed size for an email to be send via SMTP server, based on the email domain configuration | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
