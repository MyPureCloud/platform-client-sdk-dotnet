# UsersRulesRule

## ININ.PureCloudApi.Model.UsersRulesRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | The description of the rule | [optional] |
| **Type** | **string** | The type of the rule | [optional] |
| **Criteria** | [**List&lt;UsersRulesCriteria&gt;**](UsersRulesCriteria) | The criteria of the rule | [optional] |
| **CreatedDate** | **DateTime?** | The date/time the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the rule | [optional] |
| **ModifiedDate** | **DateTime?** | The date/time the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The last user to modify the rule | [optional] |
| **LastRun** | [**UsersRulesLastRunMetadata**](UsersRulesLastRunMetadata) | Information on the last run of the rule | [optional] |
| **RecentRunCount** | **long?** | The number of times the rule has run | [optional] |
| **DependentCount** | **long?** | The number of dependents this rule has | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
