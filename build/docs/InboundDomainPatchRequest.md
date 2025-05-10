# InboundDomainPatchRequest

## ININ.PureCloudApi.Model.InboundDomainPatchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MailFromSettings** | [**MailFromResult**](MailFromResult) | The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false. | [optional] |
| **CustomSMTPServer** | [**DomainEntityRef**](DomainEntityRef) | The custom SMTP server integration to use when sending outbound emails from this domain. | [optional] |
| **ImapSettings** | [**ImapSettings**](ImapSettings) | The IMAP server integration and settings to use for processing inbound emails. | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
