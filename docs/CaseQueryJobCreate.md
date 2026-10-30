# CaseQueryJobCreate

## ININ.PureCloudApi.Model.CaseQueryJobCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | The total page size requested (default 25). | [optional] |
| **PageNumber** | **int?** | The requested page number. | [optional] |
| **Filters** | [**List&lt;CaseQueryJobFilter&gt;**](CaseQueryJobFilter) | List of filter objects to be used in the search. Use an empty list to run the query with no filters. | |
| **FilterGroups** | [**List&lt;CaseQueryJobFilterGroup&gt;**](CaseQueryJobFilterGroup) | List of filter groups to be used in the search. The filters within a group are combined using the group operator; groups are combined with each other and with the top-level filters using AND.  | [optional] |
| **Sort** | [**CaseQueryJobSort**](CaseQueryJobSort) | Sort order for results. | [optional] |
| **Attributes** | **List&lt;string&gt;** | List of entity attributes to be retrieved in the result. | [optional] |
| **Expands** | **List&lt;string&gt;** | Attributes to expand on each case in the job results. Expands are stored on the job and enriched by PubAPI when results are fetched. | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
