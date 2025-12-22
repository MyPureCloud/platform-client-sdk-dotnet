# ExternalOrganizationTrustorLink

## ININ.PureCloudApi.Model.ExternalOrganizationTrustorLink

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to which this entity belongs. | [optional] |
| **ExternalOrganizationId** | **string** | The id of a PureCloud External Organization entity in the External Contacts system that will be used to represent the trustor org | [optional] |
| **TrustorOrgId** | **string** | The id of a PureCloud organization that has granted trust to this PureCloud organization | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalOrganizationUri** | **string** | The URI for the External Organization that is linked to the trustor org | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
