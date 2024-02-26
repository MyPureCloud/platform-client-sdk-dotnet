---
title: FlowPathsElement
---
## ININ.PureCloudApi.Model.FlowPathsElement

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ParentId** | **string** | Unique identifier of the parent element. Will be null for the root element. | [optional] |
| **Type** | **string** | Type of the element. | |
| **Count** | **int?** | Count of all journeys that include this element. | |
| **Flows** | [**List&lt;FlowPathsFlowDetails&gt;**](FlowPathsFlowDetails.html) | Details of flows involved in journeys that include this element. | |
| **FlowOutcomeValue** | **string** | The value of the flow outcome, if the element type is Outcome. | [optional] |
| **FlowMilestone** | [**AddressableEntityRef**](AddressableEntityRef.html) | The flow milestone, set if the element type is Milestone. | [optional] |
| **FlowOutcome** | [**AddressableEntityRef**](AddressableEntityRef.html) | The flow outcome, set if the element type is Outcome or Milestone. | [optional] |
{: class="table table-striped"}


