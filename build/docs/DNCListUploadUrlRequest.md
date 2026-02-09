# DNCListUploadUrlRequest

## ININ.PureCloudApi.Model.DNCListUploadUrlRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SignedUrlTimeoutSeconds** | **int?** | The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds | [optional] |
| **ContentType** | **string** | The content type of the file to upload. Allows all types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet | |
| **Id** | **string** | Id of your dnc list to upload to | |
| **PhoneColumns** | **string** | The column names from your file from which to upload dnc phone numbers. | [optional] |
| **EmailColumns** | **string** | The column names from your file from which to upload dnc emails. | [optional] |
| **CustomExclusionColumns** | **string** | The column names from your file from which to upload dnc custom exclusion column entries. | [optional] |
| **ExpirationDateTimeColumn** | **string** | The column name from your file to use as the dnc expiration date time. | [optional] |
| **WhatsAppColumns** | **string** | The column names from your file from which to upload dnc whatsapp. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
