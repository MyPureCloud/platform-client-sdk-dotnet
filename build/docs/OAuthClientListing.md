---
title: OAuthClientListing
---
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
| **RoleIds** | **List&lt;string&gt;** | Roles assigned to this client. Roles only apply to clients using the client_credential grant | [optional] |
| **DateCreated** | **DateTime?** | Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) | User that created this client | [optional] |
| **ModifiedBy** | [**UriReference**](UriReference.html) | User that last modified this client | [optional] |
| **Scope** | **List&lt;string&gt;** | The scope requested by this client | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


