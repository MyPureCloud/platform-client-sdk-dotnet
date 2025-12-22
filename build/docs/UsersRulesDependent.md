# UsersRulesDependent

## ININ.PureCloudApi.Model.UsersRulesDependent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RuleId** | **string** | The id of the rule | [optional] |
| **TypeId** | **string** | The type id of the dependent | [optional] |
| **Type** | **string** | The type of the dependent | [optional] |
| **CreatedDate** | **DateTime?** | The date/time the dependent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the dependent | [optional] |
| **LastRun** | [**UsersRulesLastRunMetadata**](UsersRulesLastRunMetadata) | Information on the last run of the dependent | [optional] |
| **RecentRunCount** | **long?** | The number of times the rule has run | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
