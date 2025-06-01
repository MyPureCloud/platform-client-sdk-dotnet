# Disposition

## ININ.PureCloudApi.Model.Disposition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table.. | |
| **Analyzer** | **string** | The final media analyzer result that triggered the disposition result, if any. | [optional] |
| **DispositionParameters** | [**DispositionParameters**](DispositionParameters) | Contains various parameters related to call analysis. | [optional] |
| **DetectedSpeechStart** | **DateTime?** | Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DetectedSpeechEnd** | **DateTime?** | Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
