# TerminateJob

## ININ.PureCloudApi.Model.TerminateJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The status of the Job. | [optional] |
| **JobType** | **string** | The type of the Job. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The ID of the User who created this Job. | [optional] |
| **DateCreated** | **DateTime?** | The job creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
