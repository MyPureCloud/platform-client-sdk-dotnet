# InfrastructureascodeJob

## ININ.PureCloudApi.Model.InfrastructureascodeJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DryRun** | **bool?** | Whether or not the job was a dry run | |
| **AcceleratorId** | **string** | Accelerator associated with the job | [optional] |
| **DateSubmitted** | **DateTime?** | Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SubmittedBy** | [**UserReference**](UserReference) | User who submitted the job | [optional] |
| **Status** | **string** | Job status | [optional] |
| **ErrorInfo** | [**ErrorInfo**](ErrorInfo) | Information about errors, if any | [optional] |
| **Results** | **string** | The output results of the terraform job | [optional] |
| **RollbackResults** | **string** | The results of rolling back the job if there were errors.  Not returned if job was successful. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
