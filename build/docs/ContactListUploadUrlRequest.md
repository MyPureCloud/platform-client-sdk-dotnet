# ContactListUploadUrlRequest

## ININ.PureCloudApi.Model.ContactListUploadUrlRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SignedUrlTimeoutSeconds** | **int?** | The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds | [optional] |
| **ContentType** | **string** | The content type of the file to upload. Allows MIME types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet | |
| **Id** | **string** | Id of your contact list to upload to | [optional] |
| **ContactIdName** | **string** | The column name from your file to use as the contact id. | [optional] |
| **ImportTemplateId** | **string** | Id of your import template to use. | [optional] |
| **ListNamePrefix** | **string** | String that will replace %N in the listNameFormat specified on the import template. | [optional] |
| **ClearSystemData** | **bool?** | Whether to clear system data | [optional] |
| **DivisionIdForTargetContactLists** | **string** | Id of the division to be used for the creation of the target contact lists. If not provided, Home division will be used. | [optional] |
| **FileSpecificationTemplateId** | **string** | File specification template ID | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
