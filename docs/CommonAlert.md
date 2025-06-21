# CommonAlert

## ININ.PureCloudApi.Model.CommonAlert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**UserReference**](UserReference) | The user who created the rule that triggered the alert. | |
| **Rule** | [**AlertRuleProperties**](AlertRuleProperties) | The properties of the rule that triggered the alert. | |
| **Notifications** | [**List&lt;AlertNotification&gt;**](AlertNotification) | The collection of notification methods and the ids of users who were notified by those methods. | |
| **DateStart** | **DateTime?** | The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateEnd** | **DateTime?** | The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Active** | **bool?** | Indicates if an alert is currently active. | |
| **Unread** | **bool?** | Indicates if an alert has not been read. | |
| **WaitBetweenNotificationMs** | **long?** | The amount of time to wait between notification. Time is in milliseconds. | |
| **Muted** | **bool?** | Flag indicating if the alert is in a muted state. | |
| **Snoozed** | **bool?** | Flag indicating if the alert is in a snoozed state. | |
| **DateMutedUntil** | **DateTime?** | Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateSnoozedUntil** | **DateTime?** | Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Conditions** | [**CommonRuleConditions**](CommonRuleConditions) | The conditions that make up the rule. | |
| **ConversationId** | **string** | The id of the conversation instance that caused the alert to trigger. | [optional] |
| **AlertSummary** | [**AlertSummary**](AlertSummary) | Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates | [optional] |
| **RuleUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
