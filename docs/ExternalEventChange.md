# ExternalEventChange

## ININ.PureCloudApi.Model.ExternalEventChange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ChangeCategory** | **string** | The category of the change | [optional] |
| **SchemaId** | **string** | The unique identifier for the schema | [optional] |
| **EventName** | **string** | The name of the event | [optional] |
| **DateDetected** | **DateTime?** | The timestamp when the change was detected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SystemStatus** | **string** | The status of the change | [optional] |
| **ErrorCode** | **string** | A code representing the error, only present for ERROR category changes | [optional] |
| **ErrorDescription** | **string** | A description of the error, only present for ERROR category changes | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
