# SessionMetaDataResult

## ININ.PureCloudApi.Model.SessionMetaDataResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SessionInfo** | [**SessionInfo**](SessionInfo) | Information about the continuous forecast session | [optional] |
| **Snapshots** | [**List&lt;Snapshots&gt;**](Snapshots) | Captured snapshots | [optional] |
| **DateForecastStart** | **DateTime?** | Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateHistoricalStart** | **DateTime?** | Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AggregateOfferedHistoricalAvailability** | [**AggregateHistoricalAvailability**](AggregateHistoricalAvailability) | Total historical availability for offered metric across all planning groups | [optional] |
| **AggregateAverageHandleTimeHistoricalAvailability** | [**AggregateHistoricalAvailability**](AggregateHistoricalAvailability) | Total historical availability for average handle time metric across all planning groups | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
