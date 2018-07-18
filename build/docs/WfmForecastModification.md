---
title: WfmForecastModification
---
## ININ.PureCloudApi.Model.WfmForecastModification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the modification | |
| **StartIntervalIndex** | **int?** | The number of 15 minute intervals past referenceStartDate representing the first interval to which to apply this modification. Must be null if values is populated | [optional] |
| **EndIntervalIndex** | **int?** | The number of 15 minute intervals past referenceStartDate representing the last interval to which to apply this modification.  Must be null if values is populated | [optional] |
| **Metric** | **string** | The metric to which this modification applies | |
| **Value** | **double?** | The value of the modification.  Must be null if \&quot;values\&quot; is populated | [optional] |
| **Values** | [**List&lt;WfmForecastModificationIntervalOffsetValue&gt;**](WfmForecastModificationIntervalOffsetValue.html) | The list of values to update.  Only applicable for grid-type modifications. Must be null if \&quot;value\&quot; is populated | [optional] |
| **Enabled** | **bool?** | Whether the modification is enabled for the forecast | |
| **Attributes** | [**WfmForecastModificationAttributes**](WfmForecastModificationAttributes.html) | The attributes defining how this modification applies to the forecast | |
{: class="table table-striped"}


