# Trigger

## ININ.PureCloudApi.Model.Trigger

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the trigger | [optional] |
| **TopicName** | **string** | The topic that will cause the trigger to be invoked | [optional] |
| **Target** | [**TriggerTarget**](TriggerTarget) | The target to invoke when a matching event is received | [optional] |
| **Version** | **long?** | Version of this trigger | [optional] |
| **Enabled** | **bool?** | Whether or not the trigger is enabled | [optional] |
| **MatchCriteria** | [**List&lt;MatchCriteria&gt;**](MatchCriteria) | The configuration for when a trigger is considered to be a match for an event | [optional] |
| **EventTTLSeconds** | **int?** | Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. | [optional] |
| **DelayBySeconds** | **int?** | Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. | [optional] |
| **Description** | **string** | Description of the trigger. Can be up to 512 characters in length. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
