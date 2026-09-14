# UserActivity

## ININ.PureCloudApi.Model.UserActivity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the user | |
| **RoutingStatus** | [**UserActivityRoutingStatus**](UserActivityRoutingStatus) | The current routing status of the user | [optional] |
| **Presence** | [**UserActivityAdherencePresence**](UserActivityAdherencePresence) | The current system presence of the user | [optional] |
| **OutOfOffice** | [**UserActivityOutOfOffice**](UserActivityOutOfOffice) | The current out of office state of the user | [optional] |
| **ActiveQueueIds** | **List&lt;string&gt;** | The IDs of the queues for which the user is active | |
| **DateActiveQueuesChanged** | **DateTime?** | The date the activeQueueIds list was last modified. For reference only - subject to eventual consistency. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
