# AlternativeShiftSearchOffersRequest

## ININ.PureCloudApi.Model.AlternativeShiftSearchOffersRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schedule** | [**AlternativeShiftScheduleLookup**](AlternativeShiftScheduleLookup) | The existing schedule being used to find alternative shift offers | |
| **QueryWeekDate** | **String** | The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **InitiatingShift** | [**InitiatingAlternativeShift**](InitiatingAlternativeShift) | The shift a user puts up for alternative shift offers | |
| **AcceptableIntervals** | **List&lt;string&gt;** | The acceptable intervals in offers. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
