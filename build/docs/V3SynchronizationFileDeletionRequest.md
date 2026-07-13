# V3SynchronizationFileDeletionRequest

## ININ.PureCloudApi.Model.V3SynchronizationFileDeletionRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileId** | **string** | The identifier of the file to mark for deletion. Mutually exclusive with fileName. | [optional] |
| **FileName** | **string** | Name of the file to mark for deletion. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|. Mutually exclusive with fileId. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
