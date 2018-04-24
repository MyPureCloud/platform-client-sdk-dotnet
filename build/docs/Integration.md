---
title: Integration
---
## ININ.PureCloudApi.Model.Integration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the integration, used to distinguish this integration from others of the same type. | [optional] |
| **IntegrationType** | [**IntegrationType**](IntegrationType.html) | Type of the integration | [optional] |
| **Notes** | **string** | Notes about the integration. | [optional] |
| **IntendedState** | **string** | Configured state of the integration. | |
| **Config** | [**IntegrationConfigurationInfo**](IntegrationConfigurationInfo.html) | Configuration information for the integration. | [optional] |
| **ReportedState** | [**IntegrationStatusInfo**](IntegrationStatusInfo.html) | Last reported status of the integration. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | Read-only attributes for the integration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


