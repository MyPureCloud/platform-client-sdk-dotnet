# AlertSummaryEntity

## ININ.PureCloudApi.Model.AlertSummaryEntity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EntityType** | **string** | Specifies the type of entity being evaluated | |
| **User** | [**AddressableEntityRef**](AddressableEntityRef) | User id of the entity being monitored | [optional] |
| **Group** | [**AddressableEntityRef**](AddressableEntityRef) | Group id of the entity being monitored | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | Queue id of the entity being monitored | [optional] |
| **Team** | [**AddressableEntityRef**](AddressableEntityRef) | Team id of the entity being monitored | [optional] |
| **Alerting** | **bool?** | Flag that indicated if the entity is current causing the alert to be triggered | |



_PureCloudPlatform.Client.V2 231.1.0_
