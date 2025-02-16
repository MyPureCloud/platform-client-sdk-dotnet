# ServiceNowSourceRequest

## ININ.PureCloudApi.Model.ServiceNowSourceRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the integration source. | |
| **IntegrationId** | **string** | The integration associated with the source. | [optional] |
| **SchedulePeriod** | **int?** | The schedule period of the source in hours. Must be at least 6 and at most 48 hours. | [optional] |
| **Settings** | [**ServiceNowSettings**](ServiceNowSettings) | The settings of the source. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
