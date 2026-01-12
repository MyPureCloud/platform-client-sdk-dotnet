# JourneyView

## ININ.PureCloudApi.Model.JourneyView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | A description of the journey view | [optional] |
| **Version** | **int?** | The version of the journey view | [optional] |
| **CreatedBy** | [**JourneyViewUser**](JourneyViewUser) | User that has created the view. | [optional] |
| **ModifiedBy** | [**JourneyViewUser**](JourneyViewUser) | User that has modified the view. | [optional] |
| **Interval** | **string** | An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **Duration** | **string** | A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | [optional] |
| **Elements** | [**List&lt;JourneyViewElement&gt;**](JourneyViewElement) | The elements within the journey view | |
| **Charts** | [**List&lt;JourneyViewChart&gt;**](JourneyViewChart) | A list of charts to measure within context of the elements of the the journey view | [optional] |
| **DateCreated** | **DateTime?** | The date when the journey view was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date when this version of the journey view was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
