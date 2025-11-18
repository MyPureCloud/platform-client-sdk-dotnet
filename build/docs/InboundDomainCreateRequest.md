# InboundDomainCreateRequest

## ININ.PureCloudApi.Model.InboundDomainCreateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique Id of the domain such as: example.com | |
| **SubDomain** | **bool?** | Indicates if this a PureCloud sub-domain. If true, then the appropriate DNS records are created for sending/receiving email. | [optional] |
| **MailFromSettings** | [**MailFromResult**](MailFromResult) | The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false. | [optional] |
| **CustomSMTPServer** | [**DomainEntityRef**](DomainEntityRef) | The custom SMTP server integration to use when sending outbound emails from this domain. | [optional] |
| **EmailSetting** | [**EmailSettingReference**](EmailSettingReference) | The email settings to associate with this domain. | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
