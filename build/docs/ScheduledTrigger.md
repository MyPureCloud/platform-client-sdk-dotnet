# ScheduledTrigger

## ININ.PureCloudApi.Model.ScheduledTrigger

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the scheduled trigger. Can be up to 162 characters in length. | [optional] |
| **Target** | [**TriggerTarget**](TriggerTarget) | The target to invoke when the scheduled trigger fires | [optional] |
| **Version** | **long?** | Version of this scheduled trigger | [optional] |
| **Enabled** | **bool?** | Whether or not the scheduled trigger is enabled | [optional] |
| **Schedule** | [**TriggerSchedule**](TriggerSchedule) | The schedule configuration for when this trigger should fire | [optional] |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
