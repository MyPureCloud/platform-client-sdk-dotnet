# TranscriptsFilters

## ININ.PureCloudApi.Model.TranscriptsFilters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaType** | **string** | The media type of the transcripts, default value is all  | [optional] |
| **StartTimeMs** | **long?** | start time to filter by, default value is 7 days into the past | [optional] |
| **EndTimeMs** | **long?** | end time to filter by, default value is current time | [optional] |
| **Queues** | **List&lt;string&gt;** | list of queues ids to filter by | [optional] |
| **Flows** | **List&lt;string&gt;** | list of flows ids to filter by | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
