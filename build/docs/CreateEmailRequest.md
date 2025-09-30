# CreateEmailRequest

## ININ.PureCloudApi.Model.CreateEmailRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The ID of the queue to use for routing the email conversation. This field is mutually exclusive with flowId | [optional] |
| **FlowId** | **string** | The ID of the flow to use for routing email conversation. This field is mutually exclusive with queueId | [optional] |
| **Provider** | **string** | The name of the provider that is sourcing the emails. The Provider \&quot;PureCloud Email\&quot; is reserved for native emails. | |
| **SkillIds** | **List&lt;string&gt;** | The list of skill ID&#39;s to use for routing. | [optional] |
| **LanguageId** | **string** | The ID of the language to use for routing. | [optional] |
| **Priority** | **long?** | The priority to assign to the conversation for routing. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | The list of attributes to associate with the customer participant. | [optional] |
| **ToAddress** | **string** | The email address of the recipient of the email. | [optional] |
| **ToName** | **string** | The name of the recipient of the email. | [optional] |
| **FromAddress** | **string** | The email address of the sender of the email. | [optional] |
| **FromName** | **string** | The name of the sender of the email. | [optional] |
| **Subject** | **string** | The subject of the email | [optional] |
| **Direction** | **string** | Specify OUTBOUND to send an email on behalf of a queue, or INBOUND to create an external conversation. An external conversation is one where the provider is not PureCloud based. | [optional] |
| **HtmlBody** | **string** | An HTML body content of the email. | [optional] |
| **TextBody** | **string** | A text body content of the email. | [optional] |
| **ExternalContactId** | **string** | The external contact with which the email should be associated. This field is only valid for OUTBOUND email. | [optional] |
| **UtilizationLabel** | **string** | Optional. The ID of the label to controls the number of agent interactions for INBOUND communications | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
