---
title: AgentIntegrationsResponse
---
## ININ.PureCloudApi.Model.AgentIntegrationsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Agent** | [**UserReference**](UserReference.html) | The user associated with the integrations | |
| **SelectedIntegration** | [**WfmIntegrationReference**](WfmIntegrationReference.html) | The integration selected for the agent. If not set, no integration will be used for the agent | [optional] |
| **UserSelected** | **bool?** | Whether the integration association has been manually selected | [optional] |
| **AssociatedIntegrations** | [**List&lt;AgentIntegrationAssociationResponse&gt;**](AgentIntegrationAssociationResponse.html) | The list of integrations associated with the agent | |
{: class="table table-striped"}


