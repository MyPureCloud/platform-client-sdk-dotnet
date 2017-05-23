---
title: EncryptionKey
---
## ININ.PureCloudApi.Model.EncryptionKey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CreateDate** | **DateTime?** | create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **KeydataSummary** | **string** | key data summary (base 64 encoded public key) | [optional] |
| **User** | [**User**](User.html) | user that requested generation of public key | [optional] |
| **LocalEncryptionConfiguration** | [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html) | Local configuration | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


