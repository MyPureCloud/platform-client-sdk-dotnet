# CaseCreate

## ININ.PureCloudApi.Model.CaseCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CaseplanId** | **string** | The ID of the caseplan to create the case from. | |
| **OwnerId** | **string** | The ID of the owner of the case. | [optional] |
| **Summary** | **string** | Overview information for the Case. Valid length between 3 and 512 characters. | [optional] |
| **ExternalContactId** | **string** | The ID of the External Contact associated with the Case. | |
| **ConversationId** | **string** | The ID of conversation associated with the Case. | [optional] |
| **WorkitemId** | **string** | The ID of the workitem associated with the Case. | [optional] |
| **TtlSeconds** | **int?** | The epoch timestamp in seconds specifying the time-to-live for the lifetime of the Case. Can not be greater than 365 days from the current time. | [optional] |
| **Intake** | [**List&lt;Intake&gt;**](Intake) | The intake data for the Case. Maximum of 10 intake objects allowed. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
