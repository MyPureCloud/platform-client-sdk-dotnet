# V3SourceDetailedWithErrorResponse

## ININ.PureCloudApi.Model.V3SourceDetailedWithErrorResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the source. | [optional] |
| **ConnectionId** | **string** | The connectionId of the source. | [optional] |
| **Type** | **string** | The type of the source. | [optional] |
| **TriggerType** | **string** | The trigger type of the source. | [optional] |
| **Status** | **string** | The current status of the source. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the source. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who modified the document. | [optional] |
| **DateCreated** | **DateTime?** | Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastSync** | [**V3SourceLastSynchronization**](V3SourceLastSynchronization) | The last synchronization of the source. | [optional] |
| **ScheduleSettings** | [**V3SourceScheduleSettings**](V3SourceScheduleSettings) | Settings that determine when the source starts a sync. | [optional] |
| **Filters** | [**V3SourceFilter**](V3SourceFilter) | Filters that determine what documents are synced. | [optional] |
| **FilterDetails** | [**V3SourceFilterDetails**](V3SourceFilterDetails) | Additional details to the source&#39;s filters. | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Optional error details of an errored source. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
