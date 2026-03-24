# CampaignDiagnosticSummary

## ININ.PureCloudApi.Model.CampaignDiagnosticSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignId** | **string** | Campaign ID | [optional] |
| **DateStart** | **DateTime?** | Start of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnd** | **DateTime?** | End of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CampaignStates** | [**List&lt;CampaignDiagnosticCampaignState&gt;**](CampaignDiagnosticCampaignState) | Array of campaign states | [optional] |
| **CampaignInfo** | [**List&lt;CampaignDiagnosticWindow&gt;**](CampaignDiagnosticWindow) | Array of diagnostic windows | [optional] |
| **CampaignHealthStates** | [**List&lt;CampaignDiagnosticCampaignHealthState&gt;**](CampaignDiagnosticCampaignHealthState) | Array of campaign health states | [optional] |
| **ConfigChanges** | [**List&lt;CampaignDiagnosticConfigChange&gt;**](CampaignDiagnosticConfigChange) | Configuration changes occurring within the time window | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
