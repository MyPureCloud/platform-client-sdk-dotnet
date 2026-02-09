# FlowPaths

## ININ.PureCloudApi.Model.FlowPaths

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Category** | **string** | Category (use case) of the paths within a given domain. | |
| **DateStart** | **DateTime?** | Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnd** | **DateTime?** | End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Elements** | [**Dictionary&lt;string, FlowPathsElement&gt;**](FlowPathsElement) | Unique element identifiers and their corresponding elements in the trie data structure representing the paths. | |



_PureCloudPlatform.Client.V2 256.0.0_
