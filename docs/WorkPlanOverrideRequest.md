# WorkPlanOverrideRequest

## ININ.PureCloudApi.Model.WorkPlanOverrideRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | **string** | The action to perform on work plan override, defaults to add | [optional] |
| **StartDate** | **String** | The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **WeekCount** | **int?** | The week count of the updated work plan, required if action is Add or Update | [optional] |
| **WorkPlanId** | **string** | The updated work plan id | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
