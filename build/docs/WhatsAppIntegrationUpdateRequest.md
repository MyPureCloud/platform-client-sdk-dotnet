---
title: WhatsAppIntegrationUpdateRequest
---
## ININ.PureCloudApi.Model.WhatsAppIntegrationUpdateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | WhatsApp Integration name | [optional] |
| **Action** | **string** | The action used to activate and then confirm a WhatsApp Integration. | |
| **AuthenticationMethod** | **string** | The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field.  | [optional] |
| **ConfirmationCode** | **string** | The confirmation code sent by Whatsapp to you during the activation step. If action is set to Confirm, then confirmationCode is a required field. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


