# CaseplanQueryRequest

## ININ.PureCloudApi.Model.CaseplanQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Filter by caseplan name (case-insensitive, partial match). Omitting name returns all caseplans (subject to pagination). | [optional] |
| **PageSize** | **int?** | Number of results per page. Maximum is 200. Default is 25. | [optional] |
| **After** | **string** | Cursor for pagination. Use the \&quot;after\&quot; value from the previous response. | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Divisions to filter by. Accepts a list of UUIDs and/or &#39;*&#39;. | [optional] |



_PureCloudPlatform.Client.V2 263.0.0_
