---
title: UserPresenceAlert
---
## ININ.PureCloudApi.Model.UserPresenceAlert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **PresenceUser** | [**User**](User.html) | The user whose presence will be watched. | |
| **PresenceType** | **string** | Indicates to which presence type the presence value belongs. | |
| **PresenceValue** | **string** | The Org&#39;s UUID or Systems enum constance indicating the presence of concern. | |
| **PresenceLimitInSeconds** | **int?** | The number of seconds to wait before alerting based upon the user&#39;s presence. | |
| **RuleId** | **string** | The id of the rule. | |
| **StartDate** | **DateTime?** | The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EndDate** | **DateTime?** | The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who were notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **RuleUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


