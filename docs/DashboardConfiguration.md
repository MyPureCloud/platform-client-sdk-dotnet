# DashboardConfiguration

## ININ.PureCloudApi.Model.DashboardConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of dashboard configuration. | |
| **Rows** | **int?** | The count of rows for the specific dashboard configuration. | [optional] |
| **Columns** | **int?** | The count of columns for the specific dashboard. | [optional] |
| **Widgets** | [**List&lt;Widget&gt;**](Widget) | List of widgets for dashboard configuration. | |
| **Favorite** | **bool?** | The flag indicates if the dashboard is favorited by the user | [optional] |
| **PublicDashboard** | **bool?** | The flag to indicate if the dashboard is published by an user | [optional] |
| **Restricted** | **bool?** | The flag to indicate if the dashboard has any restricted data for that user | [optional] |
| **LayoutType** | **string** | The layout type of the dashboard | [optional] |
| **DateCreated** | **DateTime?** | The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateModified** | **DateTime?** | The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateDeleted** | **DateTime?** | The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The id of user who created the dashboard | [optional] |
| **Shared** | **bool?** | The flag to indicate if the dashboard is shared | [optional] |
| **DashboardsSharedWith** | [**DashboardsSharedWith**](DashboardsSharedWith) | The list of users and teams the dashboard is shared with | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
