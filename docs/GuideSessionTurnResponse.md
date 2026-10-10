# GuideSessionTurnResponse

## ININ.PureCloudApi.Model.GuideSessionTurnResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Response** | [**GuideSessionTurnResponseData**](GuideSessionTurnResponseData) | The response content for this turn. | [optional] |
| **Status** | **string** | The status of the turn. | [optional] |
| **Result** | **string** | The result of the turn. | [optional] |
| **OutputVariables** | [**List&lt;GuideSessionVariable&gt;**](GuideSessionVariable) | The output variables for this turn. | [optional] |
| **InvocationId** | **string** | Invocation ID for this turn. | [optional] |
| **Invocations** | [**List&lt;GuideSessionTurnInvocationResponse&gt;**](GuideSessionTurnInvocationResponse) | The invocations for this turn. | [optional] |
| **Context** | [**GuideSessionTurnResponseContext**](GuideSessionTurnResponseContext) | The context for this turn, including conversation custom attribute updates. | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
