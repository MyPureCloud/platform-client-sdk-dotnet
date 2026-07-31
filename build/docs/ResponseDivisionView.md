# ResponseDivisionView

## ININ.PureCloudApi.Model.ResponseDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ResponseType** | **string** | The response type represented by the response. | [optional] |
| **Libraries** | [**List&lt;LibraryDivisionView&gt;**](LibraryDivisionView) | One or more libraries response is associated with. | [optional] |
| **Substitutions** | [**List&lt;ResponseSubstitution&gt;**](ResponseSubstitution) | Details about any text substitutions used in the texts for this response. | [optional] |
| **SubstitutionsSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | Metadata about the text substitutions in json schema format. | [optional] |
| **MessagingTemplate** | [**MessagingTemplate**](MessagingTemplate) | An optional messaging template definition for responseType.MessagingTemplate. | [optional] |
| **Form** | [**Form**](Form) | Form template definition for responseType.Form. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
