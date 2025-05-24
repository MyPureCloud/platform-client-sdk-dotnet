# UserSearchRequest

## ININ.PureCloudApi.Model.UserSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **Expand** | **List&lt;string&gt;** | Provides more details about a specified resource | [optional] |
| **Query** | [**List&lt;UserSearchCriteria&gt;**](UserSearchCriteria) |  | [optional] |
| **IntegrationPresenceSource** | **string** | Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \&quot;expand\&quot;. When using this parameter the maximum number of users that can be returned is 100. | [optional] |
| **EnforcePermissions** | **bool?** | This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
