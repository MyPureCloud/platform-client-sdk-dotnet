# SalesforceSourceResponse

## ININ.PureCloudApi.Model.SalesforceSourceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the source. | [optional] |
| **DateCreated** | **DateTime?** | Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Type** | **string** | The source type. | [optional] |
| **Integration** | [**KnowledgeIntegrationReference**](KnowledgeIntegrationReference) | The reference to the integration associated with the source. | [optional] |
| **SchedulePeriod** | **int?** | The schedule period of the source in hours. | [optional] |
| **LastSync** | [**SourceLastSync**](SourceLastSync) | Additional information about the last synchronization of the source. | [optional] |
| **Settings** | [**SalesforceSettings**](SalesforceSettings) | The settings of the source. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
