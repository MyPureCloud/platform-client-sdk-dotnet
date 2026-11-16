# OutboundBlendingSettings

## ININ.PureCloudApi.Model.OutboundBlendingSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether Enhanced Blending is enabled for the queue. | [optional] |
| **CampaignReservationPercentage** | **int?** | The proportion of on-queue agents to reserve for outbound campaign calls. Allowable range 1 - 100 (inclusive). | [optional] |
| **Active** | **bool?** | Whether Enhanced Blending is currently active for the queue. Only populated when getting a single queue with expand&#x3D;outboundblendingstatus. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
