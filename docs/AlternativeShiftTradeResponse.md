# AlternativeShiftTradeResponse

## ININ.PureCloudApi.Model.AlternativeShiftTradeResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ShiftOfferJobId** | **string** | The job ID of the alternative shift offer listing, from which the trade was chosen | |
| **ExistingShifts** | [**List&lt;AlternativeShiftAgentScheduledShift&gt;**](AlternativeShiftAgentScheduledShift) | The existing shifts from the offer, may be empty | |
| **OfferedShifts** | [**List&lt;AlternativeShiftAgentScheduledShift&gt;**](AlternativeShiftAgentScheduledShift) | The offered shifts from the offer, may be empty | |
| **Schedule** | [**AlternativeShiftScheduleLookup**](AlternativeShiftScheduleLookup) | The existing schedule information associated with the trade | |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit of this alternative shift trade request | |
| **User** | [**UserReference**](UserReference) | The user who submitted the trade request | |
| **WeekDate** | **String** | The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **ExpirationDate** | **DateTime?** | The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration | [optional] |
| **State** | **string** | The state of this alternative shift trade | |
| **ProcessingStatus** | **string** | The processing status of this alternative shift trade | [optional] |
| **SystemDateReviewed** | **DateTime?** | The timestamp of when the trade request was reviewed by the system in ISO-8601 format | [optional] |
| **AdminDateReviewed** | **DateTime?** | The timestamp of when the trade request was reviewed by an admin in ISO-8601 format | [optional] |
| **AdminReviewedBy** | [**UserReference**](UserReference) | The admin who reviewed this alternative shift trade after system denial | [optional] |
| **Violations** | **List&lt;string&gt;** | A list of trade match violations | |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this alternative shift trade | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
