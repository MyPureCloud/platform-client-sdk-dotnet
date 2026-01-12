# OrgOAuthClient

## ININ.PureCloudApi.Model.OrgOAuthClient

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the OAuth client. | |
| **DateCreated** | **DateTime?** | Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User that created this client | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User that last modified this client | [optional] |
| **AuthorizedGrantType** | **string** | The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client.  | |
| **Scope** | **List&lt;string&gt;** | The scope requested by this client. Scopes only apply to clients not using the client_credential grant | [optional] |
| **RoleDivisions** | [**List&lt;RoleDivision&gt;**](RoleDivision) | Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant | [optional] |
| **State** | **string** | The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted. | [optional] |
| **DateToDelete** | **DateTime?** | The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Organization** | [**NamedEntity**](NamedEntity) | The  oauth client&#39;s organization. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
