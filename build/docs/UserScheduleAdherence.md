# UserScheduleAdherence

## ININ.PureCloudApi.Model.UserScheduleAdherence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**UserReference**](UserReference) | The user for whom this status applies | [optional] |
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which this user belongs | [optional] |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which this user belongs | [optional] |
| **Team** | [**TeamReference**](TeamReference) | The team to which this user belongs | [optional] |
| **ScheduledActivityCategory** | **string** | Activity for which the user is scheduled | [optional] |
| **ScheduledActivityCode** | [**ActivityCodeSummary**](ActivityCodeSummary) | Activity code for which the user is currently scheduled | [optional] |
| **SystemPresence** | **string** | Actual underlying system presence value | [optional] |
| **OrganizationSecondaryPresenceId** | **string** | Organization Secondary Presence Id. | [optional] |
| **RoutingStatus** | **string** | Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue | [optional] |
| **ActualActivityCategory** | **string** | Activity in which the user is actually engaged | [optional] |
| **IsOutOfOffice** | **bool?** | Whether the user is marked OutOfOffice | [optional] |
| **AdherenceState** | **string** | The user&#39;s current adherence state | [optional] |
| **Impact** | **string** | The impact of the user&#39;s current adherenceState | [optional] |
| **AdherenceExplanation** | [**RealTimeAdherenceExplanation**](RealTimeAdherenceExplanation) | Currently applicable explanation for the adherence state | [optional] |
| **TimeOfAdherenceChange** | **DateTime?** | Time when the user entered the current adherenceState in ISO-8601 format | [optional] |
| **PresenceUpdateTime** | **DateTime?** | Time when presence was last updated. Used to calculate time in current status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ActiveQueues** | [**List&lt;QueueReference&gt;**](QueueReference) | The list of queues to which this user is joined | [optional] |
| **ActiveQueuesModifiedTime** | **DateTime?** | Time when the list of active queues for this user was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RemovedFromManagementUnit** | **bool?** | For notification purposes. Used to indicate that a user was removed from the management unit | [optional] |
| **NextActivityReminders** | [**List&lt;UserNextActivityReminder&gt;**](UserNextActivityReminder) | A list of upcoming activities for which the user is scheduled | [optional] |
| **SuppressOnTimeReminder** | **bool?** | Indicates whether the on-time adherence notification should be suppressed for the user | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
