# DialogflowCXAgent

## ININ.PureCloudApi.Model.DialogflowCXAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Project** | [**DialogflowCXProject**](DialogflowCXProject) | The project this Dialogflow CX agent belongs to. | [optional] |
| **Languages** | **List&lt;string&gt;** | The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc. | [optional] |
| **Environments** | [**List&lt;DialogflowCXEnvironment&gt;**](DialogflowCXEnvironment) | Available environments for this CX agent. | [optional] |
| **Integration** | [**DomainEntityRef**](DomainEntityRef) | The Integration this Dialogflow CX agent was referenced from. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
