# CaseAssociation

## ININ.PureCloudApi.Model.CaseAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the association. | [optional] |
| **Name** | **string** |  | [optional] |
| **AssociationType** | **string** | Association type. | [optional] |
| **DateAssociated** | **DateTime?** | Interaction association date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Workitem** | [**WorkitemReference**](WorkitemReference) | Associated workitem ID. | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference) | Associated conversation ID. | [optional] |
| **Stage** | [**StageReference**](StageReference) | The stage related to this association. | [optional] |
| **Step** | [**StepReference**](StepReference) | The step related to this association. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Case** | [**CaseReference**](CaseReference) | Case ID | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
