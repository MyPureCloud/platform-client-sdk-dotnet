# RecordingEmailMessage

## ININ.PureCloudApi.Model.RecordingEmailMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **HtmlBody** | **string** |  | [optional] |
| **TextBody** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **To** | [**List&lt;EmailAddress&gt;**](EmailAddress) |  | [optional] |
| **Cc** | [**List&lt;EmailAddress&gt;**](EmailAddress) |  | [optional] |
| **Bcc** | [**List&lt;EmailAddress&gt;**](EmailAddress) |  | [optional] |
| **From** | [**EmailAddress**](EmailAddress) |  | [optional] |
| **Subject** | **string** |  | [optional] |
| **Attachments** | [**List&lt;EmailAttachment&gt;**](EmailAttachment) |  | [optional] |
| **Time** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
