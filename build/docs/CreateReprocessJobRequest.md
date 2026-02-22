# CreateReprocessJobRequest

## ININ.PureCloudApi.Model.CreateReprocessJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name given for the job. | |
| **Description** | **string** | The description of the job. | [optional] |
| **DateStart** | **DateTime?** | The start date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateEnd** | **DateTime?** | The end date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Programs** | **List&lt;string&gt;** | A list of program IDs to filter conversations by. | |
| **MediaTypes** | **List&lt;string&gt;** | The types of conversations to reprocess. | |
| **Dialects** | **List&lt;string&gt;** | The dialects to filter by the conversations. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
