# CaseplanQueryRequest

## ININ.PureCloudApi.Model.CaseplanQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Filter by Caseplan name (case-insensitive, partial match). Omitting name returns all Caseplans (subject to pagination). | [optional] |
| **NameSearchType** | **string** | Type of name search to perform. Default is BEGINS_WITH. | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Divisions to filter by. Accepts a list of UUIDs and/or &#39;*&#39;. | [optional] |
| **Filters** | [**List&lt;CaseplanFilter&gt;**](CaseplanFilter) | List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;divisionId&#39;. Multiple filters are combined with AND logic. | [optional] |
| **Attributes** | **List&lt;string&gt;** | List of entity attributes to be retrieved in the result. | [optional] |
| **PageSize** | **int?** | Number of results per page. Maximum is 200. Default is 25. | [optional] |
| **After** | **string** | Cursor for pagination. Use the \&quot;after\&quot; value from the previous response. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
