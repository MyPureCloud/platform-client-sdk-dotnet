# HistoricalImportDeleteFilesJobResponse

## ININ.PureCloudApi.Model.HistoricalImportDeleteFilesJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The Job Id Request | [optional] |
| **State** | **string** | Property denoting the state of the remove request | [optional] |
| **Entities** | [**List&lt;HistoricalDataDeleteEntity&gt;**](HistoricalDataDeleteEntity) | The request entities that got deleted | [optional] |
| **DisallowedEntities** | [**List&lt;HistoricalDataDisallowedDeleteEntity&gt;**](HistoricalDataDisallowedDeleteEntity) | The request entities that were disallowed to be deleted | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
