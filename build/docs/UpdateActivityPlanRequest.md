# UpdateActivityPlanRequest

## ININ.PureCloudApi.Model.UpdateActivityPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the activity plan | [optional] |
| **Description** | **string** | The description of the activity plan | [optional] |
| **GroupSettings** | [**ValueWrapperGroupSettings**](ValueWrapperGroupSettings) | Group settings for the activity plan | [optional] |
| **AttendeesSearchRule** | [**ValueWrapperUserSearchRule**](ValueWrapperUserSearchRule) | Attendee search rule for this activity plan | [optional] |
| **FacilitatorsSearchRule** | [**ValueWrapperUserSearchRule**](ValueWrapperUserSearchRule) | Facilitator search rule for this activity plan | [optional] |
| **TransitionTimeMinutes** | **int?** | Transition time in minutes between facilitated sessions | [optional] |
| **ServiceGoalImpactOverrides** | [**ValueWrapperActivityPlanServiceGoalImpactOverrides**](ValueWrapperActivityPlanServiceGoalImpactOverrides) | Allowable service goal impact override settings for this activity plan | [optional] |
| **OptimizationObjective** | **string** | The optimization objective of this activity plan | [optional] |
| **State** | **string** | The state of this activity plan | [optional] |
| **FixedAvailability** | [**ListWrapperFixedAvailability**](ListWrapperFixedAvailability) | Fixed availability configuration for the activity plan | [optional] |
| **ActivityCodeId** | **string** | The activity code associated with the activity plan | [optional] |
| **Type** | **string** | The type of the activity plan | [optional] |
| **LengthMinutes** | **int?** | The length in minutes of the activity plan | [optional] |
| **CountsAsPaidTime** | **bool?** | Whether the activity should count as paid time | [optional] |
| **RecurrenceSettings** | [**RecurrenceSettingsBase**](RecurrenceSettingsBase) | Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
