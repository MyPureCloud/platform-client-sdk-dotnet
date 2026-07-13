# EmailOutboundDomainResult

## ININ.PureCloudApi.Model.EmailOutboundDomainResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DnsCnameBounceRecord** | [**DnsRecordEntry**](DnsRecordEntry) |  | [optional] |
| **DnsTxtSendingRecord** | [**DnsRecordEntry**](DnsRecordEntry) |  | [optional] |
| **DomainName** | **string** |  | [optional] |
| **SenderStatus** | **string** |  | [optional] |
| **SenderType** | **string** |  | [optional] |
| **EmailSetting** | [**EmailSetting**](EmailSetting) | The email settings associated with this domain. | [optional] |
| **DmarcVerificationResult** | [**DmarcResult**](DmarcResult) | The DMARC verification status for this domain. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
