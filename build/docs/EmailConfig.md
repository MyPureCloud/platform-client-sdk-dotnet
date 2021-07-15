---
title: EmailConfig
---
## ININ.PureCloudApi.Model.EmailConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EmailColumns** | **List&lt;string&gt;** | The contact list columns specifying the email address(es) of the contact. | |
| **ContentTemplate** | [**DomainEntityRef**](DomainEntityRef.html) | The content template used to formulate the email to send to the contact. | [optional] |
| **FromAddress** | [**FromEmailAddress**](FromEmailAddress.html) | The email address that will be used as the sender of the email. | |
| **ReplyToAddress** | [**ReplyToEmailAddress**](ReplyToEmailAddress.html) | The email address from which any reply will be sent. | [optional] |
{: class="table table-striped"}


