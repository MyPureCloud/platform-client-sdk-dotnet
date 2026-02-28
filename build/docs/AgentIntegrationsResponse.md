# AgentIntegrationsResponse

## ININ.PureCloudApi.Model.AgentIntegrationsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Agent** | [**UserReference**](UserReference) | The user associated with the integrations | |
| **SelectedIntegration** | [**WfmIntegrationReference**](WfmIntegrationReference) | The integration selected for the agent. If not set, no integration will be used for the agent | [optional] |
| **UserSelected** | **bool?** | Whether the integration association has been manually selected | [optional] |
| **AssociatedIntegrations** | [**List&lt;AgentIntegrationAssociationResponse&gt;**](AgentIntegrationAssociationResponse) | The list of integrations associated with the agent | |



_PureCloudPlatform.Client.V2 258.0.0_
