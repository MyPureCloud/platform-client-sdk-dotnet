# Recipient

## ININ.PureCloudApi.Model.Recipient

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Flow** | [**Flow**](Flow) | An automate flow object which defines the set of actions to be taken, when a message is received by this recipient. | [optional] |
| **DateCreated** | **DateTime?** | Date this recipient was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this recipient was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**User**](User) | User that created this recipient | [optional] |
| **ModifiedBy** | [**User**](User) | User that modified this recipient | [optional] |
| **MessengerType** | **string** | The messenger type for this recipient | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
