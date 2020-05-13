---
title: PlanningGroup
---
## ININ.PureCloudApi.Model.PlanningGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ServiceGoalTemplate** | [**ServiceGoalTemplateReference**](ServiceGoalTemplateReference.html) | The ID of the service goal template associated with this planning group | [optional] |
| **RoutePaths** | [**List&lt;RoutePathResponse&gt;**](RoutePathResponse.html) | Set of route paths associated with the planning group | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the planning group | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


