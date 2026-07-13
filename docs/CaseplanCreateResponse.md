# CaseplanCreateResponse

## ININ.PureCloudApi.Model.CaseplanCreateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Caseplan. | |
| **Division** | [**StarrableDivision**](StarrableDivision) | The division to which this Caseplan belongs. | |
| **Description** | **string** | The description of the Caseplan. | [optional] |
| **ReferencePrefix** | **string** | The prefix used when creating the reference for Cases from the Caseplan. | |
| **DefaultDueDurationInSeconds** | **int?** | The default due duration in seconds for Cases created from the Caseplan. | |
| **DefaultTtlSeconds** | **int?** | The default TTL in seconds for Cases created from the Caseplan. | |
| **DefaultCaseOwner** | [**UserReference**](UserReference) | The default Case owner for Cases created from the Caseplan. | [optional] |
| **Latest** | **int?** | The latest version of the Caseplan. | |
| **Published** | **int?** | The published version of the Caseplan. | [optional] |
| **DateCreated** | **DateTime?** | The Caseplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateModified** | **DateTime?** | The Caseplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DatePublished** | **DateTime?** | The Caseplan publication date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The ID of the User who modified the Caseplan. | |
| **CustomerIntent** | [**CustomerIntentReference**](CustomerIntentReference) | The customer intent for Cases created from this Caseplan. | |
| **VersionState** | **string** | The version state of the Caseplan. | [optional] |
| **DataSchemas** | [**List&lt;CaseplanDataSchema&gt;**](CaseplanDataSchema) | The schemas that define all data for Cases from this Caseplan. | [optional] |
| **IntakeSettings** | [**List&lt;IntakeSetting&gt;**](IntakeSetting) | The intake format when collecting data for a Case from this Caseplan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
