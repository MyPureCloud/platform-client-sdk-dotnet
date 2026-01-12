# MatchCriteriaTestResult

## ININ.PureCloudApi.Model.MatchCriteriaTestResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **JsonPath** | **string** | The Goessner json path of the field to match | [optional] |
| **Operator** | **string** | The type of operation to perform for matching check | [optional] |
| **Value** | **Object** | The value to match on. Only one of value and values can be included | [optional] |
| **Values** | **List&lt;Object&gt;** | The list of values to match on. Only one of value and values can be included | [optional] |
| **GeneratedJsonPathCondition** | **string** | The generated json path condition | [optional] |
| **Match** | **bool?** | Did the generated json path condition match | [optional] |
| **JsonPathExtraction** | [**List&lt;MatchTestResult&gt;**](MatchTestResult) | The json paths and their values that were compared | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
