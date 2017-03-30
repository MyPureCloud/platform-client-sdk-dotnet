---
title: HeartBeatRule
---
## ININ.PureCloudApi.Model.HeartBeatRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **SenderId** | **string** | The value that identifies the sender of the heartbeat. | |
| **HeartBeatTimeoutInMinutes** | **int?** | The number of minutes to wait before alerting missing heartbeats. | |
| **Enabled** | **bool?** | Indicates if the rule is enabled. | |
| **InAlarm** | **bool?** | Indicates if the rule is in alarm state. | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who will be notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **RuleType** | **string** | The type of system the will be generating the heartbeat. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


