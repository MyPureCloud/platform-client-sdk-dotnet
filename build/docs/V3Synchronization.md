# V3Synchronization

## ININ.PureCloudApi.Model.V3Synchronization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Type** | **string** | The type of the synchronization. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who started the synchronization if the source is manually synchronized or the user who created the source for scheduled synchronization. | [optional] |
| **Source** | [**V3SourceRef**](V3SourceRef) | The source of the synchronization. | [optional] |
| **DateStart** | **DateTime?** | The start time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnd** | **DateTime?** | The end time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateSourceIntervalStart** | **DateTime?** | The start time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateSourceIntervalEnd** | **DateTime?** | The end time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **TriggerType** | **string** | The trigger type of the synchronization. | [optional] |
| **Status** | **string** | The status of the synchronization. | [optional] |
| **Statistics** | [**V3SynchronizationStatistics**](V3SynchronizationStatistics) | Statistics of the synchronization. | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | The error that occurred during the synchronization. | [optional] |
| **IngestionStatus** | **string** | The status of the ingestion. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
