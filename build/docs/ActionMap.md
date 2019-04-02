---
title: ActionMap
---
## ININ.PureCloudApi.Model.ActionMap

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | The version of the action map. | [optional] |
| **IsActive** | **bool?** | Whether the action map is active. | [optional] |
| **DisplayName** | **string** | Display name of the action map. | |
| **TriggerWithSegments** | **List&lt;string&gt;** | Trigger action map if any segment in the list is assigned to a given customer. | |
| **TriggerWithEventConditions** | [**List&lt;EventCondition&gt;**](EventCondition.html) | List of event conditions that must be satisfied to trigger the action map. | [optional] |
| **TriggerWithOutcomeProbabilityConditions** | [**List&lt;OutcomeProbabilityCondition&gt;**](OutcomeProbabilityCondition.html) | Probability conditions for outcomes that must be satisfied to trigger the action map. | [optional] |
| **PageUrlConditions** | [**List&lt;UrlCondition&gt;**](UrlCondition.html) | URL conditions that a page must match for web actions to be displayable. | |
| **Activation** | [**Activation**](Activation.html) | Type of activation. | [optional] |
| **Weight** | **int?** | Weight of the action map with higher number denoting higher weight. | [optional] |
| **Action** | [**ActionMapAction**](ActionMapAction.html) | The action that will be executed if this action map is triggered. | [optional] |
| **EstimatedWaitTimeLimit** | **int?** | The estimated wait time limit above which actions will not be offered. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **StartDate** | **DateTime?** | Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndDate** | **DateTime?** | Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


