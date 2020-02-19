---
title: ShortTermForecast
---
## ININ.PureCloudApi.Model.ShortTermForecast

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **WeekDate** | **string** | The weekDate of the short term forecast in yyyy-MM-dd format | |
| **Description** | **string** | The description of the short term forecast | [optional] |
| **CreationMethod** | **string** | The method used to create this forecast | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Metadata for this forecast | |
| **SourceData** | [**ListWrapperForecastSourceDayPointer**](ListWrapperForecastSourceDayPointer.html) | The source data references and metadata for this forecast | [optional] |
| **ReferenceStartDate** | **DateTime?** | ISO-8601 date that serves as the reference date for interval-based modifications | [optional] |
| **Modifications** | [**ListWrapperWfmForecastModification**](ListWrapperWfmForecastModification.html) | The modifications that have been applied to this forecast | [optional] |
| **GenerationResults** | [**ForecastGenerationResult**](ForecastGenerationResult.html) | Forecast generation results, if applicable | [optional] |
{: class="table table-striped"}


