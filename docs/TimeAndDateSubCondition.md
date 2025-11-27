# TimeAndDateSubCondition

## ININ.PureCloudApi.Model.TimeAndDateSubCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of time/date sub-condition. | [optional] |
| **Operator** | **string** | The operator to use for comparison. | [optional] |
| **Inverted** | **bool?** | If true, inverts the result of evaluating this sub-condition. Default is false. | [optional] |
| **IncludeYear** | **bool?** | If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. Only applicable for specificDate type. | [optional] |
| **ThresholdValue** | **string** | Threshold value for BEFORE or AFTER operators. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31 and/ or LAST_DAY, ODD_DAY, EVEN_DAY, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). For single-value comparison, use a list with one element. | [optional] |
| **Range** | [**TimeAndDateSubConditionRange**](TimeAndDateSubConditionRange) | A range of values for BETWEEN and IN operators. Format follows the same rules as &#39;thresholdValue&#39;. | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
