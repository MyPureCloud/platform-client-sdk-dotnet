# VoicemailGroupPolicy

## ININ.PureCloudApi.Model.VoicemailGroupPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** |  | [optional] |
| **Group** | [**Group**](Group) | The group associated with the policy | [optional] |
| **Enabled** | **bool?** | Whether voicemail is enabled for the group | [optional] |
| **SendEmailNotifications** | **bool?** | Whether email notifications are sent to group members when a new voicemail is received | [optional] |
| **DisableEmailPii** | **bool?** | Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization. | [optional] |
| **IncludeEmailTranscriptions** | **bool?** | Whether to include the voicemail transcription in a group notification email | [optional] |
| **LanguagePreference** | **string** | The language preference for the group.  Used for group voicemail transcription | [optional] |
| **EmailPolicy** | [**GroupEmailPolicy**](GroupEmailPolicy) | The email policy for the group | [optional] |
| **RotateCallsSecs** | **int?** | How many seconds to ring before rotating to the next member in the group | [optional] |
| **StopRingingAfterRotations** | **int?** | How many rotations to go through | [optional] |
| **OverflowGroupId** | **string** | A fallback group to contact when all of the members in this group did not answer the call. | [optional] |
| **GroupAlertType** | **string** | Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin. | [optional] |
| **InteractiveResponsePromptId** | **string** | The prompt to use when connecting a user to a Group Ring call | [optional] |
| **InteractiveResponseRequired** | **bool?** | Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
