# GetAlertQuery

## ININ.PureCloudApi.Model.GetAlertQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RuleType** | **string** | The rule type of the alerts the query will return | |
| **QueryType** | **string** | The type of query being performed. | |
| **AlertStatus** | **string** | The status of the alerts the query will return. | [optional] |
| **ViewedStatus** | **string** | The view status of the alerts the query will return. | [optional] |
| **PageNumber** | **int?** | The page number of the queried response | [optional] |
| **PageSize** | **int?** | The number of entities to return of the queried response.  The max is 25 | [optional] |
| **SortBy** | **string** | The field to sort responses by.  The accepted choices are Name and DateStart | [optional] |
| **SortOrder** | **string** | The order in which response will be sorted.  The accepted choices are Asc and Desc | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
