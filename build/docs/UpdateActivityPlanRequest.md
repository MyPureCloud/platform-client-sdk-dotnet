---
title: UpdateActivityPlanRequest
---
## ININ.PureCloudApi.Model.UpdateActivityPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the activity plan | [optional] |
| **Description** | **string** | The description of the activity plan | [optional] |
| **GroupSettings** | [**ValueWrapperGroupSettings**](ValueWrapperGroupSettings.html) | Group settings for the activity plan | [optional] |
| **AttendeesSearchRule** | [**ValueWrapperUserSearchRule**](ValueWrapperUserSearchRule.html) | Attendee search rule for this activity plan | [optional] |
| **FacilitatorsSearchRule** | [**ValueWrapperUserSearchRule**](ValueWrapperUserSearchRule.html) | Facilitator search rule for this activity plan | [optional] |
| **TransitionTimeMinutes** | **int?** | Transition time in minutes between facilitated sessions | [optional] |
| **ServiceGoalImpactOverrides** | [**ValueWrapperActivityPlanServiceGoalImpactOverrides**](ValueWrapperActivityPlanServiceGoalImpactOverrides.html) | Allowable service goal impact override settings for this activity plan | [optional] |
| **OptimizationObjective** | **string** | The optimization objective of this activity plan | [optional] |
| **State** | **string** | The state of this activity plan | [optional] |
| **FixedAvailability** | [**ListWrapperFixedAvailability**](ListWrapperFixedAvailability.html) | Fixed availability configuration for the activity plan | [optional] |
{: class="table table-striped"}


