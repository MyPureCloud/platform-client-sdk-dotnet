# CapacityPlanResponse

## ININ.PureCloudApi.Model.CapacityPlanResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | Description of the capacity plan | [optional] |
| **Forecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | The selected forecast for this capacity plan. Null when main forecast is used in the future | [optional] |
| **StartBusinessUnitDate** | **String** | The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EndBusinessUnitDate** | **String** | The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **FullTimeEquivalentWeeklyHours** | **double?** | The weekly hours used to calculate full time equivalent agents | |
| **Metadata** | [**CapacityPlanMetadata**](CapacityPlanMetadata) | The metadata of this capacity plan | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
