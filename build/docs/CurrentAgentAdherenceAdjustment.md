# CurrentAgentAdherenceAdjustment

## ININ.PureCloudApi.Model.CurrentAgentAdherenceAdjustment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Agent** | [**UserReference**](UserReference) | The agent to whom this adherence adjustment applies | |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which the agent belonged when the adherence adjustment was submitted | |
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which the agent belonged when the adherence adjustment was submitted | |
| **StartDate** | **DateTime?** | The start timestamp of the adherence adjustment in ISO-8601 format | |
| **LengthMinutes** | **int?** | The length of the adherence adjustment in minutes | |
| **ReasonCode** | [**AdherenceAdjustmentsReasonCodeReference**](AdherenceAdjustmentsReasonCodeReference) | The reason code for this adherence adjustment | |
| **Status** | **string** | The status of the adherence adjustment | |
| **Expired** | **bool?** | Indicates if the adherence adjustment is expired | |
| **SubmitterNotes** | **string** | Notes provided by the submitter for this adherence adjustment | [optional] |
| **ReviewerNotes** | **string** | Notes provided by the reviewer for this adherence adjustment | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference) | The user who reviewed the adherence adjustment, if applicable. The id may be &#39;System&#39; if it was an automated process | [optional] |
| **ReviewedDate** | **DateTime?** | The date the adherence adjustment was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the adherence adjustment | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
