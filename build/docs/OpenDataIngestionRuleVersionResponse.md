# OpenDataIngestionRuleVersionResponse

## ININ.PureCloudApi.Model.OpenDataIngestionRuleVersionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the open data ingestion rule. | [optional] |
| **Name** | **string** | The name of the data ingestion rule. | [optional] |
| **Description** | **string** | A description of the data ingestion rule. | [optional] |
| **Status** | **string** | The status of the data ingestion rule. | [optional] |
| **Version** | **int?** | The version number of the data ingestion rule. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Platform** | **string** | The platform of the data ingestion rule. | [optional] |
| **ExternalSource** | [**DomainEntityRef**](DomainEntityRef) | The external source associated with this open data ingestion rule, which is used when performing identity resolution | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
