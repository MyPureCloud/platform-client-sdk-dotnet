# JourneyViewJob

## ININ.PureCloudApi.Model.JourneyViewJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp of execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateCompleted** | **DateTime?** | Timestamp of completion. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Status** | **string** | The status of the job | |
| **JourneyView** | [**JourneyView**](JourneyView) | The journey view for which the job is executed | |
| **DateCompletionEstimated** | **DateTime?** | Timestamp for the estimated time of completion. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EstimatedCompletionMargin** | **long?** | Margin of error of the estimated time of completion | |
| **UserId** | **string** | Id of the user who submitted the request | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
