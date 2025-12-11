# CreateActivityPlanRequest

## ININ.PureCloudApi.Model.CreateActivityPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the activity plan | |
| **ManagementUnitIds** | **List&lt;string&gt;** | The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit | [optional] |
| **Description** | **string** | The description of the activity plan | [optional] |
| **ActivityCodeId** | **string** | The activity code associated with the activity plan | |
| **Type** | **string** | The type of the activity plan | |
| **LengthMinutes** | **int?** | The length in minutes of the activity plan | |
| **InitialSchedulePeriod** | [**SchedulingPeriod**](SchedulingPeriod) | The initial scheduling period for the activity plan | |
| **GroupSettings** | [**GroupSettings**](GroupSettings) | Group settings for the activity plan | [optional] |
| **RecurrenceSettings** | [**RecurrenceSettings**](RecurrenceSettings) | Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once | [optional] |
| **AttendeesSearchRule** | [**UserSearchRule**](UserSearchRule) | Attendee search rule for this activity plan | [optional] |
| **Facilitated** | **bool?** | Whether the sessions created by this activity plan should be facilitated | [optional] |
| **FacilitatorsSearchRule** | [**UserSearchRule**](UserSearchRule) | Facilitator search rule for this activity plan | [optional] |
| **TransitionTimeMinutes** | **int?** | Transition time in minutes between facilitated sessions | |
| **ServiceGoalImpactOverrides** | [**ActivityPlanServiceGoalImpactOverrides**](ActivityPlanServiceGoalImpactOverrides) | Allowable service goal impact override settings for this activity plan. If not set the business unit setting will be used | [optional] |
| **OptimizationObjective** | **string** | The optimization objective of this activity plan | |
| **State** | **string** | The state of this activity plan | |
| **CountsAsPaidTime** | **bool?** | Whether the activity should count as paid time | |
| **FixedAvailability** | [**List&lt;FixedAvailability&gt;**](FixedAvailability) | Fixed availability configuration for the activity plan | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
