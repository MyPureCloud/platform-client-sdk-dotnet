# ExternalOrganizationIdentifier

## ININ.PureCloudApi.Model.ExternalOrganizationIdentifier

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to which this entity belongs. | [optional] |
| **Type** | **string** | The type of this identifier | |
| **Value** | **string** | The string value of the identifier. Will vary in syntax by type. Max: 255 characters. | |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalSource** | [**ExternalSource**](ExternalSource) | The External Source ID of the identifier | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
