---
title: AlertSummaryEntity
---
## ININ.PureCloudApi.Model.AlertSummaryEntity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EntityType** | **string** | Specifies the type of entity being evaluated | |
| **User** | [**AddressableEntityRef**](AddressableEntityRef.html) | User id of the entity being monitored | [optional] |
| **Group** | [**AddressableEntityRef**](AddressableEntityRef.html) | Group id of the entity being monitored | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef.html) | Queue id of the entity being monitored | [optional] |
| **Team** | [**AddressableEntityRef**](AddressableEntityRef.html) | Team id of the entity being monitored | [optional] |
| **Alerting** | **bool?** | Flag that indicated if the entity is current causing the alert to be triggered | |
{: class="table table-striped"}


