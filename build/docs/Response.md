# Response

## ININ.PureCloudApi.Model.Response

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | Version number required for updates. | [optional] |
| **Libraries** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | One or more libraries response is associated with. | |
| **Texts** | [**List&lt;ResponseText&gt;**](ResponseText) | One or more texts associated with the response. | |
| **CreatedBy** | [**User**](User) | User that created the response | [optional] |
| **DateCreated** | **DateTime?** | The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **InteractionType** | **string** | The interaction type for this response. | [optional] |
| **Substitutions** | [**List&lt;ResponseSubstitution&gt;**](ResponseSubstitution) | Details about any text substitutions used in the texts for this response. | [optional] |
| **SubstitutionsSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | Metadata about the text substitutions in json schema format. | [optional] |
| **ResponseType** | **string** | The response type represented by the response. | [optional] |
| **MessagingTemplate** | [**MessagingTemplate**](MessagingTemplate) | An optional messaging template definition for responseType.MessagingTemplate. | [optional] |
| **Assets** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | Assets used in the response | [optional] |
| **Footer** | [**FooterTemplate**](FooterTemplate) | Footer template definition for responseType.Footer. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
