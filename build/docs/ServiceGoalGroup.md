---
title: ServiceGoalGroup
---
## ININ.PureCloudApi.Model.ServiceGoalGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Goals** | [**ServiceGoalGroupGoals**](ServiceGoalGroupGoals.html) | Goals defined for this service goal group | [optional] |
| **QueueMediaAssociations** | [**List&lt;QueueMediaAssociation&gt;**](QueueMediaAssociation.html) | List of queues and media types from that queue to associate with this service goal group | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the list of service goal groups for the associated management unit | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


