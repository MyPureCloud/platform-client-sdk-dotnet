# CaseplanCreate

## ININ.PureCloudApi.Model.CaseplanCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Caseplan. Valid length between 3 and 256 characters. | |
| **DefaultDueDurationInSeconds** | **int?** | The default due duration in seconds for Cases created from the Caseplan. Valid range is between 1 and 31536000 seconds. | [optional] |
| **DefaultTtlSeconds** | **int?** | The default TTL in seconds for Cases created from the Caseplan. Valid range is between 86400 and 31536000 seconds. | [optional] |
| **ReferencePrefix** | **string** | The prefix of the Caseplan reference. Valid length between 2 and 8 alphanumeric characters. | |
| **CustomerIntentId** | **string** | The ID of the customer intent associated with this Caseplan. | |
| **Description** | **string** | The description of the Caseplan. Maximum length of 512 characters. | [optional] |
| **DefaultCaseOwnerId** | **string** | The ID of the default owner of a Case created from the Caseplan. | [optional] |
| **DivisionId** | **string** | The ID of the division the Caseplan belongs to. Use &#39;*&#39; for divisionless caseplans. | |
| **DataSchemas** | [**List&lt;CaseplanDataSchema&gt;**](CaseplanDataSchema) | The schemas that define all data for cases from this Caseplan. The schema must be defined in the TaskManagement namespace. | |
| **IntakeSettings** | [**List&lt;IntakeSetting&gt;**](IntakeSetting) | The intake format when collecting data for a case from this caseplan. There can be a maximum of 10 IntakeSettings defined for a Caseplan. | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
