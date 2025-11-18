# VoicemailOrganizationPolicy

## ININ.PureCloudApi.Model.VoicemailOrganizationPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether voicemail is enabled for this organization | [optional] |
| **AlertTimeoutSeconds** | **int?** | The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transferred to voicemail | [optional] |
| **PinConfiguration** | [**PINConfiguration**](PINConfiguration) | The configuration for user PINs to access their voicemail from a phone | [optional] |
| **VoicemailExtension** | **string** | The extension for voicemail retrieval.  The default value is *86. | [optional] |
| **PinRequired** | **bool?** | If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone. | [optional] |
| **InteractiveResponseRequired** | **bool?** | Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call | [optional] |
| **SendEmailNotifications** | **bool?** | Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting. | [optional] |
| **IncludeEmailTranscriptions** | **bool?** | Whether to include the voicemail transcription in the notification email | [optional] |
| **DisableEmailPii** | **bool?** | Removes any PII from emails. This overrides any analogous group configuration value. This is always true if HIPAA is enabled or unknown for an organization. | [optional] |
| **MaximumRecordingTimeSeconds** | **int?** | Default value for the maximum length of time in seconds of a recorded voicemail | [optional] |
| **ModifiedDate** | **DateTime?** | The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
