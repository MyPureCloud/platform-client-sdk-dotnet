---
title: OrgAuthSettings
---
## ININ.PureCloudApi.Model.OrgAuthSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MultifactorAuthenticationRequired** | **bool?** | Indicates whether multi-factor authentication is required. | [optional] |
| **DomainAllowlistEnabled** | **bool?** | Indicates whether the domain allowlist is enabled. | [optional] |
| **DomainAllowlist** | **List&lt;string&gt;** | The list of domains that will be allowed to embed Genesys Cloud applications. | [optional] |
| **IpAddressAllowlist** | **List&lt;string&gt;** | The list of IP addresses that will be allowed to authenticate with Genesys Cloud. | [optional] |
| **PasswordRequirements** | [**PasswordRequirements**](PasswordRequirements.html) | The password requirements for the organization. | [optional] |
{: class="table table-striped"}


