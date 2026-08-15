# CreateTimeOffPlanRequest

## ININ.PureCloudApi.Model.CreateTimeOffPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Deprecated. The name of this time off plan. | |
| **ActivityCodeIds** | **List&lt;string&gt;** | Deprecated. The set of activity code IDs to associate with this time off plan. | [optional] |
| **TimeOffLimitIds** | **List&lt;string&gt;** | Deprecated. The set of time off limit IDs to associate with this time off plan. | [optional] |
| **AutoApprovalRule** | **string** | Deprecated. Auto approval rule for the time off plan. | |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | Deprecated. The number of days before the time off request start date for when the request will be expired from the waitlist. | [optional] |
| **HrisTimeOffType** | [**HrisTimeOffType**](HrisTimeOffType) | Deprecated. Time off type, if this time off plan is associated with the integration. | [optional] |
| **Active** | **bool?** | Deprecated. Whether this time off plan should be used by agents. | |



_PureCloudPlatform.Client.V2 270.0.0_
