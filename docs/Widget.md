# Widget

## ININ.PureCloudApi.Model.Widget

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Row** | **int?** | The row number for the specific dashboard widget configuration. | [optional] |
| **Column** | **int?** | The column number for the specific dashboard widget configuration. | [optional] |
| **Title** | **string** | The title for the dashboard widget configuration. | [optional] |
| **Type** | **string** | The type of dashboard widget configuration. | |
| **Metrics** | **List&lt;string&gt;** | The list of metrics for the dashboard widget configuration. | [optional] |
| **DisplayText** | **string** | The display text for the dashboard widget configuration. | [optional] |
| **DisplayTextColor** | **string** | The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red). | [optional] |
| **WebContentUrl** | **string** | The external web URL for the dashboard widget configuration. | [optional] |
| **SplitFilters** | **bool?** | Indicates each filter to be displayed individually. | [optional] |
| **SplitByMediaType** | **bool?** | Indicates that data for each media type should be shown individually. | [optional] |
| **ShowLongest** | **bool?** | Indicates the display be the longest time. | [optional] |
| **DisplayAsTable** | **bool?** | Indicates the widget to be displayed as table. | [optional] |
| **ShowDuration** | **bool?** | Indicates the display to include duration. | [optional] |
| **SortOrder** | **string** | The sort order of the table. | [optional] |
| **SortKey** | **string** | The sort key of the table. | [optional] |
| **EntityLimit** | **int?** | Indicates the limit of displayed entities. | [optional] |
| **DisplayAggregates** | **bool?** | Indicates whether to display aggregate across all entity and media type combination. | [optional] |
| **IsFullWidth** | **bool?** | Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot. | [optional] |
| **ShowPercentageChange** | **bool?** | Indicates whether a widget should show the percentage diff between two values. | [optional] |
| **ShowProfilePicture** | **bool?** | Indicates whether a widget should show the profile picture of an agent. | [optional] |
| **Filter** | [**ViewFilter**](ViewFilter) | The filters to be applied for dashboard widget configuration | [optional] |
| **Periods** | **List&lt;string&gt;** | The list of periods for the dashboard widget configuration | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | The list of media types for the dashboard widget configuration | [optional] |
| **Warnings** | [**List&lt;Warning&gt;**](Warning) | List of warnings for dashboard widget configuration | [optional] |
| **ShowTimeInStatus** | **bool?** | Indicates the show time in status of a widget configuration. | [optional] |
| **ShowOfflineAgents** | **bool?** | Indicates to show offline agent widget. | [optional] |
| **SelectedStatuses** | **List&lt;string&gt;** | Indicates the selected statuses used to filter the agent widget in the dashboard. | [optional] |
| **AgentInteractionSortOrder** | **string** | The sort order of the interactions in the agent status widget. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
