# Case

## ININ.PureCloudApi.Model.Case

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Case. | [optional] |
| **Division** | [**StarrableDivision**](StarrableDivision) | The division to which this entity belongs. | [optional] |
| **Version** | **int?** | The version of the Case. | [optional] |
| **Reference** | **string** | The reference identifier of the Case. | [optional] |
| **Caseplan** | [**CaseplanReference**](CaseplanReference) | The Caseplan the case was created from. | [optional] |
| **Summary** | **string** | Overview information for the Case. | [optional] |
| **Owner** | [**UserReference**](UserReference) | The owner of the Case. | [optional] |
| **Status** | **string** | The status of the Case. | [optional] |
| **Priority** | **string** | The priority of the Case. | [optional] |
| **DateDue** | **DateTime?** | The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateStarted** | **DateTime?** | The start time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateClosed** | **DateTime?** | The completion time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCreated** | **DateTime?** | The date the Case was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the Case was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The id of the User who modified the Case. | [optional] |
| **ExternalContact** | [**CaseExternalContactReference**](CaseExternalContactReference) | The External Contact associated with the Case. | [optional] |
| **CustomerIntent** | [**CustomerIntentReference**](CustomerIntentReference) | The customer intent for the Case. | [optional] |
| **CreationStatus** | **string** | The creation status of the Case | [optional] |
| **TtlSeconds** | **int?** | The time-to-live in seconds for the lifetime of the Case. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
