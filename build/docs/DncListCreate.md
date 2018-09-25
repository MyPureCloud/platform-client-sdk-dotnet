---
title: DncListCreate
---
## ININ.PureCloudApi.Model.DncListCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the DncList. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | The status of the import process | [optional] |
| **Size** | **long?** | The total number of phone numbers in the DncList. | [optional] |
| **DncSourceType** | **string** | The type of the DncList. | |
| **LoginId** | **string** | A dnc.com loginId. Required if the dncSourceType is dnc.com. | [optional] |
| **DncCodes** | **List&lt;string&gt;** | The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com. | [optional] |
| **LicenseId** | **string** | A gryphon license number. Required if the dncSourceType is gryphon. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


