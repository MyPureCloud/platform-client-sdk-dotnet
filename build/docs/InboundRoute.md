---
title: InboundRoute
---
## ININ.PureCloudApi.Model.InboundRoute

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Pattern** | **string** | The search pattern that the mailbox name should match. | |
| **Queue** | [**DomainEntityRef**](DomainEntityRef.html) | The queue to route the emails to. | [optional] |
| **Priority** | **int?** | The priority to use for routing. | [optional] |
| **Skills** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef.html) | The skills to use for routing. | [optional] |
| **Language** | [**DomainEntityRef**](DomainEntityRef.html) | The language to use for routing. | [optional] |
| **FromName** | **string** | The sender name to use for outgoing replies. | |
| **FromEmail** | **string** | The sender email to use for outgoing replies. | |
| **Flow** | [**DomainEntityRef**](DomainEntityRef.html) | The flow to use for processing the email. | [optional] |
| **ReplyEmailAddress** | [**QueueEmailAddress**](QueueEmailAddress.html) | The route to use for email replies. | [optional] |
| **AutoBcc** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipients that should be  automatically blind copied on outbound emails associated with this InboundRoute. | [optional] |
| **SpamFlow** | [**DomainEntityRef**](DomainEntityRef.html) | The flow to use for processing inbound emails that have been marked as spam. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


