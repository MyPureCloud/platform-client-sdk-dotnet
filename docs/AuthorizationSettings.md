# AuthorizationSettings

## ININ.PureCloudApi.Model.AuthorizationSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **AnalysisEnabled** | **bool?** | Boolean showing if organization is opted in or not to unused role/perm analysis | [optional] |
| **AnalysisDays** | **int?** | Integer number of days to analyze user usage | [optional] |
| **DateLastCalculated** | **DateTime?** | The date and time of the most recent unused role calculation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateLastActive** | **String** | The date of the most recent org activity used for analysis. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
