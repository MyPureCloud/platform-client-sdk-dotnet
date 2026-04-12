# MatchShiftTradeJobRequest

## ININ.PureCloudApi.Model.MatchShiftTradeJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekDate** | **String** | The start week date of the initiating shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **ReceivingSchedule** | [**ReceivingScheduleLookup**](ReceivingScheduleLookup) | Associated schedule information for the receiving user | |
| **ReceivingShiftId** | **string** | The ID of the shift the receiving user is giving up in trade, if applicable | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the shift trade | |



_PureCloudPlatform.Client.V2 262.0.0_
