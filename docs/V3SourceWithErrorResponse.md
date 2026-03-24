# V3SourceWithErrorResponse

## ININ.PureCloudApi.Model.V3SourceWithErrorResponse

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
| **Error** | [**ErrorBody**](ErrorBody) | Optional error details of an errored source. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
