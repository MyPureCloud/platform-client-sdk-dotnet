# WorkitemQueryJobCreate

## ININ.PureCloudApi.Model.WorkitemQueryJobCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | The total page size requested. Default 25 | [optional] |
| **PageNumber** | **int?** | The page number requested | [optional] |
| **Filters** | [**List&lt;WorkitemQueryJobFilter&gt;**](WorkitemQueryJobFilter) | List of filter objects to be used in the search. | |
| **QueryFilters** | [**List&lt;WorkitemQueryJobQueryFilters&gt;**](WorkitemQueryJobQueryFilters) | Query filters for nested attributes. | [optional] |
| **Expands** | **List&lt;string&gt;** | List of entity attributes to be expanded in the result. | [optional] |
| **Attributes** | **List&lt;string&gt;** | List of entity attributes to be retrieved in the result. | [optional] |
| **Sort** | [**WorkitemQueryJobSort**](WorkitemQueryJobSort) | Sort | [optional] |
| **DateIntervalStart** | **DateTime?** | Interval start date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateIntervalEnd** | **DateTime?** | Interval end date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
