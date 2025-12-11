# FlowPathsElement

## ININ.PureCloudApi.Model.FlowPathsElement

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ParentId** | **string** | Unique identifier of the parent element. Will be null for the root element. | [optional] |
| **Type** | **string** | Type of the element. | |
| **Count** | **int?** | Count of all journeys that include this element. | |
| **Flows** | [**List&lt;FlowPathsFlowDetails&gt;**](FlowPathsFlowDetails) | Details of flows involved in journeys that include this element. | |
| **FlowOutcomeValue** | **string** | The value of the flow outcome, if the element type is Outcome. | [optional] |
| **FlowMilestone** | [**AddressableEntityRef**](AddressableEntityRef) | The flow milestone, set if the element type is Milestone. | [optional] |
| **FlowOutcome** | [**AddressableEntityRef**](AddressableEntityRef) | The flow outcome, set if the element type is Outcome or Milestone. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
