# ContestsResponse

## ININ.PureCloudApi.Model.ContestsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableDivision**](WritableDivision) | The division for this performance profile associate to | [optional] |
| **Title** | **string** | The Contest title | |
| **Description** | **string** | The Contest description | |
| **DateStart** | **String** | Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **DateEnd** | **String** | End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **WinningCriteria** | **string** | The Contest winning criteria | |
| **DateAnnounced** | **DateTime?** | The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **AnnouncementTimezone** | **string** | The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | |
| **Anonymization** | **string** | The Contest anonymization | |
| **Metrics** | [**List&lt;ContestMetrics&gt;**](ContestMetrics) | The Contest&#39;s Metrics | |
| **Prizes** | [**List&lt;ContestPrizes&gt;**](ContestPrizes) | The Contest Prizes | |
| **Version** | **int?** | The Contest Version | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The creator of the contest | [optional] |
| **Profile** | [**ContestProfile**](ContestProfile) | The performance profile | [optional] |
| **Participants** | [**List&lt;UserReference&gt;**](UserReference) | The Contest&#39;s participants | [optional] |
| **Status** | **string** | The Contest status | [optional] |
| **ParticipantCount** | **int?** | The Number of participants in the contest | [optional] |
| **DateFinalized** | **DateTime?** | The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCancelled** | **DateTime?** | The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateScoresModified** | **DateTime?** | The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Winners** | [**List&lt;ContestWinners&gt;**](ContestWinners) | The Contest Winners | [optional] |
| **DisqualifiedAgents** | [**List&lt;ContestDisqualifiedAgents&gt;**](ContestDisqualifiedAgents) | The Contest&#39;s disqualified agents, returned when a contest is complete | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
