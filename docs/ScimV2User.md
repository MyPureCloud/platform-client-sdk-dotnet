# ScimV2User

## ININ.PureCloudApi.Model.ScimV2User

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;. | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **Active** | **bool?** | Indicates whether the user&#39;s administrative status is active. | [optional] |
| **UserName** | **string** | The user&#39;s Genesys Cloud email address. Must be unique. | [optional] |
| **DisplayName** | **string** | The display name of the user. | [optional] |
| **Password** | **string** | The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups. | [optional] |
| **Title** | **string** | The user&#39;s title. | [optional] |
| **PhoneNumbers** | [**List&lt;ScimPhoneNumber&gt;**](ScimPhoneNumber) | The list of the user&#39;s phone numbers. | [optional] |
| **Emails** | [**List&lt;ScimEmail&gt;**](ScimEmail) | The list of the user&#39;s email addresses. | [optional] |
| **ExternalId** | **string** | The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;. | [optional] |
| **Groups** | [**List&lt;ScimV2GroupReference&gt;**](ScimV2GroupReference) | The list of groups that the user is a member of. This list is immutable per SCIM RFC and may only be updated using the GROUPS resource endpoint. | [optional] |
| **Roles** | [**List&lt;ScimUserRole&gt;**](ScimUserRole) | The list of roles assigned to the user. | [optional] |
| **Urnietfparamsscimschemasextensionenterprise20User** | [**ScimV2EnterpriseUser**](ScimV2EnterpriseUser) | The URI of the schema for the enterprise user. | [optional] |
| **Urnietfparamsscimschemasextensiongenesyspurecloud20User** | [**ScimUserExtensions**](ScimUserExtensions) | The URI of the schema for the Genesys Cloud user. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata) | The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
