# ModifiableRuleProperties

## ININ.PureCloudApi.Model.ModifiableRuleProperties

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
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
