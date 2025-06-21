# CampaignOutboundLinesDistribution

## ININ.PureCloudApi.Model.CampaignOutboundLinesDistribution

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaign** | [**AddressableEntityRef**](AddressableEntityRef) | The Campaign for which dialing group distribution information was requested | [optional] |
| **MaxOutboundLineCount** | **int?** | Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site | [optional] |
| **MaxLineUtilization** | **double?** | Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity | [optional] |
| **AvailableOutboundLines** | **int?** | Number of available outbound lines in Campaign&#39;s Edge Group or Site | [optional] |
| **ReservedLines** | **int?** | Number of reserved outbound lines in Campaign&#39;s Edge Group or Site | [optional] |
| **CampaignsWithReservedLines** | [**List&lt;CampaignOutboundLinesReservation&gt;**](CampaignOutboundLinesReservation) | Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site | [optional] |
| **CampaignsWithDynamicallyAllocatedLines** | [**List&lt;CampaignOutboundLinesAllocation&gt;**](CampaignOutboundLinesAllocation) | Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
