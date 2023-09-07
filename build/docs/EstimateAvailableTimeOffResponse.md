---
title: EstimateAvailableTimeOffResponse
---
## ININ.PureCloudApi.Model.EstimateAvailableTimeOffResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FullDayDates** | [**List&lt;EstimateAvailableFullDayTimeOffResponse&gt;**](EstimateAvailableFullDayTimeOffResponse.html) | Full day dates. partialDayDates must be empty if this field is populated | [optional] |
| **PartialDayDates** | [**List&lt;EstimateAvailablePartialDayTimeOffResponse&gt;**](EstimateAvailablePartialDayTimeOffResponse.html) | Partial day dates. fullDayDates must be empty if this field is populated | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user to whom the time off request belongs | |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category | |
| **Paid** | **bool?** | Whether this estimate is for a paid time off request | |
{: class="table table-striped"}


