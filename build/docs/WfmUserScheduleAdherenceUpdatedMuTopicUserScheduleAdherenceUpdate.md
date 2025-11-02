# WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate

## ININ.PureCloudApi.Model.WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**WfmUserScheduleAdherenceUpdatedMuTopicUserReference**](WfmUserScheduleAdherenceUpdatedMuTopicUserReference) |  | [optional] |
| **ManagementUnitId** | **string** |  | [optional] |
| **Team** | [**WfmUserScheduleAdherenceUpdatedMuTopicUriReference**](WfmUserScheduleAdherenceUpdatedMuTopicUriReference) |  | [optional] |
| **ScheduledActivityCategory** | **string** |  | [optional] |
| **ScheduledActivityCode** | [**WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference**](WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference) |  | [optional] |
| **SystemPresence** | **string** |  | [optional] |
| **OrganizationSecondaryPresenceId** | **string** |  | [optional] |
| **RoutingStatus** | **string** |  | [optional] |
| **ActualActivityCategory** | **string** |  | [optional] |
| **IsOutOfOffice** | **bool?** |  | [optional] |
| **AdherenceState** | **string** |  | [optional] |
| **Impact** | **string** |  | [optional] |
| **AdherenceExplanation** | [**WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation**](WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation) |  | [optional] |
| **AdherenceChangeTime** | **DateTime?** |  | [optional] |
| **PresenceUpdateTime** | **DateTime?** |  | [optional] |
| **ActiveQueues** | [**List&lt;WfmUserScheduleAdherenceUpdatedMuTopicQueueReference&gt;**](WfmUserScheduleAdherenceUpdatedMuTopicQueueReference) |  | [optional] |
| **ActiveQueuesModifiedTime** | **DateTime?** |  | [optional] |
| **RemovedFromManagementUnit** | **bool?** |  | [optional] |
| **SuppressOnTimeReminder** | **bool?** |  | [optional] |
| **NextActivityReminders** | [**List&lt;WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder&gt;**](WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder) |  | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
