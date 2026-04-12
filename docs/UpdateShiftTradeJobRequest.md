# UpdateShiftTradeJobRequest

## ININ.PureCloudApi.Model.UpdateShiftTradeJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekDate** | **String** | The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Target** | [**ValueWrapperShiftTradeTargetRequestItem**](ValueWrapperShiftTradeTargetRequestItem) | Target of the shift trade, if applicable | [optional] |
| **ExpirationDate** | [**ValueWrapperDate**](ValueWrapperDate) | When this shift trade will expire. Date time is represented as an ISO-8601 string | [optional] |
| **AcceptableIntervals** | [**ListWrapperRequiredDateRange**](ListWrapperRequiredDateRange) | Time frames when the initiating user is willing to accept a shift in exchange. Setting the enclosed list to empty will make this a one sided trade request. | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the shift trade | |



_PureCloudPlatform.Client.V2 262.0.0_
