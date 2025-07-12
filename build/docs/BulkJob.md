# BulkJob

## ININ.PureCloudApi.Model.BulkJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The bulk job state. | [optional] |
| **Action** | **string** | The bulk job action. This determines what the bulk job does, for example, terminate workitems. | [optional] |
| **TotalCount** | **int?** | Total count of items to be processed in the bulk job. | [optional] |
| **SuccessfulCount** | **int?** | Count of successfully processed items in the bulk job. | [optional] |
| **FailedCount** | **int?** | Count of failed processed items in the bulk job. | [optional] |
| **DateStarted** | **DateTime?** | The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateFinished** | **DateTime?** | The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
