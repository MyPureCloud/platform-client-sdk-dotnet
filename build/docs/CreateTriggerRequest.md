---
title: CreateTriggerRequest
---
## ININ.PureCloudApi.Model.CreateTriggerRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Target** | [**TriggerTarget**](TriggerTarget.html) | The target to invoke when a matching event is received | |
| **Enabled** | **bool?** | Boolean indicating if Trigger is enabled | |
| **MatchCriteria** | [**List&lt;MatchCriteria&gt;**](MatchCriteria.html) | The configuration for when a trigger is considered to be a match for an event. When not provided, all events will fire the trigger | [optional] |
| **Name** | **string** | The name of the trigger | |
| **TopicName** | **string** | The topic that will cause the trigger to be invoked. Cannot be updated after creation. Valid topics can be found at /processautomation/triggers/topics  | |
| **EventTTLSeconds** | **int?** | How long each event is meaningful after origination, in seconds. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely. | [optional] |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |
{: class="table table-striped"}


