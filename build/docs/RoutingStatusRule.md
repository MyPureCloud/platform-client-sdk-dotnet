---
title: RoutingStatusRule
---
## ININ.PureCloudApi.Model.RoutingStatusRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **Agent** | [**User**](User.html) | The agent whose routing status will be watched. | |
| **RoutingStatus** | **string** | The routing status on which to alert. | |
| **RoutingLimitInSeconds** | **int?** | The number of seconds to wait before alerting based upon the agent&#39;s routing status. | |
| **Enabled** | **bool?** | Indicates if the rule is enabled. | |
| **InAlarm** | **bool?** | Indicates if the rule is in alarm state. | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who will be notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


