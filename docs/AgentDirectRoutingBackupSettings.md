# AgentDirectRoutingBackupSettings

## ININ.PureCloudApi.Model.AgentDirectRoutingBackupSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup. | [optional] |
| **UserId** | **string** | ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup. | [optional] |
| **WaitForAgent** | **bool?** | Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup. | [optional] |
| **AgentWaitSeconds** | **int?** | Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]. | [optional] |
| **BackedUpUsers** | **List&lt;string&gt;** | Set of users that this user is a backup for. | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
