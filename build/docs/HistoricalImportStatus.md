# HistoricalImportStatus

## ININ.PureCloudApi.Model.HistoricalImportStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RequestId** | **string** | Request id of the historical import in the organization | [optional] |
| **DateImportEnded** | **DateTime?** | The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateImportStarted** | **DateTime?** | The first day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Status of the historical import in the organization. | [optional] |
| **Error** | **string** | Error occured if the status of the import is failed | [optional] |
| **DateCreated** | **DateTime?** | Date in which the historical import is initiated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date in which the historical import is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Active** | **bool?** | Whether this historical import is active or not | [optional] |
| **Type** | **string** | Whether this historical import is of type csv or json | [optional] |
| **FileName** | **string** | Name of the file that you are importing. | [optional] |
| **FileSize** | **long?** | Size of the file that you are importing. | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
