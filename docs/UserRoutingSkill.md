# UserRoutingSkill

## ININ.PureCloudApi.Model.UserRoutingSkill

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Proficiency** | **double?** | A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings. | [optional] |
| **State** | **string** | Activate or deactivate this routing skill. | [optional] |
| **SkillUri** | **string** | URI to the organization skill used by this user skill. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
