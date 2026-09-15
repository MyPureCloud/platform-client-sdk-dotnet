# Cluster

## ININ.PureCloudApi.Model.Cluster

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique ID of this cluster within its associated scan | [optional] |
| **Division** | [**StarrableDivision**](StarrableDivision) | The division all contacts in this cluster are associated to | [optional] |
| **ClusterScan** | [**ClusterScan**](ClusterScan) | The scan that this cluster belongs to | [optional] |
| **MergeInfo** | [**MergeInfo**](MergeInfo) | Information related to merge operations taken on this cluster | [optional] |
| **Graph** | [**Graph**](Graph) | The graph of contacts and identifiers that make up this cluster | [optional] |
| **DateCreated** | **DateTime?** | The date this cluster was discovered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
