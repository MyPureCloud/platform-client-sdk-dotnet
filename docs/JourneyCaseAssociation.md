# JourneyCaseAssociation

## ININ.PureCloudApi.Model.JourneyCaseAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the association. | |
| **CaseReference** | **string** | The reference for the case that was associated with the journey session. | [optional] |
| **DateAssociated** | **DateTime?** | The date of the association. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Case** | [**AddressableEntityRef**](AddressableEntityRef) | The case that was associated with the journey session. | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
