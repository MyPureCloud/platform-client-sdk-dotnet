# CreateScheduledTriggerRequest

## ININ.PureCloudApi.Model.CreateScheduledTriggerRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Target** | [**TriggerTarget**](TriggerTarget) | The target to invoke when the scheduled trigger fires | |
| **Enabled** | **bool?** | Boolean indicating if scheduled trigger is enabled | |
| **Name** | **string** | The name of the scheduled trigger. Can be up to 162 characters in length. | |
| **Schedule** | [**TriggerSchedule**](TriggerSchedule) | The schedule configuration for when this trigger should fire | |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
