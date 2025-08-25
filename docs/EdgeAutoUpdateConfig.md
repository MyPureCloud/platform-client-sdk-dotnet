# EdgeAutoUpdateConfig

## ININ.PureCloudApi.Model.EdgeAutoUpdateConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeZone** | **string** | The timezone of the window in which any updates to the edges assigned to the site can be applied. The minimum size of the window is 2 hours. | |
| **Rrule** | **string** | The recurrence rule for updating the Edges assigned to the site. The only supported frequencies are daily and weekly. Weekly frequencies require a day list with at least oneday specified. All other configurations are not supported. | |
| **Start** | **DateTime?** | Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS | |
| **End** | **DateTime?** | Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS | |



_PureCloudPlatform.Client.V2 240.0.0_
