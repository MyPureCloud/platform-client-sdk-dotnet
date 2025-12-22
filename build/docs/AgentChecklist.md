# AgentChecklist

## ININ.PureCloudApi.Model.AgentChecklist

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Agent Checklist ID. | [optional] |
| **Name** | **string** | Agent Checklist Name. | |
| **Language** | **string** | Agent Checklist Language. | |
| **ChecklistItems** | [**List&lt;AgentChecklistItem&gt;**](AgentChecklistItem) | Agent Checklist Items. | |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the agent checklist. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who last modified the agent checklist. | [optional] |
| **DateCreated** | **DateTime?** | Date when the agent checklist was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the agent checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
