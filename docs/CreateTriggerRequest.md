# CreateTriggerRequest

## ININ.PureCloudApi.Model.CreateTriggerRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Target** | [**TriggerTarget**](TriggerTarget) | The target to invoke when a matching event is received | |
| **Enabled** | **bool?** | Boolean indicating if Trigger is enabled | |
| **MatchCriteria** | [**List&lt;MatchCriteria&gt;**](MatchCriteria) | The configuration for when a trigger is considered to be a match for an event. When not provided, all events will fire the trigger | [optional] |
| **Name** | **string** | The name of the trigger | |
| **TopicName** | **string** | The topic that will cause the trigger to be invoked. Cannot be updated after creation. Valid topics can be found at /processautomation/triggers/topics  | |
| **EventTTLSeconds** | **int?** | Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. | [optional] |
| **DelayBySeconds** | **int?** | Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. | [optional] |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
