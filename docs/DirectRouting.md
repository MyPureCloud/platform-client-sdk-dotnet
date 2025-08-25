# DirectRouting

## ININ.PureCloudApi.Model.DirectRouting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CallMediaSettings** | [**DirectRoutingMediaSettings**](DirectRoutingMediaSettings) | Direct Routing Settings specific to Call media. | [optional] |
| **EmailMediaSettings** | [**DirectRoutingMediaSettings**](DirectRoutingMediaSettings) | Direct Routing Settings specific to Email media. | [optional] |
| **MessageMediaSettings** | [**DirectRoutingMediaSettings**](DirectRoutingMediaSettings) | Direct Routing Settings specific to Message media. | [optional] |
| **BackupQueueId** | **string** | ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation. | [optional] |
| **WaitForAgent** | **bool?** | Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup. | [optional] |
| **AgentWaitSeconds** | **int?** | Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
