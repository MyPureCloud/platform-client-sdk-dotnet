# CaseplanCreateResponse

## ININ.PureCloudApi.Model.CaseplanCreateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Caseplan. | [optional] |
| **Division** | [**StarrableDivision**](StarrableDivision) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The description of the Caseplan. | [optional] |
| **ReferencePrefix** | **string** | The prefix used when creating the reference for Cases from the Caseplan. | [optional] |
| **DefaultDueDurationInSeconds** | **int?** | The default due duration in seconds for Cases created from the Caseplan. | [optional] |
| **DefaultTtlSeconds** | **int?** | The default TTL in seconds for Cases created from the Caseplan. | [optional] |
| **DefaultCaseOwner** | [**UserReference**](UserReference) | The default case owner for Cases created from the Caseplan. | [optional] |
| **Latest** | **int?** | The latest version of the Caseplan. | [optional] |
| **Published** | **int?** | The published version of the Caseplan. | [optional] |
| **DateCreated** | **DateTime?** | The Caseplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Caseplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | The Caseplan publication date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The id of the User who modified the Caseplan. | [optional] |
| **CustomerIntent** | [**CustomerIntentReference**](CustomerIntentReference) | The customer intent for the Cases created from the caseplan. | [optional] |
| **VersionState** | **string** | The version state of the Caseplan. | [optional] |
| **DataSchemas** | [**List&lt;CaseplanDataSchema&gt;**](CaseplanDataSchema) | The schemas that define all data for cases from this Caseplan. | [optional] |
| **IntakeSettings** | [**List&lt;IntakeSetting&gt;**](IntakeSetting) | The intake format when collecting data for a case from this caseplan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
