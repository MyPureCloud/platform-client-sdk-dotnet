---
title: ScimV2User
---
## ININ.PureCloudApi.Model.ScimV2User

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | SCIM Resource identifier | [optional] |
| **Schemas** | **List&lt;string&gt;** | schemas supported | [optional] |
| **Active** | **bool?** | Indicates whether the user&#39;s administrative status is active. | [optional] |
| **UserName** | **string** | The user&#39;s PureCloud email address. Must be unique. | [optional] |
| **DisplayName** | **string** | The display name for the user. | [optional] |
| **Password** | **string** | A new password for a PureCloud user. Does not return an existing password. | [optional] |
| **Title** | **string** | The user&#39;s title. | [optional] |
| **PhoneNumbers** | [**List&lt;ScimPhoneNumber&gt;**](ScimPhoneNumber.html) | A list of the user&#39;s phone numbers. | [optional] |
| **Emails** | [**List&lt;ScimEmail&gt;**](ScimEmail.html) | A list of the user&#39;s email addresses. | [optional] |
| **Photos** | [**List&lt;Photo&gt;**](Photo.html) | A list of the user&#39;s photos. | [optional] |
| **ExternalId** | **string** | The external ID of the user. Set by the provisioning client. caseExact is set to true. mutability is set to readWrite. | [optional] |
| **Groups** | [**List&lt;ScimV2GroupReference&gt;**](ScimV2GroupReference.html) | A list of groups that the user is a member of. | [optional] |
| **Roles** | **List&lt;string&gt;** | Roles | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
| **Urnietfparamsscimschemasextensionenterprise20User** | [**ScimV2EnterpriseUser**](ScimV2EnterpriseUser.html) |  | [optional] |
{: class="table table-striped"}


