# EmailConfig

## ININ.PureCloudApi.Model.EmailConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EmailColumns** | **List&lt;string&gt;** | The contact list columns specifying the email address(es) of the contact. | |
| **ContentTemplate** | [**DomainEntityRef**](DomainEntityRef) | The content template used to formulate the email to send to the contact. | [optional] |
| **FromAddress** | [**FromEmailAddress**](FromEmailAddress) | The email address that will be used as the sender of the email. | |
| **ReplyToAddress** | [**ReplyToEmailAddress**](ReplyToEmailAddress) | The email address from which any reply will be sent. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
