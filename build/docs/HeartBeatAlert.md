---
title: HeartBeatAlert
---
## ININ.PureCloudApi.Model.HeartBeatAlert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **SenderId** | **string** | The value that identifies the sender of the heartbeat. | |
| **HeartBeatTimeoutInMinutes** | **int?** | The number of minutes to wait before alerting missing heartbeats. | |
| **RuleId** | **string** | The id of the rule. | |
| **StartDate** | **DateTime?** | The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EndDate** | **DateTime?** | The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who were notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **RuleType** | **string** | The type of heartbeat rule that generated the alert | |
| **RuleUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


