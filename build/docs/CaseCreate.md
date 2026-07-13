# CaseCreate

## ININ.PureCloudApi.Model.CaseCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CaseplanId** | **string** | The ID of the Caseplan used to create the Case. | |
| **OwnerId** | **string** | The ID of the owner of the Case. | [optional] |
| **Summary** | **string** | Overview information for the Case. Valid length between 3 and 512 characters. | [optional] |
| **ExternalContactId** | **string** | The ID of the External Contact associated with the Case. | |
| **ConversationId** | **string** | The ID of the Conversation associated with the Case. | [optional] |
| **WorkitemId** | **string** | The ID of the Workitem associated with the Case. | [optional] |
| **TtlSeconds** | **int?** | Epoch timestamp in seconds for the Case time-to-live. Cannot be more than 365 days after the current time. | [optional] |
| **Intake** | [**List&lt;Intake&gt;**](Intake) | The intake data for the Case. Maximum of 10 intake objects allowed. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
