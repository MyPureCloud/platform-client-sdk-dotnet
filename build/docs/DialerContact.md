---
title: DialerContact
---
## ININ.PureCloudApi.Model.DialerContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ContactListId** | **string** | The identifier of the contact list containing this contact. | |
| **Data** | **Dictionary&lt;string, Object&gt;** | An ordered map of the contact&#39;s columns and corresponding values. | |
| **CallRecords** | [**Dictionary&lt;string, CallRecord&gt;**](CallRecord.html) | A map of call records for the contact phone columns. | [optional] |
| **Callable** | **bool?** | Indicates whether or not the contact can be called. | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus.html) | A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


