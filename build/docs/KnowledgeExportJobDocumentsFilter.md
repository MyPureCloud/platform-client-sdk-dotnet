# KnowledgeExportJobDocumentsFilter

## ININ.PureCloudApi.Model.KnowledgeExportJobDocumentsFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **Entities** | [**List&lt;Entity&gt;**](Entity) | Retrieves the documents with the given ids. Cannot be used together with internal filter. | [optional] |
| **SourceId** | **string** |  | [optional] |
| **IncludeDocumentsWithFileBody** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
