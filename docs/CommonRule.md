# CommonRule

## ININ.PureCloudApi.Model.CommonRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **Description** | **string** | The description of the rule. | [optional] |
| **Enabled** | **bool?** | Indicates if the rule is enabled. | [optional] |
| **Notifications** | [**List&lt;AlertNotification&gt;**](AlertNotification) | The alert notification types to trigger when alarm state changes as well as the users they will be sent to. | [optional] |
| **SendExitingAlarmNotifications** | **bool?** | Indicates if the alert will send a notification when it is closed. | [optional] |
| **WaitBetweenNotificationMs** | **long?** | The amount of time in milliseconds to wait between notification. | [optional] |
| **Conditions** | [**CommonRuleConditions**](CommonRuleConditions) | The set of metric conditions that would trigger an alert. | [optional] |
| **Type** | **string** | The type of the rule. | |
| **InAlarm** | **bool?** | Indicates if the rule is in alarm state. | [optional] |
| **User** | [**UserReference**](UserReference) | The entity that created the rule. | [optional] |
| **Version** | **int?** | The current version number of the rule. | [optional] |
| **DateCreated** | **DateTime?** | The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateLastModified** | **DateTime?** | The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
