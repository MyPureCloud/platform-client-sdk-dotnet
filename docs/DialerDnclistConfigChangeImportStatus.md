# DialerDnclistConfigChangeImportStatus

## ININ.PureCloudApi.Model.DialerDnclistConfigChangeImportStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ImportState** | **string** | current status of the import | [optional] |
| **TotalRecords** | **long?** | total number of records to be imported | [optional] |
| **CompletedRecords** | **long?** | number of records finished importing | [optional] |
| **PercentageComplete** | **long?** | percentage of records finished importing | [optional] |
| **FailureReason** | **string** | if the import has failed, the reason for the failure | [optional] |
| **TargetContactListIds** | **List&lt;string&gt;** | The ids for target contact lists | [optional] |
| **ListNamePrefix** | **string** | The prefix used for target contact list names | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
