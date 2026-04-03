# CaseplanUpdate

## ININ.PureCloudApi.Model.CaseplanUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Caseplan. Valid length between 3 and 256 characters. | [optional] |
| **DefaultDueDurationInSeconds** | **int?** | The default due duration in seconds for Cases created from the Caseplan. Valid range is between 1 and 31536000 seconds. | [optional] |
| **DefaultTtlSeconds** | **int?** | The default TTL in seconds for Cases created from the Caseplan. Valid range is between 86400 and 31536000 seconds. | [optional] |
| **ReferencePrefix** | **string** | The reference of the Caseplan. Valid length between 2 and 8 alphanumeric characters. | [optional] |
| **CustomerIntentId** | **string** | The ID of the customer intent associated with this Caseplan. | [optional] |
| **Description** | **string** | The description of the Caseplan. Maximum length of 512 characters. | [optional] |
| **DefaultCaseOwnerId** | **string** | The ID of the default owner of a Case created from the Caseplan. Must be a valid UUID. | [optional] |
| **DivisionId** | **string** | The ID of the division the Caseplan belongs to. If divisionId is null or &#39;*&#39;, the Caseplan will be divisionless. | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
