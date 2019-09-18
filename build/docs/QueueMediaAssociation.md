---
title: QueueMediaAssociation
---
## ININ.PureCloudApi.Model.QueueMediaAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The reference ID for this QueueMediaAssociation | [optional] |
| **Queue** | [**QueueReference**](QueueReference.html) | The queue to associate with the service goal group | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | The media types of the given queue to associate with the service goal group | [optional] |
| **Delete** | **bool?** | If marked true on a PATCH, this QueueMediaAssociation will be permanently deleted | [optional] |
{: class="table table-striped"}


