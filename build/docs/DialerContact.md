---
title: DialerContact
---
## ININ.PureCloudApi.Model.DialerContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ContactListId** | **string** | Identifier of the contact list containing this contact | |
| **Data** | **Dictionary&lt;string, Object&gt;** | An ordered map of the contact&#39;s data attributes and values | [optional] |
| **CallRecords** | [**Dictionary&lt;string, CallRecord&gt;**](CallRecord.html) | A map of call records for the contact phone columns | [optional] |
| **Callable** | **bool?** | false if the contact is not to be called | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus.html) | A map of statuses for the contact phone columns | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


