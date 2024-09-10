# StaCategory

## ININ.PureCloudApi.Model.StaCategory

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | The description of the category | [optional] |
| **InteractionType** | **string** | The type of interaction the category will apply to | |
| **Criteria** | [**Operand**](Operand) | A collection of conditions joined together by logical operation to provide more refined filtering of conversations | |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user who created the record | [optional] |
| **DateCreated** | **DateTime?** | The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user who last modified the record | [optional] |
| **DateModified** | **DateTime?** | The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
