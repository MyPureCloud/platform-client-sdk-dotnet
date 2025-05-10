# EdgeLogsJobRequest

## ININ.PureCloudApi.Model.EdgeLogsJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Path** | **string** | A relative directory to the root Edge log folder to query from. | [optional] |
| **Query** | **string** | The pattern to use when searching for logs, which may include the wildcards {*, ?}.  Multiple search patterns may be combined using a pipe &#39;|&#39; as a delimiter. | [optional] |
| **Recurse** | **bool?** | Boolean whether or not to recurse into directories. | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
