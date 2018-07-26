---
title: OAuthClient
---
## ININ.PureCloudApi.Model.OAuthClient

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the OAuth client. | |
| **AccessTokenValiditySeconds** | **long?** | The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied. | [optional] |
| **Description** | **string** |  | [optional] |
| **RegisteredRedirectUri** | **List&lt;string&gt;** | List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback | [optional] |
| **Secret** | **string** | System created secret assigned to this client. Secrets are required for code authorization and client credential grants. | [optional] |
| **RoleIds** | **List&lt;string&gt;** | Roles assigned to this client. Roles only apply to clients using the client_credential grant | [optional] |
| **DateCreated** | **DateTime?** | Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) | User that created this client | [optional] |
| **ModifiedBy** | [**UriReference**](UriReference.html) | User that last modified this client | [optional] |
| **AuthorizedGrantType** | **string** | The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client.  | |
| **Scope** | **List&lt;string&gt;** | The scope requested by this client | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


