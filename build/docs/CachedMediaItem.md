# CachedMediaItem

## ININ.PureCloudApi.Model.CachedMediaItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique identifier for the cached media. | [optional] |
| **Url** | **string** | The URL that represents the external media that has been cached | [optional] |
| **DownloadUrl** | **string** | A URL to fetch the cached media | [optional] |
| **MediaType** | **string** | The media type for the URL | [optional] |
| **ContentLengthBytes** | **int?** | The content length of the media represented by the URL, in bytes. | [optional] |
| **DateCreated** | **DateTime?** | The date the cached item was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpires** | **DateTime?** | The date the cached item expires and will be removed from the cache. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
