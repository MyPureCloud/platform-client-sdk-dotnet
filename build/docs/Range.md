# Range

## ININ.PureCloudApi.Model.Range

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences) | |
| **End** | **string** | The end date time of the last occurrence of the range as an ISO-8601 string. Required for EndDate range type. | [optional] |
| **NumberOfOccurrences** | **int?** | The number of times the schedule will be repeated, e.g: 2. Required to set for Numbered range type. | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
