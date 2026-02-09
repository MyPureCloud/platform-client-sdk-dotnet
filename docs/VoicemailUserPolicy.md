# VoicemailUserPolicy

## ININ.PureCloudApi.Model.VoicemailUserPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether the user has voicemail enabled | [optional] |
| **AlertTimeoutSeconds** | **int?** | The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail | [optional] |
| **Pin** | **string** | The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security | [optional] |
| **ModifiedDate** | **DateTime?** | The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SendEmailNotifications** | **bool?** | Whether email notifications are sent to the user when a new voicemail is received | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
