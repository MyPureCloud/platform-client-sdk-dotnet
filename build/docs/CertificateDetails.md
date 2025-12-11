# CertificateDetails

## ININ.PureCloudApi.Model.CertificateDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Issuer** | **string** | Information about the issuer of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500. | [optional] |
| **Subject** | **string** | Information about the subject of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500. | [optional] |
| **ExpirationDate** | **DateTime?** | The expiration date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IssueDate** | **DateTime?** | The issue date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Expired** | **bool?** | True if the certificate is expired, false otherwise. | [optional] |
| **SignatureValid** | **bool?** |  | [optional] |
| **Valid** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
