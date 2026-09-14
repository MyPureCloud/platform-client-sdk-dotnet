# ContactSimpleSearch

## ININ.PureCloudApi.Model.ContactSimpleSearch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | User supplied search keywords (no special syntax is currently supported) | [optional] |
| **SortOrder** | **List&lt;string&gt;** | The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot; | [optional] |
| **Ids** | **List&lt;string&gt;** | List of External Contact ids to exact match in search result. Optional filter, up to 100 | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
