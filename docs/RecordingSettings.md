# RecordingSettings

## ININ.PureCloudApi.Model.RecordingSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaxSimultaneousStreams** | **int?** | Maximum number of simultaneous screen recording streams | [optional] |
| **MaxConfigurableScreenRecordingStreams** | **int?** | Upper limit that maxSimultaneousStreams can be configured | [optional] |
| **RegionalRecordingStorageEnabled** | **bool?** | Store call recordings in the region where they are intended to be recorded, otherwise in the organization&#39;s home region | [optional] |
| **RecordingPlaybackUrlTtl** | **int?** | The duration in minutes for which the generated URL for recording playback remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes. | [optional] |
| **RecordingBatchDownloadUrlTtl** | **int?** | The duration in minutes for which the generated URL for recording batch download remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes. | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
