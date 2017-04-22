---
title: VoicemailGroupPolicy
---
## ININ.PureCloudApi.Model.VoicemailGroupPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** |  | [optional] |
| **Group** | [**Group**](Group.html) | The group associated with the policy | [optional] |
| **Enabled** | **bool?** | Whether voicemail is enabled for the group | [optional] |
| **SendEmailNotifications** | **bool?** | Whether email notifications are sent to group members when a new voicemail is received | [optional] |
| **RotateCallsSecs** | **int?** | How many seconds to ring before rotating to the next member in the group | [optional] |
| **StopRingingAfterRotations** | **int?** | How many rotations to go through | [optional] |
| **OverflowGroupId** | **string** |  A fallback group to contact when all of the members in this group did not answer the call. | [optional] |
| **GroupAlertType** | **string** | Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin. | [optional] |
{: class="table table-striped"}


