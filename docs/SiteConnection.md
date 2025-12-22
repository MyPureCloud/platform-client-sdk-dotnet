# SiteConnection

## ININ.PureCloudApi.Model.SiteConnection

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **SelfUri** | **string** |  | [optional] |
| **Managed** | **bool?** |  | [optional] |
| **Type** | **string** | Connection method from site to site (Direct, Indirect, CloudProxy | [optional] |
| **Enabled** | **bool?** | Indicates if the current site is linked | [optional] |
| **MediaModel** | **string** | Media model for the current site. | [optional] |
| **EdgeList** | [**List&lt;ConnectedEdge&gt;**](ConnectedEdge) | All of the edges to which the site connects | [optional] |
| **CoreSite** | **bool?** | The core site | [optional] |
| **PrimaryCoreSites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | List of site ids names and selfUris for the primary core sites | [optional] |
| **SecondaryCoreSites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | List of site ids names and selfUris for the secondary core sites | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
