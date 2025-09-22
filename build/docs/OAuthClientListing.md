# OAuthClientListing

## ININ.PureCloudApi.Model.OAuthClientListing

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the OAuth client. | |
| **AccessTokenValiditySeconds** | **long?** | The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied. | [optional] |
| **Description** | **string** |  | [optional] |
| **RegisteredRedirectUri** | **List&lt;string&gt;** | List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback | [optional] |
| **Secret** | **string** | System created secret assigned to this client. Secrets are required for code authorization and client credential grants. | [optional] |
| **RoleIds** | **List&lt;string&gt;** | Deprecated. Use roleDivisions instead. | [optional] |
| **DateCreated** | **DateTime?** | Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User that created this client | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User that last modified this client | [optional] |
| **Scope** | **List&lt;string&gt;** | The scope requested by this client. Scopes only apply to clients not using the client_credential grant | [optional] |
| **RoleDivisions** | [**List&lt;RoleDivision&gt;**](RoleDivision) | Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant | [optional] |
| **State** | **string** | The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted. | [optional] |
| **DateToDelete** | **DateTime?** | The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
