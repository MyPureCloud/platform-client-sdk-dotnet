# ContestsEssentials

## ININ.PureCloudApi.Model.ContestsEssentials

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Title** | **string** | The Contest title | |
| **Status** | **string** | The Contest status | [optional] |
| **DateStart** | **String** | Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **DateEnd** | **String** | End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Profile** | [**ContestProfile**](ContestProfile) | The performance profile | [optional] |
| **ParticipantCount** | **int?** | The Number of participants in the contest | [optional] |
| **DateAnnounced** | **DateTime?** | The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateFinalized** | **DateTime?** | The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCancelled** | **DateTime?** | The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateScoresModified** | **DateTime?** | The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Metrics** | [**List&lt;ContestMetrics&gt;**](ContestMetrics) | The Contest&#39;s Metrics | |
| **RequestingParticipantContestInfo** | [**ContestRequesingParticipantDailyInfo**](ContestRequesingParticipantDailyInfo) | The Most Recent Contest Info for the requesting participant | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
