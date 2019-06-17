---
title: ScimV2User
---
## ININ.PureCloudApi.Model.ScimV2User

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | SCIM Resource identifier | [optional] |
| **DisplayName** | **string** | Display Name | [optional] |
| **Schemas** | **List&lt;string&gt;** | schemas supported | [optional] |
| **Active** | **bool?** | Active flag | [optional] |
| **UserName** | **string** | User Name (Must be Unique) maps to PureCloud e-mail address | [optional] |
| **Password** | **string** | Password (updateOnly) | [optional] |
| **Title** | **string** | Title | [optional] |
| **PhoneNumbers** | [**List&lt;ScimPhoneNumber&gt;**](ScimPhoneNumber.html) | Phone numbers | [optional] |
| **Emails** | [**List&lt;ScimEmail&gt;**](ScimEmail.html) | Emails | [optional] |
| **Photos** | [**List&lt;Photo&gt;**](Photo.html) | Photos | [optional] |
| **Groups** | [**List&lt;ScimV2GroupReference&gt;**](ScimV2GroupReference.html) | Group References | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) |  | [optional] |
| **Urnietfparamsscimschemasextensionenterprise20User** | [**ScimV2EnterpriseUser**](ScimV2EnterpriseUser.html) |  | [optional] |
{: class="table table-striped"}


