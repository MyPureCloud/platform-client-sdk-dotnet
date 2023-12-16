---
title: BuForecastStaffingRequirementsResultResponse
---
## ININ.PureCloudApi.Model.BuForecastStaffingRequirementsResultResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BusinessUnitId** | **string** | The ID of the business unit to which the forecast staffing requirements belongs | |
| **Forecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference.html) | The forecast reference | |
| **ReferenceStartDate** | **DateTime?** | The reference start date for interval-based data for this forecast as an ISO-8601 string | |
| **WeekCount** | **int?** | The number of weeks in this forecast | |
| **IntervalLengthMinutes** | **int?** | The period/interval in minutes for which to aggregate the data | |
| **State** | **string** | The state of the staffing requirements generation | |
| **Results** | [**List&lt;BuForecastStaffingRequirementsResult&gt;**](BuForecastStaffingRequirementsResult.html) | The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39; | [optional] |
{: class="table table-striped"}


