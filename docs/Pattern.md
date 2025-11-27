# Pattern

## ININ.PureCloudApi.Model.Pattern

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Pattern type (Daily/Weekly) | |
| **Interval** | **int?** | The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly | |
| **DaysOfWeek** | **List&lt;string&gt;** | The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\&quot;Monday\&quot;, \&quot;Wednesday\&quot;] | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
