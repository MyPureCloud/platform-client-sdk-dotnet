---
title: UserRoutingSkill
---
## ININ.PureCloudApi.Model.UserRoutingSkill

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Proficiency** | **double?** | Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings. | [optional] |
| **State** | **string** | Activate or deactivate this routing skill. | [optional] |
| **SkillUri** | **string** | URI to the organization skill used by this user skill. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


