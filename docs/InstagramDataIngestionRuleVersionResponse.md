# InstagramDataIngestionRuleVersionResponse

## ININ.PureCloudApi.Model.InstagramDataIngestionRuleVersionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the Instagram data ingestion rule. | [optional] |
| **Name** | **string** | The name of the data ingestion rule. | [optional] |
| **Description** | **string** | A description of the data ingestion rule. | [optional] |
| **Status** | **string** | The status of the data ingestion rule. | [optional] |
| **Version** | **int?** | The version number of the data ingestion rule. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Platform** | **string** | The platform of the data ingestion rule. | [optional] |
| **Countries** | **List&lt;string&gt;** | The countries is available only on twitter data ingestion rule. ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide. | [optional] |
| **IntegrationId** | **string** | The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/instagram resource | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
