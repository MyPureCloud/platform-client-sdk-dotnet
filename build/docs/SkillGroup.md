# SkillGroup

## ININ.PureCloudApi.Model.SkillGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The group name. | |
| **Division** | [**WritableDivision**](WritableDivision) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | Group description | [optional] |
| **MemberCount** | **long?** | Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed. | [optional] |
| **DateModified** | **DateTime?** | Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCreated** | **DateTime?** | Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Group&#39;s filling status | [optional] |
| **SkillConditions** | [**List&lt;SkillGroupCondition&gt;**](SkillGroupCondition) | Conditions for this group | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
