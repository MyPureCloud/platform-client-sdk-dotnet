# UpdateTimeOffPlanRequest

## ININ.PureCloudApi.Model.UpdateTimeOffPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of this time off plan. | [optional] |
| **ActivityCodeIds** | [**SetWrapperString**](SetWrapperString) | The set of activity code IDs to associate with this time off plan. | [optional] |
| **TimeOffLimitIds** | [**SetWrapperString**](SetWrapperString) | The set of time off limit IDs to associate with this time off plan. | [optional] |
| **AutoApprovalRule** | **string** | Auto approval rule for the time off plan. | [optional] |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | The number of days before the time off request start date for when the request will be expired from the waitlist. | [optional] |
| **HrisTimeOffType** | [**ValueWrapperHrisTimeOffType**](ValueWrapperHrisTimeOffType) | Time off type, if this time off plan is associated with the integration. | [optional] |
| **Active** | **bool?** | Whether this time off plan should be used by agents. | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the time off plan | |



_PureCloudPlatform.Client.V2 249.0.0_
