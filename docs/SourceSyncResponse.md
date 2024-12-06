# SourceSyncResponse

## ININ.PureCloudApi.Model.SourceSyncResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | Sync state. | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Sync error. | [optional] |
| **DateCreated** | **DateTime?** | Synchronization creation date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Synchronization last modification date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **KnowledgeBase** | [**AddressableEntityRef**](AddressableEntityRef) | Knowledge base to which this synchronization belongs. | [optional] |
| **Source** | [**AddressableEntityRef**](AddressableEntityRef) | Source to which this synchronization belongs. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
