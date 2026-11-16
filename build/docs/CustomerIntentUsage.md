# CustomerIntentUsage

## ININ.PureCloudApi.Model.CustomerIntentUsage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EntityType** | **string** | Whether the usage is for a customer intent or category | [optional] |
| **SourceType** | **string** | Type of the source using the customer intent or category | [optional] |
| **Source** | [**DomainEntityRef**](DomainEntityRef) | Source using the customer intent or category. The selfUri is included when the source type has an addressable Public API resource. | [optional] |
| **DateCreated** | **DateTime?** | Creation date of the usage. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
