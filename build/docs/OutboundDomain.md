---
title: OutboundDomain
---
## ININ.PureCloudApi.Model.OutboundDomain

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique Id of the domain such as: example.com | |
| **Name** | **string** |  | [optional] |
| **CnameVerificationResult** | [**VerificationResult**](VerificationResult.html) | CNAME registration Status | [optional] |
| **DkimVerificationResult** | [**VerificationResult**](VerificationResult.html) | DKIM registration Status | [optional] |
| **FromEmail** | [**EmailAddress**](EmailAddress.html) | The email that is used to display sender informations | [optional] |
| **ReplyToEmail** | [**EmailAddress**](EmailAddress.html) | The email that is used if replies are expected | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


