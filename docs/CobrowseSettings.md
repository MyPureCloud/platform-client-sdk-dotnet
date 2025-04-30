# CobrowseSettings

## ININ.PureCloudApi.Model.CobrowseSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether or not cobrowse is enabled | [optional] |
| **AllowAgentControl** | **bool?** | Whether the viewer should have option to request control | [optional] |
| **AllowAgentNavigation** | **bool?** | Whether the viewer should have option to request navigation | [optional] |
| **AllowDraw** | **bool?** | Should cobrowse draw be enabled | [optional] |
| **MaskSelectors** | **List&lt;string&gt;** | Mask patterns that will apply to pages being shared | [optional] |
| **Channels** | **List&lt;string&gt;** | Cobrowse channels for web messenger | [optional] |
| **ReadonlySelectors** | **List&lt;string&gt;** | Readonly patterns that will apply to pages being shared | [optional] |
| **PauseCriteria** | [**List&lt;PauseCriteria&gt;**](PauseCriteria) | Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
