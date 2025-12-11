# UpdateCapacityPlanRequest

## ININ.PureCloudApi.Model.UpdateCapacityPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the capacity plan | [optional] |
| **Description** | **string** | Description of the capacity plan | [optional] |
| **StartBusinessUnitDate** | **String** | The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **EndBusinessUnitDate** | **String** | The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Forecast** | [**ValueWrapperBuShortTermForecastReference**](ValueWrapperBuShortTermForecastReference) | The selected forecast for this capacity plan | [optional] |
| **FullTimeEquivalentWeeklyHours** | **double?** | The weekly hours used to calculate full time equivalent agents | [optional] |
| **UseLatestPlanningGroupStaffingGroupAssociation** | **bool?** | Whether to use latest staffing group to planning group association | [optional] |
| **Metadata** | [**CapacityPlanMetadata**](CapacityPlanMetadata) | The metadata of this capacity plan | |



_PureCloudPlatform.Client.V2 251.0.0_
