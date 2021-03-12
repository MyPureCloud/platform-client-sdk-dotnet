---
title: MetricDefinition
---
## ININ.PureCloudApi.Model.MetricDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UnitType** | **string** | The type of associated metric unit | [optional] |
| **ShortName** | **string** | An alternate name for this metric definition, often abbreviation | [optional] |
| **DividendMetrics** | **List&lt;string&gt;** | Metric names used as dividend | [optional] |
| **DivisorMetrics** | **List&lt;string&gt;** | Metric names used as divisor | [optional] |
| **DefaultObjective** | [**DefaultObjective**](DefaultObjective.html) | A predefined default objective for this metric | [optional] |
| **LockTemplateId** | **string** | An optional field to specify if this metric definition is locked to certain template. e.g. punctuality | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


