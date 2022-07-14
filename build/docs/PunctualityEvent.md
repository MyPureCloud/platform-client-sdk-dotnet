---
title: PunctualityEvent
---
## ININ.PureCloudApi.Model.PunctualityEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateScheduleStart** | **DateTime?** | The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateStart** | **DateTime?** | The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthMinutes** | **int?** | The length of the activity in minutes | [optional] |
| **Description** | **string** | The description of the activity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this activity | [optional] |
| **ActivityCode** | **string** | The activity code | [optional] |
| **ActivityName** | **string** | The activity name | [optional] |
| **Category** | **string** | The category for the activity | [optional] |
| **Points** | **int?** | The points earned for this activity | [optional] |
| **Delta** | **double?** | Difference between this activity and the last activity in seconds | [optional] |
| **Bullseye** | **bool?** |  | [optional] |
{: class="table table-striped"}


