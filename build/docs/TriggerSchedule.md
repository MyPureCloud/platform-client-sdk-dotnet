# TriggerSchedule

## ININ.PureCloudApi.Model.TriggerSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Minutes** | **string** | Minutes on which the trigger should fire. Coma separated list of up to 2 values 0-59 | [optional] |
| **Hours** | **string** | Hours on which the trigger should fire. 0-23 or &#39;*&#39; for every hour. | [optional] |
| **DaysOfMonth** | **string** | Days of month on which the trigger should fire. 1-31 or &#39;*&#39; for every or &#39;?&#39; for any | [optional] |
| **Months** | **string** | Months on which the trigger should fire. 1-12 or &#39;*&#39; for every | [optional] |
| **DaysOfWeek** | **string** | Days of week on which the trigger should fire. 1-7 or &#39;*&#39; for every or &#39;?&#39; for any | [optional] |
| **Timezone** | **string** | Timezone for the trigger schedule | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
