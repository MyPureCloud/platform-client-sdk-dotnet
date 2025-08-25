# EstimateAvailableTimeOffResponse

## ININ.PureCloudApi.Model.EstimateAvailableTimeOffResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FullDayDates** | [**List&lt;EstimateAvailableFullDayTimeOffResponse&gt;**](EstimateAvailableFullDayTimeOffResponse) | Full day dates. partialDayDates must be empty if this field is populated | [optional] |
| **PartialDayDates** | [**List&lt;EstimateAvailablePartialDayTimeOffResponse&gt;**](EstimateAvailablePartialDayTimeOffResponse) | Partial day dates. fullDayDates must be empty if this field is populated | [optional] |
| **User** | [**UserReference**](UserReference) | The user to whom the time off request belongs | |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category | |
| **Paid** | **bool?** | Whether this estimate is for a paid time off request | |



_PureCloudPlatform.Client.V2 240.0.0_
