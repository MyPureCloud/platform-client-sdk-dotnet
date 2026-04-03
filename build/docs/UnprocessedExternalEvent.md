# UnprocessedExternalEvent

## ININ.PureCloudApi.Model.UnprocessedExternalEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Event** | [**ExternalEvent**](ExternalEvent) | The event that failed processing. | |
| **OriginalRequestIndex** | **int?** | The index of the event in the original request. | |
| **IsRetryable** | **bool?** | Whether the error is retryable. | |
| **ErrorMessage** | **string** | The error message. | |
| **StatusCode** | **int?** | The HTTP status code associated with the error. | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
