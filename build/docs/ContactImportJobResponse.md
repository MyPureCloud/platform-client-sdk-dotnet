# ContactImportJobResponse

## ININ.PureCloudApi.Model.ContactImportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** |  | [optional] |
| **StatusDetails** | **string** | Detailed description for JobStatus. | [optional] |
| **ExecutionStep** | **string** | Detailed description for the Job execution state | [optional] |
| **Metadata** | [**ContactImportJobMetadata**](ContactImportJobMetadata) | Metadata for the job | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Settings** | [**AddressableEntityRef**](AddressableEntityRef) | Settings | |



_PureCloudPlatform.Client.V2 224.1.0_
