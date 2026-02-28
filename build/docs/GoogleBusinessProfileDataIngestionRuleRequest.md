# GoogleBusinessProfileDataIngestionRuleRequest

## ININ.PureCloudApi.Model.GoogleBusinessProfileDataIngestionRuleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the data ingestion rule. | |
| **Description** | **string** | A description of the data ingestion rule. | [optional] |
| **IntegrationId** | **string** | The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource | |
| **ExternalSource** | [**DomainEntityRef**](DomainEntityRef) | The external source associated with this data ingestion rule, which will be used when performing identity resolution | |



_PureCloudPlatform.Client.V2 258.0.0_
