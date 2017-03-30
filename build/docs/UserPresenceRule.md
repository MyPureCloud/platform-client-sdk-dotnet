---
title: UserPresenceRule
---
## ININ.PureCloudApi.Model.UserPresenceRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **PresenceUser** | [**User**](User.html) | The user whose presence will be watched. | |
| **PresenceType** | **string** | Indicates to which presence type the presence value belongs. | |
| **PresenceValue** | **string** | The Org&#39;s UUID or Systems enum constance indicating the presence of concern. | |
| **PresenceLimitInSeconds** | **int?** | The number of seconds to wait before alerting based upon the user&#39;s presence. | |
| **Enabled** | **bool?** | Indicates if the rule is enabled. | |
| **InAlarm** | **bool?** | Indicates if the rule is in alarm state. | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User.html) | The ids of users who will be notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


