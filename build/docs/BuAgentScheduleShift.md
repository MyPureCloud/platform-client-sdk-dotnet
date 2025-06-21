# BuAgentScheduleShift

## ININ.PureCloudApi.Model.BuAgentScheduleShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the shift | [optional] |
| **StartDate** | **DateTime?** | The start date of this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthMinutes** | **int?** | The length of this shift in minutes | [optional] |
| **Activities** | [**List&lt;BuAgentScheduleActivity&gt;**](BuAgentScheduleActivity) | The activities associated with this shift | [optional] |
| **ManuallyEdited** | **bool?** | Whether this shift was manually edited. This is only set by clients and is used for rescheduling | [optional] |
| **Schedule** | [**BuScheduleReference**](BuScheduleReference) | The schedule to which this shift belongs | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
