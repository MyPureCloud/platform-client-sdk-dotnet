# ReprocessJobResponse

## ININ.PureCloudApi.Model.ReprocessJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | The description of the job. | [optional] |
| **DateStart** | **DateTime?** | The date from which the reprocessing should begin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateEnd** | **DateTime?** | The date at which the reprocessing should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **MediaTypes** | **List&lt;string&gt;** | Media types used to filter interactions. | |
| **Programs** | **List&lt;string&gt;** | The mapped programs to be included in the job. | |
| **Dialects** | **List&lt;string&gt;** | Language dialects used to filter interactions. | [optional] |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user who created the job. | |
| **DateCreated** | **DateTime?** | The date the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **JobStatus** | **string** | The status of the job. | |
| **QueueOrder** | **int?** | The position of the job in the queued jobs. | [optional] |
| **ProcessedInteractionsCount** | **int?** | The amount of interactions successfully reprocessed. | |
| **FailedInteractionsCount** | **int?** | The amount of failed interactions. | |
| **TotalInteractionsCount** | **int?** | The amount of interactions in the job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
