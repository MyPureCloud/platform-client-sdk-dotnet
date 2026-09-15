# EdgeOfflineConfiguration

## ININ.PureCloudApi.Model.EdgeOfflineConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PairingId** | **string** | The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000. | |
| **Network** | [**EdgeOfflineConfigurationNetwork**](EdgeOfflineConfigurationNetwork) | Network settings for your hardware Edge. | |
| **UseVerificationCode** | **bool?** | Boolean to know if the verification code will be used to provision the Edge. Only used if the Edge is being provisioned. | [optional] |
| **CertType** | **string** | The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site&#39;s Location is in China. | [optional] |
| **Site** | [**DomainEntityRef**](DomainEntityRef) | The Site that will be associated to the Edge. Required if the Edge is being provisioned. | [optional] |
| **Proxy** | **string** | Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
