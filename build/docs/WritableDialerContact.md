---
title: WritableDialerContact
---
## ININ.PureCloudApi.Model.WritableDialerContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ContactListId** | **string** | The identifier of the contact list containing this contact. | |
| **Data** | **Dictionary&lt;string, Object&gt;** | An ordered map of the contact&#39;s columns and corresponding values. | |
| **LatestSmsEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation.html) | A map of SMS records for the contact phone columns. | [optional] |
| **Callable** | **bool?** | Indicates whether or not the contact can be called. | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus.html) | A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not. | [optional] |
{: class="table table-striped"}


