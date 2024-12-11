# InteractionStatsRule

## ININ.PureCloudApi.Model.InteractionStatsRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule | |
| **Dimension** | **string** | The dimension of concern. | |
| **DimensionValue** | **string** | The value of the dimension. | |
| **Metric** | **string** | The metric to be assessed. | |
| **MediaType** | **string** | The media type. | |
| **NumericRange** | **string** | The comparison descriptor used against the metric&#39;s value. | |
| **Statistic** | **string** | The statistic of concern for the metric. | |
| **Value** | **double?** | The threshold value. | |
| **Enabled** | **bool?** | Indicates if the rule is enabled. | |
| **InAlarm** | **bool?** | Indicates if the rule is in alarm state. | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User) | The ids of users who will be notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
