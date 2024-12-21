# CreateManagementUnitApiRequest

## ININ.PureCloudApi.Model.CreateManagementUnitApiRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the management unit | |
| **TimeZone** | **string** | The default time zone to use for this management unit.  Moving to Business Unit | [optional] |
| **StartDayOfWeek** | **string** | The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit | [optional] |
| **Settings** | [**CreateManagementUnitSettingsRequest**](CreateManagementUnitSettingsRequest) | The configuration for the management unit.  If omitted, reasonable defaults will be assigned | [optional] |
| **DivisionId** | **string** | The id of the division to which this management unit belongs.  Defaults to home division ID | [optional] |
| **BusinessUnitId** | **string** | The id of the business unit to which this management unit belongs | |



_PureCloudPlatform.Client.V2 224.0.0_
