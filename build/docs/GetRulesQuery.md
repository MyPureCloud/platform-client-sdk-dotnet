# GetRulesQuery

## ININ.PureCloudApi.Model.GetRulesQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RuleType** | **string** | The rule type of the alerts the query will return | |
| **QueryType** | **string** | The type of query being performed. | |
| **EnabledType** | **string** | The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All | [optional] |
| **PageNumber** | **int?** | The page number of the queried response | [optional] |
| **PageSize** | **int?** | The number of entities to return of the queried response.  The max is 25 | [optional] |
| **SortBy** | **string** | The field to sort responses by.  The accepted choices are Name and DateStart | [optional] |
| **SortOrder** | **string** | The order in which response will be sorted.  The accepted choices are Asc and Desc | [optional] |
| **RuleName** | **string** | The name of the rule being queries. | [optional] |
| **NameSearchType** | **string** | Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
