# CaseAssociation

## ININ.PureCloudApi.Model.CaseAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the association. | [optional] |
| **Name** | **string** |  | [optional] |
| **AssociationType** | **string** | The association type. | [optional] |
| **DateAssociated** | **DateTime?** | The date of the interaction association. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Workitem** | [**WorkitemReference**](WorkitemReference) | The associated Workitem. | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference) | The associated Conversation. | [optional] |
| **Stage** | [**StageReference**](StageReference) | The Stage related to this association. | [optional] |
| **Step** | [**StepReference**](StepReference) | The Step related to this association. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Case** | [**CaseReference**](CaseReference) | The Case for this association. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
