# OutcomeAttributionJobStateResponse

## ININ.PureCloudApi.Model.OutcomeAttributionJobStateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | State of job. | [optional] |
| **ResultsUri** | **string** | URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running. | [optional] |
| **PercentFailedThreshold** | **int?** | Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
