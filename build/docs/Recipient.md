---
title: Recipient
---
## ININ.PureCloudApi.Model.Recipient

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Flow** | [**Flow**](Flow.html) | An automate flow object which defines the set of actions to be taken, when a message is received by this provisioned phone number. | [optional] |
| **DateCreated** | **DateTime?** | Date this recipient was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date this recipient was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**User**](User.html) | User that created this recipient | [optional] |
| **ModifiedBy** | [**User**](User.html) | User that modified this recipient | [optional] |
| **MessengerType** | **string** | The messenger type for this recipient | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


