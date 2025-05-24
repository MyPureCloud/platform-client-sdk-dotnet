# WorkitemQueryJobResponse

## ININ.PureCloudApi.Model.WorkitemQueryJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The state of the query job | [optional] |
| **DateStarted** | **DateTime?** | The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateFinished** | **DateTime?** | The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Error** | [**WorkitemQueryJobError**](WorkitemQueryJobError) | The error associated with the query job, if the state is Failed | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
