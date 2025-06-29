# CreateTimeOffPlanRequest

## ININ.PureCloudApi.Model.CreateTimeOffPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of this time off plan. | |
| **ActivityCodeIds** | **List&lt;string&gt;** | The set of activity code IDs to associate with this time off plan. | [optional] |
| **TimeOffLimitIds** | **List&lt;string&gt;** | The set of time off limit IDs to associate with this time off plan. | [optional] |
| **AutoApprovalRule** | **string** | Auto approval rule for the time off plan. | |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | The number of days before the time off request start date for when the request will be expired from the waitlist. | [optional] |
| **HrisTimeOffType** | [**HrisTimeOffType**](HrisTimeOffType) | Time off type, if this time off plan is associated with the integration. | [optional] |
| **Active** | **bool?** | Whether this time off plan should be used by agents. | |



_PureCloudPlatform.Client.V2 237.0.0_
