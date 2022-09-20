---
title: UpdateTriggerRequest
---
## ININ.PureCloudApi.Model.UpdateTriggerRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | **long?** | Version of this trigger | |
| **Enabled** | **bool?** | Boolean indicating if Trigger is enabled | |
| **Target** | [**TriggerTarget**](TriggerTarget.html) | The target to invoke when a matching event is received | |
| **MatchCriteria** | [**List&lt;MatchCriteria&gt;**](MatchCriteria.html) | The configuration for when a trigger is considered to be a match for an event | [optional] |
| **Name** | **string** | The name of the trigger | |
| **TopicName** | **string** | The topic that will cause the trigger to be invoked. Must match existing trigger topicName. | |
| **EventTTLSeconds** | **int?** | How long each event is meaningful after origination, in seconds. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely. | [optional] |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |
{: class="table table-striped"}


