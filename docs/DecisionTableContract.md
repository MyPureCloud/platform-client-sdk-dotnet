# DecisionTableContract

## ININ.PureCloudApi.Model.DecisionTableContract

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ParentSchema** | [**DomainEntityRef**](DomainEntityRef) | DSS schema entity defining source properties for the decision table contract schemas | [optional] |
| **RowAuthoringSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | JSON schema describing required value types for each column in every row in a decision table | [optional] |
| **ExecutionInputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | JSON schema for execution input data for a decision table | [optional] |
| **ExecutionOutputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | JSON schema for execution output data for a decision table | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
