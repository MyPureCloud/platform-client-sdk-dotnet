# TimeAndDateSubConditionRange

## ININ.PureCloudApi.Model.TimeAndDateSubConditionRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Min** | **string** | The minimum value of the range. Required for the operator BETWEEN. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). | [optional] |
| **Max** | **string** | The maximum value of the range. Required for the operator BETWEEN. Format follows the same rules as &#39;min&#39;. | [optional] |
| **InSet** | **List&lt;string&gt;** | A set of values that the date/ time data should be in. Required for the IN operator. Format depends on type: dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, and/ or LAST_DAY, ODD_DAY, EVEN_DAY,specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
