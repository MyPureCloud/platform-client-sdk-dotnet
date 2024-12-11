# ActivityPlanResponse

## ININ.PureCloudApi.Model.ActivityPlanResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the activity plan | |
| **ManagementUnits** | [**List&lt;ManagementUnitReference&gt;**](ManagementUnitReference) | The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit | [optional] |
| **Description** | **string** | The description of this activity plan | |
| **ActivityCode** | [**ActivityCodeReference**](ActivityCodeReference) | The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes | |
| **Type** | **string** | The type of the activity plan | |
| **InitialSchedulePeriod** | [**SchedulingPeriod**](SchedulingPeriod) | The initial schedule period of the activity plan | |
| **LengthMinutes** | **int?** | The length of the activity in minutes | |
| **GroupSettings** | [**GroupSettings**](GroupSettings) | Group settings for this activity plan | [optional] |
| **RecurrenceSettings** | [**RecurrenceSettings**](RecurrenceSettings) | Recurrence settings for this activity plan | [optional] |
| **AttendeesSearchRule** | [**UserSearchRule**](UserSearchRule) | Attendee search rule for this activity plan | [optional] |
| **Facilitated** | **bool?** | Whether the sessions created by this activity plan should be facilitated | |
| **FacilitatorsSearchRule** | [**UserSearchRule**](UserSearchRule) | Facilitator search rule for this activity plan | [optional] |
| **TransitionTimeMinutes** | **int?** | Transition time in minutes between facilitated sessions | |
| **ServiceGoalImpactOverrides** | [**ActivityPlanServiceGoalImpactOverrides**](ActivityPlanServiceGoalImpactOverrides) | Allowable service goal impact override settings for this activity plan | [optional] |
| **OptimizationObjective** | **string** | The optimization objective of this activity plan | |
| **FixedAvailability** | [**List&lt;FixedAvailability&gt;**](FixedAvailability) | Fixed availability configuration for this activity plan | [optional] |
| **State** | **string** | The state of this activity plan | |
| **CountsAsPaidTime** | **bool?** | Whether the activity should count as paid time | |
| **CreatedDate** | **DateTime?** | The date the activity plan was created, in ISO-8601 format | |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created this activity plan | |
| **ModifiedDate** | **DateTime?** | The date the activity plan was modified, in ISO-8601 format | |
| **ModifiedBy** | [**UserReference**](UserReference) | The last user to modify this activity plan | |
| **LastRunDate** | **DateTime?** | The date the activity plan was last run, in ISO-8601 format | [optional] |
| **LastRunBy** | [**UserReference**](UserReference) | The last user to run this activity plan | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
