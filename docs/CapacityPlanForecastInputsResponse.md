# CapacityPlanForecastInputsResponse

## ININ.PureCloudApi.Model.CapacityPlanForecastInputsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which the capacity plan forecast inputs belongs | |
| **CapacityPlan** | [**CapacityPlanReference**](CapacityPlanReference) | The capacity plan associated with these forecast inputs | |
| **DownloadUrl** | **string** | The URL to get the forecast inputs for the capacity plan | |
| **DownloadTemplate** | [**CapacityPlanForecastInputsTemplate**](CapacityPlanForecastInputsTemplate) | Forecast inputs always come through downloadUrl, the schema included here is just for documentation | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
