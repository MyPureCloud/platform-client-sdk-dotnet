# ArchitectExportJobStateResponse

## ININ.PureCloudApi.Model.ArchitectExportJobStateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | Status of the Architect Export Job | [optional] |
| **Command** | **string** | The command executed by the Architect Job | [optional] |
| **DownloadUrl** | **string** | The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows. | [optional] |
| **Messages** | [**List&lt;ArchitectJobMessage&gt;**](ArchitectJobMessage) | Warnings and Errors messages of the Architect Job | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
