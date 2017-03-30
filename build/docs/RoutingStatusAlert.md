---
title: RoutingStatusAlert
---
## ININ.PureCloudApi.Model.RoutingStatusAlert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **Agent** | [**User**](User.html) | The agent whose routing status will be watched. | |
| **RoutingStatus** | **string** | The routing status on which to alert. | |
| **RoutingLimitInSeconds** | **int?** | The number of seconds to wait before alerting based upon the agent&#39;s routing status. | |
| **RuleId** | **string** | The id of the rule. | |
| **StartDate** | **DateTime?** | The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EndDate** | **DateTime?** | The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who were notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


