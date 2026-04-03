# BulkUpdateShiftTradeListJobRequest

## ININ.PureCloudApi.Model.BulkUpdateShiftTradeListJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitIds** | **List&lt;string&gt;** | The IDs of the management units from which to update shift trades | |
| **WeekDates** | **List&lt;String&gt;** | The start week dates in which the shift trades being updated occur in the business unit time zone (yyyy-MM-dd format) | |
| **Entities** | [**List&lt;BulkUpdateShiftTradeStateRequestItem&gt;**](BulkUpdateShiftTradeStateRequestItem) | The shift trades that are being updated | |



_PureCloudPlatform.Client.V2 261.0.0_
