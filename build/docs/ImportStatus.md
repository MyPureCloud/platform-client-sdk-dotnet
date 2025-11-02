# ImportStatus

## ININ.PureCloudApi.Model.ImportStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | current status of the import | |
| **TotalRecords** | **long?** | total number of records to be imported | |
| **CompletedRecords** | **long?** | number of records finished importing | |
| **PercentComplete** | **int?** | percentage of records finished importing | |
| **FailureReason** | **string** | if the import has failed, the reason for the failure | [optional] |
| **TargetContactListIds** | **List&lt;string&gt;** | The contact list Ids for target contact lists. | [optional] |
| **ListNamePrefix** | **string** | The prefix for the contact list name | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
