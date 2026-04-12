# ShiftTradeResponseItem

## ININ.PureCloudApi.Model.ShiftTradeResponseItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of this shift trade | |
| **State** | **string** | The state of this shift trade | |
| **ExpirationDate** | **DateTime?** | When this shift trade will expire. Date time is represented as an ISO-8601 string | [optional] |
| **Initiating** | [**ShiftTradeInitiatingSideResponseItem**](ShiftTradeInitiatingSideResponseItem) | Details about the initiating user involved in this shift trade | |
| **Receiving** | [**ShiftTradeReceivingSideResponseItem**](ShiftTradeReceivingSideResponseItem) | Details about the receiving user involved in this shift trade | [optional] |
| **AcceptableIntervals** | [**List&lt;RequiredDateRange&gt;**](RequiredDateRange) | Time frames when the initiating user is willing to accept trades. Empty means giving up the shift | |
| **OneSided** | **bool?** | Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return) | |
| **Target** | [**ShiftTradeTargetResponseItem**](ShiftTradeTargetResponseItem) | The user to whom the shift trade request was sent in a direct trade, or the user with whom a shift trade was Matched | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference) | The admin who approved or denied this shift trade | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp of when the trade request was reviewed by an admin in ISO-8601 format | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this shift trade | |



_PureCloudPlatform.Client.V2 262.0.0_
