# DialerDnclistConfigChangeDncList

## ININ.PureCloudApi.Model.DialerDnclistConfigChangeDncList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ImportStatus** | [**DialerDnclistConfigChangeImportStatus**](DialerDnclistConfigChangeImportStatus) |  | [optional] |
| **Size** | **int?** | the number of phone numbers in the do not call list | [optional] |
| **DncSourceType** | **string** | the type of dnc list being created, rds (csv file), gryphon, or dnc.com | [optional] |
| **LoginId** | **string** | the loginId if the dncSourceType is dnc.com | [optional] |
| **DncCodes** | **List&lt;string&gt;** | the list of dnc.com codes to be treated as DNC | [optional] |
| **LicenseId** | **string** | the license number if the dncSourceType is gryphon | [optional] |
| **ContactMethod** | **string** |  | [optional] |
| **Division** | [**DialerDnclistConfigChangeUriReference**](DialerDnclistConfigChangeUriReference) |  | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
