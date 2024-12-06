# InteractionStatsAlert

## ININ.PureCloudApi.Model.InteractionStatsAlert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the rule that generated the alert | |
| **Dimension** | **string** | The dimension of concern. | |
| **DimensionValue** | **string** | The value of the dimension. | |
| **Metric** | **string** | The metric to be assessed. | |
| **MediaType** | **string** | The media type. | |
| **NumericRange** | **string** | The comparison descriptor used against the metric&#39;s value. | |
| **Statistic** | **string** | The statistic of concern for the metric. | |
| **Value** | **double?** | The threshold value. | |
| **RuleId** | **string** | The id of the rule. | |
| **Unread** | **bool?** | Indicates if the alert has been read. | |
| **StartDate** | **DateTime?** | The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndDate** | **DateTime?** | The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NotificationUsers** | [**List&lt;User&gt;**](User) | The ids of users who were notified of alarm state change. | |
| **AlertTypes** | **List&lt;string&gt;** | A collection of notification methods. | |
| **RuleUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
