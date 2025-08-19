# ConditionalGroupActivation

## ININ.PureCloudApi.Model.ConditionalGroupActivation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PilotRule** | [**ConditionalGroupActivationPilotRule**](ConditionalGroupActivationPilotRule) | The pilot rule for this queue, which executes periodically to determine queue health | [optional] |
| **Rules** | [**List&lt;ConditionalGroupActivationRule&gt;**](ConditionalGroupActivationRule) | The set of rules to be periodically executed on the queue (if the pilot rule evaluates as true or there is no pilot rule) | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
