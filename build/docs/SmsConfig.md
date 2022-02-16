---
title: SmsConfig
---
## ININ.PureCloudApi.Model.SmsConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageColumn** | **string** | The Contact List column specifying the message to send to the contact. | |
| **PhoneColumn** | **string** | The Contact List column specifying the phone number to send a message to. | |
| **SenderSmsPhoneNumber** | [**SmsPhoneNumberRef**](SmsPhoneNumberRef.html) | A reference to the SMS Phone Number that will be used as the sender of a message. | |
| **ContentTemplate** | [**DomainEntityRef**](DomainEntityRef.html) | The content template used to formulate the message to send to the contact. | [optional] |
{: class="table table-striped"}


