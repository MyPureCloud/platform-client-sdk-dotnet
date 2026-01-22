# ContestsCreateRequest

## ININ.PureCloudApi.Model.ContestsCreateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableDivision**](WritableDivision) | The division for this performance profile associate to. Only set for DEFAULT profile. | [optional] |
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
| **ProfileId** | **string** | The Contest profile | |
| **ParticipantIds** | **List&lt;string&gt;** | The Contest&#39;s participants | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
