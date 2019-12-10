---
title: CreateManagementUnitApiRequest
---
## ININ.PureCloudApi.Model.CreateManagementUnitApiRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the management unit | |
| **TimeZone** | **string** | The default time zone to use for this management unit | |
| **StartDayOfWeek** | **string** | The configured first day of the week for scheduling and forecasting purposes | |
| **Settings** | [**CreateManagementUnitSettingsRequest**](CreateManagementUnitSettingsRequest.html) | The configuration for the management unit.  If omitted, reasonable defaults will be assigned | [optional] |
| **DivisionId** | **string** | The id of the division to which this management unit belongs.  Defaults to home division ID | [optional] |
{: class="table table-striped"}


