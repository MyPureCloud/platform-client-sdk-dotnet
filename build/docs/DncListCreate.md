---
title: DncListCreate
---
## ININ.PureCloudApi.Model.DncListCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the list. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | the status of the import process | [optional] |
| **Size** | **long?** | the number of phone numbers in the do not call list | [optional] |
| **DncSourceType** | **string** | the type of dnc list being created, rds (csv file), gryphon, or dnc.com | [optional] |
| **LoginId** | **string** | the loginId if the dncSourceType is dnc.com | [optional] |
| **DncCodes** | **List&lt;string&gt;** | the list of dnc.com codes to be treated as DNC | [optional] |
| **LicenseId** | **string** | the license number if the dncSourceType is gryphon | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


