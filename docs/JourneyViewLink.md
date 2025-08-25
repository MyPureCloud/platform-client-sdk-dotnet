# JourneyViewLink

## ININ.PureCloudApi.Model.JourneyViewLink

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The identifier of the element downstream | |
| **ConstraintWithin** | [**JourneyViewLinkTimeConstraint**](JourneyViewLinkTimeConstraint) | A time constraint on this link, which requires a customer to complete the downstream element within this amount of time to be counted. | [optional] |
| **ConstraintAfter** | [**JourneyViewLinkTimeConstraint**](JourneyViewLinkTimeConstraint) | A time constraint on this link, which requires a customer must complete the downstream element after this amount of time to be counted. | [optional] |
| **EventCountType** | **string** | The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential. | [optional] |
| **JoinAttributes** | **List&lt;string&gt;** | Other (secondary) attributes on which this link should join the customers being counted | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
