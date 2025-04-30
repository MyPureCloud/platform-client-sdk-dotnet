# CampaignSequence

## ININ.PureCloudApi.Model.CampaignSequence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Campaigns** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The ordered list of Campaigns that this CampaignSequence will run. | |
| **CurrentCampaign** | **int?** | A zero-based index indicating which Campaign this CampaignSequence is currently on. | |
| **Status** | **string** | The current status of the CampaignSequence. A CampaignSequence can be turned &#39;on&#39; or &#39;off&#39;. | |
| **StopMessage** | **string** | A message indicating if and why a CampaignSequence has stopped unexpectedly. | [optional] |
| **Repeat** | **bool?** | Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
