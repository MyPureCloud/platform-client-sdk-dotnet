---
title: HistoryEntry
---
## ININ.PureCloudApi.Model.HistoryEntry

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | **string** | The action performed | [optional] |
| **Resource** | **string** | For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name. | [optional] |
| **Timestamp** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **User** | [**User**](User.html) | User associated with this entry. | [optional] |
| **Client** | [**DomainEntityRef**](DomainEntityRef.html) | OAuth client associated with this entry. | [optional] |
| **Version** | **string** |  | [optional] |
| **Secure** | **bool?** |  | [optional] |
{: class="table table-striped"}


