# DialogflowAgent

## ININ.PureCloudApi.Model.DialogflowAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Project** | [**DialogflowProject**](DialogflowProject) | The project this Dialogflow agent belongs to | [optional] |
| **Languages** | **List&lt;string&gt;** | The supported languages of the Dialogflow agent | [optional] |
| **Intents** | [**List&lt;DialogflowIntent&gt;**](DialogflowIntent) | An array of Intents associated with this agent | [optional] |
| **Environments** | **List&lt;string&gt;** | Available environments for this agent | [optional] |
| **Integration** | [**DomainEntityRef**](DomainEntityRef) | The Integration this Dialogflow agent was referenced from. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
