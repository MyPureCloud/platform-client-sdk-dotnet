# QueueUtilizationDiagnostic

## ININ.PureCloudApi.Model.QueueUtilizationDiagnostic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | Identifier of the queue | [optional] |
| **UsersInQueue** | **int?** | The number of users joined to the queue | [optional] |
| **ActiveUsersInQueue** | **int?** | The number of users active on the queue | [optional] |
| **UsersOnQueue** | **int?** | The number of users with a status of on-queue | [optional] |
| **UsersNotUtilized** | **int?** | The number of users in the queue currently not engaged | [optional] |
| **UsersOnQueueWithStation** | **int?** | The number of users in the queue with a station | [optional] |
| **UsersOnACampaignCall** | **int?** | The number of users currently engaged in a campaign call | [optional] |
| **UsersOnDifferentEdgeGroup** | **int?** | The number of users whose station is homed to an edge different from the campaign | [optional] |
| **UsersOnANonCampaignCall** | **int?** | The number of users currently engaged in a communication that is not part of the campaign | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
