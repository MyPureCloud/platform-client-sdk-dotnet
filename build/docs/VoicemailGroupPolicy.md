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
{: class="table table-striped"}


