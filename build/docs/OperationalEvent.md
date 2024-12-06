# OperationalEvent

## ININ.PureCloudApi.Model.OperationalEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventDefinition** | [**AddressableEntityRef**](AddressableEntityRef) | The event that occurred. | [optional] |
| **EntityId** | **string** | The unique identifier for the entity | [optional] |
| **EntityName** | **string** | The name for the entity | [optional] |
| **PreviousValue** | **string** | The value prior to the event | [optional] |
| **CurrentValue** | **string** | The changed value following the event | [optional] |
| **ErrorCode** | **string** | The error code of the entity in the providing service associated to the event | [optional] |
| **ParentEntityId** | **string** | The unique identifier for the parent of the entity | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The link to a conversation | [optional] |
| **DateCreated** | **DateTime?** | The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EntityVersion** | **string** | The version of the entity in the providing service | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
