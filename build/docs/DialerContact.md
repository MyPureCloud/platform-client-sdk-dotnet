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
| **LatestSmsEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation.html) | A map of SMS records for the contact phone columns. | [optional] |
| **Callable** | **bool?** | Indicates whether or not the contact can be called. | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus.html) | A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not. | [optional] |
| **ContactColumnTimeZones** | [**Dictionary&lt;string, ContactColumnTimeZone&gt;**](ContactColumnTimeZone.html) | Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip | [optional] |
| **ConfigurationOverrides** | [**ConfigurationOverrides**](ConfigurationOverrides.html) | the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


