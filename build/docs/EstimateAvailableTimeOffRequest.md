---
title: EstimateAvailableTimeOffRequest
---
## ININ.PureCloudApi.Model.EstimateAvailableTimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FullDayDates** | [**List&lt;EstimateAvailableFullDayTimeOffRequest&gt;**](EstimateAvailableFullDayTimeOffRequest.html) | Full day dates. partialDayDates must be empty if this field is populated | [optional] |
| **PartialDayDates** | [**List&lt;EstimateAvailablePartialDayTimeOffRequest&gt;**](EstimateAvailablePartialDayTimeOffRequest.html) | Partial day dates. fullDayDates must be empty if this field is populated | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category | |
| **Paid** | **bool?** | Whether this estimate is for a paid time off request | |
{: class="table table-striped"}


