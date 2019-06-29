---
title: Manager
---
## ININ.PureCloudApi.Model.Manager

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DisplayName** | **string** | Display Name | [optional] |
| **Active** | **bool?** | Active flag | [optional] |
| **UserName** | **string** | User Name (Must be Unique) maps to PureCloud e-mail address | [optional] |
| **Password** | **string** | Password (updateOnly) | [optional] |
| **Title** | **string** | Title | [optional] |
| **PhoneNumbers** | [**List&lt;ScimPhoneNumber&gt;**](ScimPhoneNumber.html) | Phone numbers | [optional] |
| **Emails** | [**List&lt;ScimEmail&gt;**](ScimEmail.html) | Emails | [optional] |
| **Photos** | [**List&lt;Photo&gt;**](Photo.html) | Photos | [optional] |
| **ExternalId** | **string** | External ID | [optional] |
| **Groups** | [**List&lt;ScimV2GroupReference&gt;**](ScimV2GroupReference.html) | Group References | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) |  | [optional] |
| **Urnietfparamsscimschemasextensionenterprise20User** | [**ScimV2EnterpriseUser**](ScimV2EnterpriseUser.html) |  | [optional] |
| **Value** | **string** | Identifier of the Manager | [optional] |
| **_Ref** | **string** | Ref to entity | [optional] |
{: class="table table-striped"}


