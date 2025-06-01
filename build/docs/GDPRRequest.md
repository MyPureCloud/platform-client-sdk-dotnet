# GDPRRequest

## ININ.PureCloudApi.Model.GDPRRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | The user that created this request | |
| **ReplacementTerms** | [**List&lt;ReplacementTerm&gt;**](ReplacementTerm) | The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request | [optional] |
| **RequestType** | **string** | The type of GDPR request | |
| **CreatedDate** | **DateTime?** | When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Status** | **string** | The status of the request | |
| **Subject** | [**GDPRSubject**](GDPRSubject) | The subject of the GDPR request | |
| **ResultsUrl** | **string** | The location where the results of the request can be retrieved | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
