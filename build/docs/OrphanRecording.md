# OrphanRecording

## ININ.PureCloudApi.Model.OrphanRecording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CreatedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RecoveredTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ProviderType** | **string** |  | [optional] |
| **MediaSizeBytes** | **long?** |  | [optional] |
| **MediaType** | **string** |  | [optional] |
| **MediaSubtype** | **string** |  | [optional] |
| **MediaSubject** | **string** |  | [optional] |
| **FileState** | **string** |  | [optional] |
| **ProviderEndpoint** | [**Endpoint**](Endpoint) |  | [optional] |
| **Recording** | [**Recording**](Recording) |  | [optional] |
| **OrphanStatus** | **string** | The status of the orphaned recording&#39;s conversation. | [optional] |
| **SourceOrphaningId** | **string** | An identifier used during recovery operations by the supplying hybrid platform to track back and determine which interaction this recording is associated with | [optional] |
| **Region** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
