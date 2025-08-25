# SalesforceSourceRequest

## ININ.PureCloudApi.Model.SalesforceSourceRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the integration source. | |
| **IntegrationId** | **string** | The integration associated with the source. | [optional] |
| **SchedulePeriod** | **int?** | The schedule period of the source in hours. Must be at least 6 and at most 48 hours. | [optional] |
| **Settings** | [**SalesforceSettings**](SalesforceSettings) | The settings of the source. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
