# TwitterDataIngestionRuleResponse

## ININ.PureCloudApi.Model.TwitterDataIngestionRuleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the data ingestion rule. | [optional] |
| **Name** | **string** | The name of the data ingestion rule. | [optional] |
| **Description** | **string** | A description of the data ingestion rule. | [optional] |
| **Status** | **string** | The status of the data ingestion rule. | [optional] |
| **Version** | **int?** | The version number of the data ingestion rule. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Platform** | **string** | The platform of the data ingestion rule. | [optional] |
| **SearchTerms** | **string** | Search terms for X (formally Twitter). | [optional] |
| **Countries** | **List&lt;string&gt;** | ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
