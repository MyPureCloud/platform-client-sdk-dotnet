---
title: ScimV2CreateUser
---
## ININ.PureCloudApi.Model.ScimV2CreateUser

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **Active** | **bool?** | Indicates whether the user&#39;s administrative status is active. | [optional] |
| **UserName** | **string** | The user&#39;s PureCloud email address. Must be unique. | |
| **DisplayName** | **string** | The display name of the user. | |
| **Password** | **string** | The new password for the PureCloud user. Does not return an existing password. | [optional] |
| **Title** | **string** | The user&#39;s title. | [optional] |
| **PhoneNumbers** | [**List&lt;ScimPhoneNumber&gt;**](ScimPhoneNumber.html) | The list of the user&#39;s phone numbers. | [optional] |
| **Emails** | [**List&lt;ScimEmail&gt;**](ScimEmail.html) | The list of the user&#39;s email addresses. | [optional] |
| **Photos** | [**List&lt;Photo&gt;**](Photo.html) | The list of the user&#39;s photos. | [optional] |
| **ExternalId** | **string** | The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;. | [optional] |
| **Groups** | [**List&lt;ScimV2GroupReference&gt;**](ScimV2GroupReference.html) | The list of groups that the user is a member of. | [optional] |
| **Roles** | **List&lt;string&gt;** | The list of roles assigned to the user. | [optional] |
| **Urnietfparamsscimschemasextensionenterprise20User** | [**ScimV2EnterpriseUser**](ScimV2EnterpriseUser.html) | The URI of the schema for the enterprise user. | [optional] |
{: class="table table-striped"}


