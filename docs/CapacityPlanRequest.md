# CapacityPlanRequest

## ININ.PureCloudApi.Model.CapacityPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the capacity plan | |
| **Description** | **string** | Description of the capacity plan | [optional] |
| **StartBusinessUnitDate** | **String** | The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EndBusinessUnitDate** | **String** | The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Forecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | The selected forecast for this capacity plan. Null when main forecast is used in the future | |
| **FullTimeEquivalentWeeklyHours** | **double?** | The weekly hours used to calculate full time equivalent agents | |
| **StaffingGroupAllocations** | [**List&lt;CreateStaffingGroupAllocation&gt;**](CreateStaffingGroupAllocation) | List of staffing group allocations to be used for the capacity plan | |



_PureCloudPlatform.Client.V2 250.0.0_
