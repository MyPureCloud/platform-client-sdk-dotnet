# ShiftTradeResponse

## ININ.PureCloudApi.Model.ShiftTradeResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of this shift trade | [optional] |
| **WeekDate** | **String** | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Schedule** | [**BuScheduleReferenceForMuRoute**](BuScheduleReferenceForMuRoute) | A reference to the associated schedule | [optional] |
| **State** | **string** | The state of this shift trade | [optional] |
| **InitiatingUser** | [**UserReference**](UserReference) | The user who initiated this trade | [optional] |
| **InitiatingShiftId** | **string** | The ID of the shift offered for trade by the initiating user | [optional] |
| **InitiatingShiftStart** | **DateTime?** | The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **InitiatingShiftEnd** | **DateTime?** | The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ReceivingWeekDate** | **String** | The start week date of the receiving shift in yyyy-MM-dd format for a cross-week shift trade or null otherwise. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **ReceivingUser** | [**UserReference**](UserReference) | The user matching the trade, or if the state is not &#39;Matched&#39;, the user to whom the trade request was sent | [optional] |
| **ReceivingShiftId** | **string** | The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift | [optional] |
| **ReceivingShiftStart** | **DateTime?** | The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ReceivingShiftEnd** | **DateTime?** | The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Expiration** | **DateTime?** | When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **OneSided** | **bool?** | Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return) | [optional] |
| **AcceptableIntervals** | **List&lt;string&gt;** | Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference) | The user who reviewed this shift trade. The id may be &#39;System&#39; if it was an automated process | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version data for this trade | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
